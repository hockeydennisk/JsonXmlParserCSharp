using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;    //for File class
using System.Xml;   //for XmlDocument class
//using System.Web.Helpers; //for Json class
using System.Runtime.Serialization.Json; //for Json class
using Newtonsoft.Json;  //for JsonConvert class
using System.Web.Script.Serialization;


namespace JsonParserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxFileName.Text = openFileDialog1.FileName;
        }

        // Parse XML Format
        private void buttonParseXML_Click(object sender, EventArgs e)
        {
            String filePath = textBoxFileName.Text;

            if (File.Exists(filePath))
            {
                String fileString = File.ReadAllText(filePath);
                richTextBox_JsonFormat.Text = fileString;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Get elements
                XmlNodeList motorSerialPort = xmlDoc.GetElementsByTagName("motorSerialPort");
                XmlNodeList camPositionRight = xmlDoc.GetElementsByTagName("camPositionRight");
                XmlNodeList camPositionLeft = xmlDoc.GetElementsByTagName("camPositionLeft");
                XmlNodeList camAngleRight = xmlDoc.GetElementsByTagName("camAngleRight");
                XmlNodeList camAngleLeft = xmlDoc.GetElementsByTagName("camAngleLeft");
                XmlNodeList footMaskBoundaryLeft = xmlDoc.GetElementsByTagName("footMaskBoundaryLeft");
                XmlNodeList footMaskBoundaryRight = xmlDoc.GetElementsByTagName("footMaskBoundaryRight");
                XmlNodeList footMaskBoundaryTop = xmlDoc.GetElementsByTagName("footMaskBoundaryTop");
                XmlNodeList footMaskBoundaryBottom = xmlDoc.GetElementsByTagName("footMaskBoundaryBottom");

                // Display the results
                String outputString;
                outputString = "motorSerialPort = " + motorSerialPort[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camPositionRight = " + camPositionRight[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camPositionLeft = " + camPositionLeft[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camAngleRight = " + camAngleRight[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camAngleLeft = " + camAngleLeft[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryLeft = " + footMaskBoundaryLeft[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryRight = " + footMaskBoundaryRight[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryTop = " + footMaskBoundaryTop[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryBottom = " + footMaskBoundaryBottom[0].InnerText + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
            }
            else
            {
                MessageBox.Show("Open file error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Parse JSON Format
        private void buttonParseJSON_Click(object sender, EventArgs e)
        {
            String filePath = textBoxFileName.Text;

            if (File.Exists(filePath))
            {
                String fileString = File.ReadAllText(filePath);
                richTextBox_JsonFormat.Text = fileString;
                dynamic config = JsonConvert.DeserializeObject(fileString);

                // Display the results
                String outputString;
                outputString = "motorSerialPort = " + config.motorSerialPort + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camPositionRight = " + config.camPositionRight + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camPositionLeft = " + config.camPositionLeft + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camAngleRight = " + config.camAngleRight + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "camAngleLeft = " + config.camAngleLeft + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryLeft = " + config.footMaskBoundaryLeft + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryRight = " + config.footMaskBoundaryRight + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryTop = " + config.footMaskBoundaryTop + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
                outputString = "footMaskBoundaryBottom = " + config.footMaskBoundaryBottom + "\n";
                richTextBox_parsedFormat.AppendText(outputString);
            }
            else
            {
                MessageBox.Show("Open file error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
