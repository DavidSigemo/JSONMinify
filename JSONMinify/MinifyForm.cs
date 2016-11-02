using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONMinify
{
    public partial class MinifyForm : Form
    {
        public MinifyForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtboxFile.Text = fileDialog.FileName;
            }
        }

        private void minifyJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string jsonString = reader.ReadToEnd();
                var json = JsonConvert.DeserializeObject(jsonString, new JsonSerializerSettings { Formatting = Formatting.None });
                Regex.Replace(jsonString, "(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+", "$1");

                filePath = filePath.Replace(".json", "");
                System.IO.File.WriteAllText($"{filePath}.min.json", JsonConvert.SerializeObject(json, Formatting.None));
            }
        }

        private void btnMinify_Click(object sender, EventArgs e)
        {
            if (txtboxFile.Text != "")
                minifyJson(txtboxFile.Text);
            MessageBox.Show("Done!");
            Close();
        }
    }
}
