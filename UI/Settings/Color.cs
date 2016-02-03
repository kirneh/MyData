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
    public partial class Color : Form
    {
        public Main main;
        Tools tool = new Tools();
        bool vali = false;

        public Color(Main main)
        {
            InitializeComponent();
            this.main = main;
            cbDelColor.Enabled = false;
        }

        Tekstil_ColorTableAdapter c = new Tekstil_ColorTableAdapter();

        private void AddColor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Color' table. You can move, or remove it, as needed.
            this.tekstil_ColorTableAdapter.Fill(this.myDatabase.Tekstil_Color);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Family' table. You can move, or remove it, as needed.
            this.tekstil_FamilyTableAdapter.Fill(this.myDatabase.Tekstil_Family);
            // TODO: This line of code loads data into the 'myDatabase.Tekstil_Color' table. You can move, or remove it, as needed.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty)
            {
                try
                {
                    c.Insert(txtName.Text, cbFamily.SelectedValue.ToString());
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

        private void cbDelFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDelColor.Enabled = true;
            cbDelColor.DataSource = tool.SqlAdapter("Color", "Tekstil.Color", "WHERE (Family = N'" + cbDelFamily.SelectedValue.ToString() + "') ORDER BY Color");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyData.Resources.MyDatabaseTableAdapters.Tekstil_ColorTableAdapter c = new Tekstil_ColorTableAdapter();
            c.Delete((int)cbDelColor.SelectedValue, cbDelColor.SelectedText, cbDelFamily.SelectedValue.ToString());
        }
    }
}
