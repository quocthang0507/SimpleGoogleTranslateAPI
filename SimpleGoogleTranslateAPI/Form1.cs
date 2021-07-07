using Newtonsoft.Json;
using SimpleGoogleTranslateAPI.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGoogleTranslateAPI
{
	public partial class Form1 : Form
	{
		private const string languageFile = "LanguageCodes.txt";
		private Stopwatch watch = new();
		private HttpClient httpClient = new();
		private string source_language = "auto", target_language = "vi";

		public Form1()
		{
			InitializeComponent();
		}

		#region Events
		private void Form1_Load(object sender, EventArgs e)
		{
			if (File.Exists(languageFile))
			{
				LanguageCodes langCodes = new("LanguageCodes.txt");
				cbxSourceLang.DataSource = langCodes.List;
				cbxDestLang.DataSource = langCodes.GetClonedList;
			}
			else
			{
				var dialogResult = MessageBox.Show("Không tìm thấy tập tin ngôn ngữ LanguageCodes.txt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (DialogResult.OK == dialogResult)
					Application.Exit();
			}
		}

		private void cbxSourceLang_SelectedIndexChanged(object sender, EventArgs e)
		{
			source_language = cbxSourceLang.SelectedValue.ToString();
		}

		private void cbxDestLang_SelectedIndexChanged(object sender, EventArgs e)
		{
			target_language = cbxDestLang.SelectedValue.ToString();
		}

		private void cbxAutoTranslate_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxAutoTranslate.Checked)
				timerAutoTranslate.Start();
			else
				timerAutoTranslate.Stop();
		}

		// Set delay time for automatically translating
		private void timerAutoTranslate_Tick(object sender, EventArgs e)
		{
			if (cbxAutoTranslate.Checked)
				btnTranslate.PerformClick();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tbxSource.Clear();
			tbxDest.Clear();
		}

		private void btnSwap_Click(object sender, EventArgs e)
		{
			string temp = cbxSourceLang.Text;
			cbxSourceLang.Text = cbxDestLang.Text;
			cbxDestLang.Text = temp;

			temp = tbxSource.Text;
			tbxSource.Text = tbxDest.Text;
			tbxDest.Text = temp;
		}

		private async void btnTranslate_Click(object sender, EventArgs e)
		{
			tbxDest.Text = await Translate(tbxSource.Text, source_language, target_language);
			// tbxDest.Text = await Translate_v2(tbxSource.Text, srcLang, dstLang);
		}
		#endregion

		#region Methods
		/// <summary>
		/// Translate a text from one language into another
		/// </summary>
		/// <param name="text">The text to translate</param>
		/// <param name="source_language">"auto" by default. The two-letter language code of the source language</param>
		/// <param name="target_language">"vi" by default. The two-letter language code of the target language</param>
		/// <returns>The translated text in target language</returns>
		private async Task<string> Translate(string text, string source_language = "auto", string target_language = "vi")
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				watch.Restart();
				//watch.Start();

				string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={source_language}&tl={target_language}&dt=t&q={Uri.EscapeUriString(text)}";
				try
				{
					string result = await httpClient.GetStringAsync(url);
					string translation = "";

					var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
					var translationItems = jsonData[0];
					foreach (object item in translationItems)
					{
						IEnumerable translationLineObject = item as IEnumerable;
						IEnumerator translationLineString = translationLineObject.GetEnumerator();
						translationLineString.MoveNext();
						translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
					}
					if (translation.Length > 1) { translation = translation[1..]; };

					watch.Stop();
					lblStatus.Text = $"Thời gian phản hồi là {watch.ElapsedMilliseconds} mili giây";
					return translation;
				}
				catch(HttpRequestException e)
				{
					cbxAutoTranslate.Checked = false;
					MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return string.Empty;
		}

		/// <summary>
		/// Translate a text from one language into another (other API)
		/// </summary>
		/// <param name="text">The text to translate</param>
		/// <param name="source_language">"auto" by default. The two-letter language code of the source language</param>
		/// <param name="target_language">"vi" by default. The two-letter language code of the target language</param>
		/// <returns>The translated text in target language</returns>
		private async Task<string> Translate_v2(string input, string source_language = "auto", string target_language = "vi")
		{
			if (!string.IsNullOrWhiteSpace(input))
			{
				watch.Restart();

				string url = $"https://clients5.google.com/translate_a/t?client=dict-chrome-ex&sl={source_language}&tl={target_language}&dt=t&q={Uri.EscapeUriString(input)}&ie=UTF-8&oe=UTF-8";
				string result = await httpClient.GetStringAsync(url);
				var jsonData = JsonConvert.DeserializeObject<JSONv2>(result);
				string translation = "";

				watch.Stop();
				lblStatus.Text = $"Thời gian phản hồi là {watch.ElapsedMilliseconds} mili giây";
				return translation;
			}
			return string.Empty;
		}
		#endregion

	}
}
