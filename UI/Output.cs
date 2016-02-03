using MyData.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyData
{
    public partial class Output : Form
    {
        string names;

        Tools tool = new Tools();

        public Output(List<string> output, string name, string family)
        {
            InitializeComponent();
            btnDownload.Select();
            btnDownload.Focus();

            names = name;

            if (family.Contains("Stormtech"))
            {
                family = "Stormtech";
            }

            string csv = Properties.Resources.csv.Replace(@"XFAMILY", family.Replace("-", "").ToLower());
            rtbOutput.Text = csv + Environment.NewLine;

            csv.ToLower();

            foreach (var item in output)
            {
                rtbOutput.Text += item + Environment.NewLine;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = ".csv";
                sfd.Filter = "CSV file|*.csv;";
                sfd.FileName = names.ToLower() + "-export.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName.ToLower(), rtbOutput.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
