namespace WidgetGenerator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbContainerHTMLTemplate = new System.Windows.Forms.TextBox();
			this.tbRepeaterHtmlTemplate = new System.Windows.Forms.TextBox();
			this.tbRepeaterJsonArray = new System.Windows.Forms.TextBox();
			this.tbGeneratedOutput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGenerateHTML = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbContainerHTMLTemplate
			// 
			this.tbContainerHTMLTemplate.AllowDrop = true;
			this.tbContainerHTMLTemplate.Location = new System.Drawing.Point(12, 25);
			this.tbContainerHTMLTemplate.Multiline = true;
			this.tbContainerHTMLTemplate.Name = "tbContainerHTMLTemplate";
			this.tbContainerHTMLTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbContainerHTMLTemplate.Size = new System.Drawing.Size(570, 367);
			this.tbContainerHTMLTemplate.TabIndex = 0;
			this.tbContainerHTMLTemplate.Text = "Drag textfile into here.";
			this.tbContainerHTMLTemplate.WordWrap = false;
			this.tbContainerHTMLTemplate.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.tbContainerHTMLTemplate.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			// 
			// tbRepeaterHtmlTemplate
			// 
			this.tbRepeaterHtmlTemplate.AllowDrop = true;
			this.tbRepeaterHtmlTemplate.Location = new System.Drawing.Point(593, 25);
			this.tbRepeaterHtmlTemplate.Multiline = true;
			this.tbRepeaterHtmlTemplate.Name = "tbRepeaterHtmlTemplate";
			this.tbRepeaterHtmlTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbRepeaterHtmlTemplate.Size = new System.Drawing.Size(570, 367);
			this.tbRepeaterHtmlTemplate.TabIndex = 1;
			this.tbRepeaterHtmlTemplate.Text = "Drag textfile into here.";
			this.tbRepeaterHtmlTemplate.WordWrap = false;
			this.tbRepeaterHtmlTemplate.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.tbRepeaterHtmlTemplate.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			// 
			// tbRepeaterJsonArray
			// 
			this.tbRepeaterJsonArray.AllowDrop = true;
			this.tbRepeaterJsonArray.Location = new System.Drawing.Point(12, 411);
			this.tbRepeaterJsonArray.Multiline = true;
			this.tbRepeaterJsonArray.Name = "tbRepeaterJsonArray";
			this.tbRepeaterJsonArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbRepeaterJsonArray.Size = new System.Drawing.Size(570, 367);
			this.tbRepeaterJsonArray.TabIndex = 2;
			this.tbRepeaterJsonArray.Text = "Drag textfile into here.";
			this.tbRepeaterJsonArray.WordWrap = false;
			this.tbRepeaterJsonArray.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.tbRepeaterJsonArray.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			// 
			// tbGeneratedOutput
			// 
			this.tbGeneratedOutput.Location = new System.Drawing.Point(593, 411);
			this.tbGeneratedOutput.Multiline = true;
			this.tbGeneratedOutput.Name = "tbGeneratedOutput";
			this.tbGeneratedOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbGeneratedOutput.Size = new System.Drawing.Size(570, 367);
			this.tbGeneratedOutput.TabIndex = 3;
			this.tbGeneratedOutput.WordWrap = false;
			this.tbGeneratedOutput.Click += new System.EventHandler(this.tbGeneratedOutput_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Container HTML Template";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(590, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Repeater HTML Template";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Repeater Json Array";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(590, 395);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Generated Output";
			// 
			// btnGenerateHTML
			// 
			this.btnGenerateHTML.Location = new System.Drawing.Point(12, 784);
			this.btnGenerateHTML.Name = "btnGenerateHTML";
			this.btnGenerateHTML.Size = new System.Drawing.Size(1151, 85);
			this.btnGenerateHTML.TabIndex = 8;
			this.btnGenerateHTML.Text = "Generate HTML";
			this.btnGenerateHTML.UseVisualStyleBackColor = true;
			this.btnGenerateHTML.Click += new System.EventHandler(this.btnGenerateHtml_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 881);
			this.Controls.Add(this.btnGenerateHTML);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbGeneratedOutput);
			this.Controls.Add(this.tbRepeaterJsonArray);
			this.Controls.Add(this.tbRepeaterHtmlTemplate);
			this.Controls.Add(this.tbContainerHTMLTemplate);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Widget Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbContainerHTMLTemplate;
		private System.Windows.Forms.TextBox tbRepeaterHtmlTemplate;
		private System.Windows.Forms.TextBox tbRepeaterJsonArray;
		private System.Windows.Forms.TextBox tbGeneratedOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGenerateHTML;
	}
}

