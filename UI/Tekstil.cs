using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyData.Resources.MyDatabaseTableAdapters;
using MyData.Resources;

namespace MyData
{
    public partial class Tekstil : Form
    {
        Tools tool = new Tools();

        public Main ma;

        public Tekstil(Main ma)
        {
            InitializeComponent();
            this.ma = ma;
            btnMake.Select();
            btnMake.Focus();

            try
            {
                dataGridView1.DataSource = tool.SqlAdapter("Name, Color, Size, Gender, Family, SKU, Price, Description, Type", "Tekstil.Content", string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker?", "Ryd alle tekstiler", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult result2 = MessageBox.Show("Vil du ryde tekstboksene?", "Ryd alle tekstiler", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Tekstil_ContentTableAdapter t = new Tekstil_ContentTableAdapter();
                t.DeleteALL();
                dataGridView1.DataSource = tool.SqlAdapter("Name, Color, Size, Gender, Family, SKU, Price, Description, Type", "Tekstil.Content", string.Empty);
                dataGridView1.Update();
                if (result2 == DialogResult.Yes)
                {
                    ma.ClearTxt();
                }
                this.Close();
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            List<string> simples = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[8].Value.ToString().Equals("simple"))
                {
                    result.Add(tool.CreateSimple(row.Cells[0].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), tool.RemoveSpecialCharacters(row.Cells[5].Value.ToString())));
                    string newSim = "";
                    string family = "";

                    if (row.Cells[4].Value.ToString().Contains("Stormtech"))
                    {
                        family = "Stormtech";
                    }
                    else
                    {
                        family = row.Cells[4].Value.ToString();
                    }

                    if (row.Cells[0].Value.ToString().Length > 20)
                    {
                        newSim = tool.RemoveSpecialCharacters(row.Cells[5].Value.ToString() + "-" + family.Replace(" ", "-").ToLower() + "-" + row.Cells[0].Value.ToString().Substring(0, 20).ToLower() + "-" + row.Cells[1].Value.ToString().Replace(" ", "-").Replace("/", "-").ToLower() + "-" + row.Cells[2].Value.ToString()).ToLower();
                    }
                    else
                    {
                        newSim = tool.RemoveSpecialCharacters(row.Cells[5].Value.ToString() + "-" + family.Replace(" ", "-").ToLower() + "-" + row.Cells[0].Value.ToString().ToLower() + "-" + row.Cells[1].Value.ToString().Replace(" ", "-").Replace("/", "-").ToLower() + "-" + row.Cells[2].Value.ToString()).ToLower();
                    }

                    if (newSim.Length > 64)
                    {
                        newSim = newSim.Substring(0, 64);
                        simples.Add(newSim);
                    }
                    else
                    {
                        simples.Add(newSim.Replace("--","-"));
                    }
                }
            }

            result.Add(tool.CreateConfigurable(dataGridView1.Rows[0].Cells[0].Value.ToString(), dataGridView1.Rows[0].Cells[4].Value.ToString(), tool.RemoveSpecialCharacters(dataGridView1.Rows[0].Cells[5].Value.ToString()), dataGridView1.Rows[0].Cells[6].Value.ToString(), dataGridView1.Rows[0].Cells[7].Value.ToString(), simples));

            if (dataGridView1.Rows[0].Cells[4].Value.ToString().Contains("Stormtech"))
            {
                Output o = new Output(result, "Stormtech" + "-" + dataGridView1.Rows[0].Cells[5].Value.ToString(), dataGridView1.Rows[0].Cells[4].Value.ToString());
                o.ShowDialog();
            }
            else
            {
                Output o = new Output(result, dataGridView1.Rows[0].Cells[4].Value.ToString() + "-" + dataGridView1.Rows[0].Cells[5].Value.ToString(), dataGridView1.Rows[0].Cells[4].Value.ToString());
                o.ShowDialog();
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
