using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGoogleTranslateAPI.Classes
{
	public class LanguageCode
	{
		public string ISOLangName { get; set; }
		public string NativeLangName { get; set; }
		public string DisplayName
		{
			get
			{
				return ISOLangName + ", " + NativeLangName;
			}
		}
		public string ISO639_1Name { get; set; }
	}

	public class LanguageCodes
	{
		public List<LanguageCode> List { get; set; }

		public List<LanguageCode> GetClonedList
		{
			get
			{
				return List.GetRange(0, List.Count);
			}
		}

		public LanguageCodes(string pathToTextFile)
		{
			List = new List<LanguageCode>();

			using StreamReader reader = new(pathToTextFile);
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				string[] arr = line.Split('\t');
				if (arr.Length == 3)
					List.Add(new LanguageCode
					{
						ISOLangName = arr[0],
						NativeLangName = arr[1],
						ISO639_1Name = arr[2]
					});
			}
		}
	}
}
