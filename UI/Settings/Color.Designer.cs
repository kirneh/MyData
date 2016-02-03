namespace MyData.UI.Settings
{
    partial class Color
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbValidation = new System.Windows.Forms.PictureBox();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbDelColor = new System.Windows.Forms.ComboBox();
            this.cbDelFamily = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tekstilFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase = new MyData.Resources.MyDatabase();
            this.tekstilColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tekstil_FamilyTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_FamilyTableAdapter();
            this.tekstil_ColorTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_ColorTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilColorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 151);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbValidation);
            this.tabPage1.Controls.Add(this.cbFamily);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(226, 125);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tilføj";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.cbDelFamily);
            this.tabPage2.Controls.Add(this.cbDelColor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(226, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbValidation
            // 
            this.pbValidation.Location = new System.Drawing.Point(101, 97);
            this.pbValidation.Name = "pbValidation";
            this.pbValidation.Size = new System.Drawing.Size(20, 20);
            this.pbValidation.TabIndex = 12;
            this.pbValidation.TabStop = false;
            // 
            // cbFamily
            // 
            this.cbFamily.DataSource = this.tekstilFamilyBindingSource;
            this.cbFamily.DisplayMember = "Family";
            this.cbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(8, 9);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(210, 21);
            this.cbFamily.TabIndex = 11;
            this.cbFamily.ValueMember = "Family";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Tilføj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Ubuntu", 11F);
            this.txtName.Location = new System.Drawing.Point(8, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 24);
            this.txtName.TabIndex = 9;
            // 
            // cbDelColor
            // 
            this.cbDelColor.DataSource = this.tekstilColorBindingSource;
            this.cbDelColor.DisplayMember = "Color";
            this.cbDelColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelColor.FormattingEnabled = true;
            this.cbDelColor.Location = new System.Drawing.Point(8, 49);
            this.cbDelColor.Name = "cbDelColor";
            this.cbDelColor.Size = new System.Drawing.Size(210, 21);
            this.cbDelColor.TabIndex = 12;
            this.cbDelColor.ValueMember = "Id";
            // 
            // cbDelFamily
            // 
            this.cbDelFamily.DataSource = this.tekstilFamilyBindingSource;
            this.cbDelFamily.DisplayMember = "Family";
            this.cbDelFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelFamily.FormattingEnabled = true;
            this.cbDelFamily.Location = new System.Drawing.Point(8, 22);
            this.cbDelFamily.Name = "cbDelFamily";
            this.cbDelFamily.Size = new System.Drawing.Size(210, 21);
            this.cbDelFamily.TabIndex = 13;
            this.cbDelFamily.ValueMember = "Family";
            this.cbDelFamily.SelectedIndexChanged += new System.EventHandler(this.cbDelFamily_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 25);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Slet";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tekstilFamilyBindingSource
            // 
            this.tekstilFamilyBindingSource.DataMember = "Tekstil_Family";
            this.tekstilFamilyBindingSource.DataSource = this.myDatabase;
            // 
            // myDatabase
            // 
            this.myDatabase.DataSetName = "MyDatabase";
            this.myDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tekstilColorBindingSource
            // 
            this.tekstilColorBindingSource.DataMember = "Tekstil_Color";
            this.tekstilColorBindingSource.DataSource = this.myDatabase;
            // 
            // tekstil_FamilyTableAdapter
            // 
            this.tekstil_FamilyTableAdapter.ClearBeforeFill = true;
            // 
            // tekstil_ColorTableAdapter
            // 
            this.tekstil_ColorTableAdapter.ClearBeforeFill = true;
            // 
            // AddColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddColor";
            this.Load += new System.EventHandler(this.AddColor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilColorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.MyDatabase myDatabase;
        private System.Windows.Forms.BindingSource tekstilFamilyBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_FamilyTableAdapter tekstil_FamilyTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbValidation;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbDelColor;
        private System.Windows.Forms.BindingSource tekstilColorBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_ColorTableAdapter tekstil_ColorTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDelFamily;
    }
}