using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using MyData.Resources;
using MyData.Resources.MyDatabaseTableAdapters;
using System.Deployment.Application;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace MyData
{
    public partial class Main : Form
    {
        private string logPath = Application.StartupPath + @"\CSV-log.txt";
        Tekstil_ContentTableAdapter tc = new Tekstil_ContentTableAdapter();
        Tools tool = new Tools();

        int lc;
        bool dc;

        public string DKK { get; set; }

        public void RefreshGrid()
        {
            lbTextileColor.Refresh();
            lbTextileColor.Update();
        }

        public void ClearTxt()
        {
            txtTextileName.Text = "";
            txtTextileSKU.Text = "";
            txtOwnColor.Text = "";
            txtOwnSize.Text = "";
            rbtDescription.Text = "";
            txtPrice.Text = "";
            cbProducent.SelectedIndex = 0;
        }

        private Version GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        public Main()
        {
            InitializeComponent();

            try
            {
                cbTextileFamilly.DataSource = tool.SqlAdapter("Family", "Tekstil.Family", "ORDER BY Family");
                cbTextileGender.DataSource = tool.SqlAdapter("Gender", "Tekstil.Gender", string.Empty);
                lbTextileColor.DataSource = tool.SqlAdapter("Color", "Tekstil.Color", "WHERE (Family = N'" + cbTextileFamilly.SelectedValue.ToString() + "')");
                lbTextileSize.DataSource = tool.SqlAdapter("Size", "Tekstil.Size", "WHERE (Type = N'" + cbTextileGender.SelectedValue.ToString() + "') ORDER BY Sort");
                cbCurrency.SelectedIndex = 0;

                using (System.Net.WebClient webClient = new System.Net.WebClient())
                {
                    System.Net.WebClient wb = new System.Net.WebClient();
                    var EUR = wb.DownloadString("http://api.fixer.io/latest?base=EUR&symbols=DKK");
                    var USD = wb.DownloadString("http://api.fixer.io/latest?base=USD&symbols=DKK");
                    var GBP = wb.DownloadString("http://api.fixer.io/latest?base=GBP&symbols=DKK");
                    JObject rssEUR = JObject.Parse(EUR);
                    JObject rssUSD = JObject.Parse(USD);
                    JObject rssGBP = JObject.Parse(GBP);

                    Properties.Settings.Default.EUR = decimal.Parse(rssEUR["rates"]["DKK"].ToString(), new NumberFormatInfo() { NumberDecimalSeparator = "." });
                    Properties.Settings.Default.USD = (decimal)rssUSD["rates"]["DKK"];
                    Properties.Settings.Default.GBP = (decimal)rssGBP["rates"]["DKK"];

                    Console.WriteLine(Properties.Settings.Default.EUR + "+" + Properties.Settings.Default.USD + "+" + Properties.Settings.Default.GBP);
                }

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    this.labelVersion.Text = string.Format("CSV Creator - v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
                    Properties.Settings.Default.Version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Main Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTextileAdd_Click(object sender, EventArgs e)
        {
            if (txtTextileName.Text != String.Empty && txtTextileSKU.Text != String.Empty && txtPrice.Text != String.Empty)
            {
                lblWarning1.Visible = false;
                lblWarning2.Visible = false;
                lblWarning3.Visible = false;

                if (cbSpecialProduct.Checked)
                {
                    switch (tool.SearchConfig(txtTextileSKU.Text))
                    {
                        case false:
                            tc.InsertItem(txtTextileName.Text, "", "", cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), rbtDescription.Text, "configurable");
                            break;
                    }
                }

                if (cbChooseColor.Checked && cbChooseSize.Checked)
                {
                    List<string> colorLines = new List<string>(txtOwnColor.Lines);
                    List<string> sizeLines = new List<string>(txtOwnSize.Lines);
                    foreach (string line in colorLines)
                    {
                        foreach (string line2 in sizeLines)
                        {
                            if (!cbSpecialProduct.Checked)
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, line, line2, cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), rbtDescription.Text, "simple");
                            }
                            else
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, line, line2, cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), "", "simple");
                            }
                        }
                    }
                    Tekstil t = new Tekstil(this);
                    t.ShowDialog();
                }

                if (cbChooseColor.Checked && !cbChooseSize.Checked)
                {
                    List<string> colorLines = new List<string>(txtOwnColor.Lines);
                    foreach (string line in colorLines)
                    {
                        foreach (var item in lbTextileSize.SelectedItems)
                        {
                            if (!cbSpecialProduct.Checked)
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, line, lbTextileSize.GetItemText(item), cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), rbtDescription.Text, "simple");
                            }
                            else
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, line, lbTextileSize.GetItemText(item), cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), "", "simple");
                            }
                        }
                    }
                    Tekstil t = new Tekstil(this);
                    t.ShowDialog();
                }

                if (cbChooseSize.Checked && !cbChooseColor.Checked)
                {
                    List<string> sizeLines = new List<string>(txtOwnSize.Lines);
                    foreach (var item in lbTextileColor.SelectedItems)
                    {
                        foreach (string line in sizeLines)
                        {
                            if (!cbSpecialProduct.Checked)
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, lbTextileColor.GetItemText(item), line, cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), rbtDescription.Text, "simple");
                            }
                            else
                            {
                                tekstil_ContentTableAdapter.Insert(txtTextileName.Text, lbTextileColor.GetItemText(item), line, cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), "", "simple");
                            }
                        }
                    }
                    Tekstil t = new Tekstil(this);
                    t.ShowDialog();
                }

                if (!cbChooseColor.Checked && !cbChooseSize.Checked)
                {
                    foreach (var item in lbTextileColor.SelectedItems)
                    {
                        foreach (var item2 in lbTextileSize.SelectedItems)
                        {
                            if (!cbSpecialProduct.Checked)
                            {
                                try
                                {
                                    tekstil_ContentTableAdapter.Insert(txtTextileName.Text, lbTextileColor.GetItemText(item), lbTextileSize.GetItemText(item2), cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), rbtDescription.Text, "simple");
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            else
                            {
                                try
                                {
                                    tekstil_ContentTableAdapter.Insert(txtTextileName.Text, lbTextileColor.GetItemText(item), lbTextileSize.GetItemText(item2), cbTextileGender.SelectedValue.ToString(), cbTextileFamilly.SelectedValue.ToString(), txtTextileSKU.Text, tool.CurrencyConvert(cbCurrency.SelectedIndex, txtPrice.Text), "", "simple");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }
                    }
                    Tekstil t = new Tekstil(this);
                    t.ShowDialog();
                }
            }
            else
            {
                if (txtTextileName.Text == String.Empty && txtTextileSKU.Text == String.Empty && txtPrice.Text == String.Empty)
                {
                    lblWarning1.Visible = true;
                    lblWarning2.Visible = true;
                    lblWarning3.Visible = true;
                }
                else
                {
                    if (txtTextileName.Text == String.Empty)
                    {
                        lblWarning1.Visible = true;
                    }
                    if (txtTextileSKU.Text == String.Empty)
                    {
                        lblWarning2.Visible = true;
                    }
                    if (txtPrice.Text == string.Empty)
                    {
                        lblWarning3.Visible = true;
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Content' table. You can move, or remove it, as needed.
            this.tekstil_ContentTableAdapter.Fill(this.myDatabase.Tekstil_Content);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Gender' table. You can move, or remove it, as needed.
            this.tekstil_GenderTableAdapter.Fill(this.myDatabase.Tekstil_Gender);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Family' table. You can move, or remove it, as needed.
            this.tekstil_FamilyTableAdapter.Fill(this.myDatabase.Tekstil_Family);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Size_Adult' table. You can move, or remove it, as needed.
            this.tekstil_Size_AdultTableAdapter.Fill(this.myDatabase.Tekstil_Size_Adult);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Color' table. You can move, or remove it, as needed.
            this.tekstil_ColorTableAdapter.Fill(this.myDatabase.Tekstil_Color);
            // TODO: This line of code loads data into the 'myData.Tekstil_Gender' table. You can move, or remove it, as needed.
        }

        private void cbTextileGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTextileSize.DataSource = tool.SqlAdapter("Size", "Tekstil.Size", "WHERE (Type = N'" + cbTextileGender.SelectedValue.ToString() + "') ORDER BY Sort");
            lbTextileSize.Update();
        }

        private void lbTextileColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblColorCount.Text = lbTextileColor.SelectedIndices.Count.ToString();
        }

        private void btnTekstilWatch_Click(object sender, EventArgs e)
        {
            Tekstil t = new Tekstil(this);
            t.ShowDialog();
        }

        private void cbTextileFamilly_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbTextileColor.DataSource = tool.SqlAdapter("Color", "Tekstil.Color", "WHERE (Family = N'" + cbTextileFamilly.SelectedValue.ToString() + "') ORDER BY Color");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettingsTekstilColor_Click(object sender, EventArgs e)
        {
            UI.Settings.Color ac = new UI.Settings.Color(this);
            ac.ShowDialog();
        }

        private void cbChooseColor_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbChooseColor.Checked)
            {
                case true:
                    lbTextileColor.Visible = false;
                    txtOwnColor.Visible = true;
                    break;

                case false:
                    lbTextileColor.Visible = true;
                    txtOwnColor.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void cbChooseSize_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbChooseSize.Checked)
            {
                case true:
                    lbTextileSize.Visible = false;
                    txtOwnSize.Visible = true;
                    break;

                case false:
                    lbTextileSize.Visible = true;
                    txtOwnSize.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void txtOwnColor_TextChanged(object sender, EventArgs e)
        {
            if (cbChooseColor.Checked)
            {
                if (lc == 0)
                {
                    lc += 1;
                }
                lc = txtOwnColor.Lines.Count();
                lblColorCount.Text = lc.ToString();
            }
        }

        private void imgDescription_Click(object sender, EventArgs e)
        {
            Main m = new Main();

            m.Size = new System.Drawing.Size(m.Width, m.Height);

            if (!dc)
            {
                this.imgDescription.Image = Properties.Resources.triangle_up;
                imgDescription.Update();
                m.Height = 478;
                dc = true;
            }
            else
            {
                this.imgDescription.Image = Properties.Resources.triangle_down;
                imgDescription.Update();
                m.Height = 332;
                m.Update();
                dc = false;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbSpecialProduct_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbSpecialProduct.Checked)
            {
                case true:
                    cboxSpecialProduct.Enabled = true;
                    break;

                case false:
                    cboxSpecialProduct.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        private void btnSettingsTekstilSize_Click(object sender, EventArgs e)
        {
            UI.Settings.Size ac = new UI.Settings.Size(this);
            ac.ShowDialog();
        }

        private void cbProducent_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProducent.SelectedIndex)
            {
                case 1:
                    txtTextileName.Text = cbProducent.GetItemText(cbProducent.SelectedItem) + " ";
                    txtTextileSKU.Text = "jn";
                        break;
                case 3:
                    txtTextileName.Text = cbProducent.GetItemText(cbProducent.SelectedItem) + " ";
                    txtTextileSKU.Text = "mb";
                    break;

                case 4:
                    txtTextileName.Text = cbProducent.GetItemText(cbProducent.SelectedItem) + " ";
                    break;

                default:
                    txtTextileName.Text = "";
                    txtTextileSKU.Text = "";
                    break;
            }
        }
    }
}
