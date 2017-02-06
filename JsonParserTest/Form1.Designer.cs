namespace JsonParserTest
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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox_JsonFormat = new System.Windows.Forms.RichTextBox();
            this.buttonParseXML = new System.Windows.Forms.Button();
            this.richTextBox_parsedFormat = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonParseJSON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(252, 81);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(549, 36);
            this.textBoxFileName.TabIndex = 0;
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(862, 72);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(73, 48);
            this.buttonBrowseFile.TabIndex = 1;
            this.buttonBrowseFile.Text = "...";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "XML/JSON File:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox_JsonFormat
            // 
            this.richTextBox_JsonFormat.Location = new System.Drawing.Point(63, 203);
            this.richTextBox_JsonFormat.Name = "richTextBox_JsonFormat";
            this.richTextBox_JsonFormat.Size = new System.Drawing.Size(537, 537);
            this.richTextBox_JsonFormat.TabIndex = 3;
            this.richTextBox_JsonFormat.Text = "";
            // 
            // buttonParseXML
            // 
            this.buttonParseXML.Location = new System.Drawing.Point(63, 782);
            this.buttonParseXML.Name = "buttonParseXML";
            this.buttonParseXML.Size = new System.Drawing.Size(537, 125);
            this.buttonParseXML.TabIndex = 4;
            this.buttonParseXML.Text = "Click to Parse Puhu Config XML Format File";
            this.buttonParseXML.UseVisualStyleBackColor = true;
            this.buttonParseXML.Click += new System.EventHandler(this.buttonParseXML_Click);
            // 
            // richTextBox_parsedFormat
            // 
            this.richTextBox_parsedFormat.Location = new System.Drawing.Point(721, 203);
            this.richTextBox_parsedFormat.Name = "richTextBox_parsedFormat";
            this.richTextBox_parsedFormat.Size = new System.Drawing.Size(537, 537);
            this.richTextBox_parsedFormat.TabIndex = 5;
            this.richTextBox_parsedFormat.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original XML/JSON Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parsed config settings:";
            // 
            // buttonParseJSON
            // 
            this.buttonParseJSON.Location = new System.Drawing.Point(721, 782);
            this.buttonParseJSON.Name = "buttonParseJSON";
            this.buttonParseJSON.Size = new System.Drawing.Size(537, 125);
            this.buttonParseJSON.TabIndex = 8;
            this.buttonParseJSON.Text = "Click to Parse Puhu Config JSON Format File";
            this.buttonParseJSON.UseVisualStyleBackColor = true;
            this.buttonParseJSON.Click += new System.EventHandler(this.buttonParseJSON_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = ">>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1332, 977);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonParseJSON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_parsedFormat);
            this.Controls.Add(this.buttonParseXML);
            this.Controls.Add(this.richTextBox_JsonFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.textBoxFileName);
            this.Name = "Form1";
            this.Text = "JsonParserTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox_JsonFormat;
        private System.Windows.Forms.Button buttonParseXML;
        private System.Windows.Forms.RichTextBox richTextBox_parsedFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonParseJSON;
        private System.Windows.Forms.Label label4;
    }
}

