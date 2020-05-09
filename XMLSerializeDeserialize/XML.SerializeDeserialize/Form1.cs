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
using System.Windows.Forms;

namespace XML.SerializeDeserialize
{
    public partial class Form1 : Form
    {
        private string Sample1FilePath { get; set; }
        private string Sample2FilePath { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var path = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)).Replace("file:\\", "");
            var basePath = Application.StartupPath;

            var sampleXml = "Sample.config";
            lblSamplePath.Text = "";
            if (!File.Exists(Path.Combine(basePath, sampleXml)))
            {
                MessageBox.Show($"Sample.config missing from {basePath}.");
            }
            else
            {
                Sample1FilePath = Path.Combine(basePath, sampleXml);
                lblSamplePath.Text = Sample1FilePath;
            }

            var sample2Xml = "ConnectionStrings.config";
            lblSample2Path.Text = "";
            if (!File.Exists(Path.Combine(basePath, sample2Xml)))
            {
                MessageBox.Show($"ConnectionStrings.config missing from {basePath}.");
            }
            else
            {
                Sample2FilePath = Path.Combine(basePath, sample2Xml);
                lblSample2Path.Text = Sample2FilePath;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSample1Deserialize_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();

            if (string.IsNullOrWhiteSpace(Sample1FilePath))
            {
                MessageBox.Show("Sample 1 config file missing");
                return;
            }
            
            txtResults.AppendText($"\r\nDeserializing : {Sample1FilePath}");
            txtResults.AppendText("\r\nReading file");

            try
            {
                var data = XmlUtility.DeserializeFilePath<Sample1_1RootModel>(Sample1FilePath);
                txtResults.AppendText("\r\nConverted to object Sample1_1RootModel sucessfully!");
            }
            catch(Exception ex)
            {
                txtResults.AppendText($"\r\n{ex.Message}");
            }
        }

        private void btnSample1Serialize_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            txtResults.AppendText("\r\nBuilding object per Sample.Config");

            var connStrings = new List<Sample1_3StringModel>();
            for (var i = 0; i< 3; i++)
            {
                connStrings.Add(new Sample1_3StringModel() { Name = $"Connection{i+1}", UserId = $"UserId{i+1}", Password = $"Password{i+1}" });
            }

            var section = new Sample1_2SectionModel() { ConnectionString = connStrings };

            var root = new Sample1_1RootModel() { Section = section };

            txtResults.AppendText("\r\nBuilding complete. Serializing...");
            try
            {
                var xml = XmlUtility.Serialize<Sample1_1RootModel>(root);
                txtResults.AppendText($"\r\n\r\n{xml}");
            }
            catch (Exception ex)
            {
                txtResults.AppendText($"\r\n{ex.Message}");
            }

        }

        private void btnSample2Deserialize_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();

            if (string.IsNullOrWhiteSpace(Sample2FilePath))
            {
                MessageBox.Show("Sample 2 config file missing");
                return;
            }

            txtResults.AppendText($"\r\nDeserializing : {Sample2FilePath}");
            txtResults.AppendText("\r\nReading file");

            try
            {
                var data = XmlUtility.DeserializeFilePath<Sample2_1RootModel>(Sample2FilePath);
                txtResults.AppendText("\r\nConverted to object Sample2_1RootModel sucessfully!");
            }
            catch (Exception ex)
            {
                txtResults.AppendText($"\r\n{ex.Message}");
            }
        }

        private void btnSample2Serialize_Click(object sender, EventArgs e)
        {
            btnClear.PerformClick();
            txtResults.AppendText($"\r\nBuilding object per {Sample2FilePath}");

            var connString = new List<Sample2_2StringModel>();
            for (var i=0; i<3; i++)
            {
                connString.Add(new Sample2_2StringModel()
                {
                    Name = $"name{i + 1}",
                    ProviderName = "Oracle.DataAccess.Client",
                    ConnectionString = $"Data Source=My{i + 1}.Source;User Id=UserId{i + 1};Password=Password{i + 1};Validate Connection = true;"
                });
            }

            var root = new Sample2_1RootModel() { Clear = "", ConnectionStrings = connString };

            txtResults.AppendText("\r\nBuilding complete. Serializing...");
            try
            {
                var xml = XmlUtility.Serialize<Sample2_1RootModel>(root);
                txtResults.AppendText($"\r\n\r\n{xml}");
            }
            catch (Exception ex)
            {
                txtResults.AppendText($"\r\n{ex.Message}");
            }
        }
    }
}
