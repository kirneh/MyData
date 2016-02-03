namespace MyData.UI.Settings
{
    partial class Size
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Size));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbValidation = new System.Windows.Forms.PictureBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tekstilGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase = new MyData.Resources.MyDatabase();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDelGender = new System.Windows.Forms.ComboBox();
            this.cbDelSize = new System.Windows.Forms.ComboBox();
            this.tekstilSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tekstil_GenderTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_GenderTableAdapter();
            this.tekstil_SizeTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_SizeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilSizeBindingSource)).BeginInit();
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
            this.tabPage1.Controls.Add(this.cbGender);
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
            // pbValidation
            // 
            this.pbValidation.Location = new System.Drawing.Point(101, 97);
            this.pbValidation.Name = "pbValidation";
            this.pbValidation.Size = new System.Drawing.Size(20, 20);
            this.pbValidation.TabIndex = 12;
            this.pbValidation.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.tekstilGenderBindingSource;
            this.cbGender.DisplayMember = "Gender";
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(8, 9);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(210, 21);
            this.cbGender.TabIndex = 11;
            this.cbGender.ValueMember = "Gender";
            // 
            // tekstilGenderBindingSource
            // 
            this.tekstilGenderBindingSource.DataMember = "Tekstil_Gender";
            this.tekstilGenderBindingSource.DataSource = this.myDatabase;
            // 
            // myDatabase
            // 
            this.myDatabase.DataSetName = "MyDatabase";
            this.myDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.cbDelGender);
            this.tabPage2.Controls.Add(this.cbDelSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(226, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slet";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // cbDelGender
            // 
            this.cbDelGender.DataSource = this.tekstilGenderBindingSource;
            this.cbDelGender.DisplayMember = "Gender";
            this.cbDelGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelGender.FormattingEnabled = true;
            this.cbDelGender.Location = new System.Drawing.Point(8, 22);
            this.cbDelGender.Name = "cbDelGender";
            this.cbDelGender.Size = new System.Drawing.Size(210, 21);
            this.cbDelGender.TabIndex = 13;
            this.cbDelGender.ValueMember = "Gender";
            this.cbDelGender.SelectedIndexChanged += new System.EventHandler(this.cbDelGender_SelectedIndexChanged);
            // 
            // cbDelSize
            // 
            this.cbDelSize.DataSource = this.tekstilSizeBindingSource;
            this.cbDelSize.DisplayMember = "Size";
            this.cbDelSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelSize.FormattingEnabled = true;
            this.cbDelSize.Location = new System.Drawing.Point(8, 49);
            this.cbDelSize.Name = "cbDelSize";
            this.cbDelSize.Size = new System.Drawing.Size(210, 21);
            this.cbDelSize.TabIndex = 12;
            this.cbDelSize.ValueMember = "Id";
            // 
            // tekstilSizeBindingSource
            // 
            this.tekstilSizeBindingSource.DataMember = "Tekstil_Size";
            this.tekstilSizeBindingSource.DataSource = this.myDatabase;
            // 
            // tekstil_GenderTableAdapter
            // 
            this.tekstil_GenderTableAdapter.ClearBeforeFill = true;
            // 
            // tekstil_SizeTableAdapter
            // 
            this.tekstil_SizeTableAdapter.ClearBeforeFill = true;
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Size";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tekstil - Størrelser";
            this.Load += new System.EventHandler(this.AddColor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tekstilSizeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.MyDatabase myDatabase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbValidation;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbDelSize;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDelGender;
        private System.Windows.Forms.BindingSource tekstilGenderBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_GenderTableAdapter tekstil_GenderTableAdapter;
        private System.Windows.Forms.BindingSource tekstilSizeBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_SizeTableAdapter tekstil_SizeTableAdapter;
    }
}