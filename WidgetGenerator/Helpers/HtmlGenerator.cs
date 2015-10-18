using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetGenerator.Helpers
{
	class HtmlGenerator
	{

		#region ================================================== Constructor & Members ==================================================

		private string htmlContainer;
		private string htmlRepeater;
		private Dictionary<string, string>[] dicValueSets;

		private const string REPEATER_TEMPLATE = "{{REPEATER_TEMPLATE}}";

		public HtmlGenerator(string htmlContainer, string htmlRepeater, Dictionary<string, string>[] dicValueSets)
		{
			this.htmlContainer = htmlContainer;
			this.htmlRepeater  = htmlRepeater;
			this.dicValueSets  = dicValueSets;
		}

		#endregion ================================================== Constructor & Members ==================================================




		#region ================================================== Private Methods ==================================================

		private string GenerateRepeaterHtml(int index)
		{
			string repeaterHtml = String.Copy(this.htmlRepeater);

			Dictionary<string, string> dicValueSet = this.dicValueSets[index];

			foreach (string key in dicValueSet.Keys)
			{
				string repeaterTag = "{{" + key + "}}";
				string value       = dicValueSet[key];
				repeaterHtml       = repeaterHtml.Replace(repeaterTag, value);
			}

			return repeaterHtml;
		}

		#endregion ================================================== Private Methods ==================================================




		#region ================================================== Public Methods ==================================================

		public string GenerateContainerHtml()
		{
			string[] repeaterHtmls = this.dicValueSets
				.Select((x, i) => GenerateRepeaterHtml(i))
				.ToArray();

			string repeaterHtml = String.Join("\r\n", repeaterHtmls);

			return this.htmlContainer.Replace(REPEATER_TEMPLATE, repeaterHtml);
		}

		#endregion ================================================== Public Methods ==================================================

	}
}
