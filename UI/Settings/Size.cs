using MyData.Resources.MyDatabaseTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyData.Resources;

namespace MyData.UI.Settings
{
    public partial class Size : Form
    {
        public Main main;
        Tools tool = new Tools();
        bool vali = false;

        public Size(Main main)
        {
            InitializeComponent();
            this.main = main;
            cbDelSize.Enabled = false;
        }

        Tekstil_SizeTableAdapter s = new Tekstil_SizeTableAdapter();

        private void AddColor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Size' table. You can move, or remove it, as needed.
            this.tekstil_SizeTableAdapter.Fill(this.myDatabase.Tekstil_Size);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Gender' table. You can move, or remove it, as needed.
            this.tekstil_GenderTableAdapter.Fill(this.myDatabase.Tekstil_Gender);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Color' table. You can move, or remove it, as needed.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                try
                {
                    s.Insert(txtName.Text, cbGender.SelectedValue.ToString());
                    pbValidation.Image = Properties.Resources.Check_Circle;
                    main.RefreshGrid();
                }
                catch (Exception ex)
                {
                    pbValidation.Image = Properties.Resources.Cross_Cricle;
                    pbValidation.Update();
                    MessageBox.Show("Insert Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!vali)
            {
                pbValidation.Image = null;
                vali = true;
            }
        }

        private void cbDelGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "";

            switch (cbDelGender.SelectedValue.ToString())
            {
                case "Male":
                    type = "Adult";
                    break;
                case "Female":
                    type = "Adult";
                    break;
                case "Unisex":
                    type = "Adult";
                    break;
                case "Kids":
                    type = "Kids";
                    break;
                default:
                    break;
            }

            cbDelSize.Enabled = true;
            cbDelSize.DataSource = tool.SqlAdapter("Size", "Tekstil.Size", "WHERE (Type = N'" + type + "') ORDER BY Id");
            cbDelSize.Update();
            cbDelSize.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            s.Delete((int)cbDelSize.SelectedValue, cbDelSize.SelectedText, cbDelGender.SelectedValue.ToString());
        }
    }
}
