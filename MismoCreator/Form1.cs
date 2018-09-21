using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using MismoCreator.Properties;

namespace MismoCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "MismoCreator.Mismo.xml";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    dfsMismo.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                dfsMismo.Text = ex.Message;
            }
        }
    

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MismoCreator.Mismo.xml";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(dfsLoanId.Text))
                    result = result.Replace("{LoanId}", dfsLoanId.Text);
                if (!string.IsNullOrEmpty(linkLabel1.Text) && linkLabel1.Text.Contains(":"))
                {
                    var pdfContents = File.ReadAllBytes(linkLabel1.Text);
                    result = result.Replace("{PDFContents}", Convert.ToBase64String(pdfContents));
                }
                if (!string.IsNullOrEmpty(dfsDocumentTypeId.Text))
                    result = result.Replace("{DocumentTypeId}", dfsDocumentTypeId.Text);
                if (dffHtmlEncode.Checked)
                    dfsMismo.Text = HttpUtility.HtmlEncode(result);
                else
                {
                    dfsMismo.Text = result;
                }

                if (dffWrapInJsonObject.Checked)
                {
                    dfsMismo.Text = "{MISMO: \""  + dfsMismo.Text  + "\"}";
                }
                Clipboard.SetText(dfsMismo.Text);
                tsMessage.Text = "Mismo created and copied to clipboard at " + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss tt");
            }

            //var allResources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            //Console.WriteLine(allResources.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                linkLabel1.Text = ofd.FileName;
            }
        }
    }
}
