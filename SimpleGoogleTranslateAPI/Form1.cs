using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGoogleTranslateAPI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Events

		private void cbxSourceLang_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbxDestLang_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tbxSource_TextChanged(object sender, EventArgs e)
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

		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			tbxDest.Text = Translate(tbxSource.Text);
		}

		private void cbxAutoTranslate_CheckedChanged(object sender, EventArgs e)
		{

		}
		#endregion

		#region Methods
		private string Translate(string input, string srcLang = "vi", string srcDest = "en")
		{
			string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={srcLang}&tl={srcDest}&dt=t&q={Uri.EscapeUriString(input)}";
			HttpClient httpClient = new HttpClient();
			string result = httpClient.GetStringAsync(url).Result;
			var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
			var translationItems = jsonData[0];
			string translation = "";
			foreach (object item in translationItems)
			{
				IEnumerable translationLineObject = item as IEnumerable;
				IEnumerator translationLineString = translationLineObject.GetEnumerator();
				translationLineString.MoveNext();
				translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
			}
			if (translation.Length > 1) { translation = translation.Substring(1); };
			return translation;
		}
		#endregion

	}
}
