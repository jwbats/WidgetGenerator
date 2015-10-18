using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using WidgetGenerator.Helpers;

using Newtonsoft.Json;

namespace WidgetGenerator
{
	public partial class Form1 : Form
	{

		#region ================================================== Constructor ==================================================

		public Form1()
		{
			InitializeComponent();
		}

		#endregion ================================================== Constructor ==================================================




		#region ================================================== Form Events ==================================================

		private void textBox_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void textBox_DragDrop(object sender, DragEventArgs e)
		{
			// get file
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			string file = files.FirstOrDefault();

			// set file
			TextBox textBox = sender as TextBox;
			textBox.Text = File.ReadAllText(file);
		}

		private void btnGenerateHtml_Click(object sender, EventArgs e)
		{
			string htmlContainer                      = tbContainerHTMLTemplate.Text;
			string htmlRepeater                       = tbRepeaterHtmlTemplate.Text;
			string repeaterJsonArray                  = tbRepeaterJsonArray.Text;
			Dictionary<string, string>[] dicValueSets = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(repeaterJsonArray);

			HtmlGenerator htmlGenerator = new HtmlGenerator(htmlContainer, htmlRepeater, dicValueSets);
			tbGeneratedOutput.Text      = htmlGenerator.GenerateContainerHtml();
		}

		private void tbGeneratedOutput_Click(object sender, EventArgs e)
		{
			Clipboard.SetData("Text", tbGeneratedOutput.Text);
		}

		#endregion ================================================== Form Events ==================================================

	}
}
