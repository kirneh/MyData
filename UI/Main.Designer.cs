namespace MyData
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tcCreator = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.cbProducent = new System.Windows.Forms.ComboBox();
            this.cboxSpecialProduct = new System.Windows.Forms.ComboBox();
            this.cbSpecialProduct = new System.Windows.Forms.CheckBox();
            this.txtOwnSize = new System.Windows.Forms.TextBox();
            this.cbChooseSize = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.imgDescription = new System.Windows.Forms.PictureBox();
            this.lblDesciption = new System.Windows.Forms.Label();
            this.rbtDescription = new System.Windows.Forms.RichTextBox();
            this.txtOwnColor = new System.Windows.Forms.TextBox();
            this.btnTekstilWatch = new System.Windows.Forms.Button();
            this.lblColorCount = new System.Windows.Forms.Label();
            this.lblWarning2 = new System.Windows.Forms.Label();
            this.lblWarning1 = new System.Windows.Forms.Label();
            this.lblTextileSize = new System.Windows.Forms.Label();
            this.lblTextileColor = new System.Windows.Forms.Label();
            this.cbTextileGender = new System.Windows.Forms.ComboBox();
            this.tekstilGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabase = new MyData.Resources.MyDatabase();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbTextileFamilly = new System.Windows.Forms.ComboBox();
            this.tekstilFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFamily = new System.Windows.Forms.Label();
            this.btnTextileAdd = new System.Windows.Forms.Button();
            this.lbTextileColor = new System.Windows.Forms.ListBox();
            this.tekstilColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTextileSize = new System.Windows.Forms.ListBox();
            this.tekstilSizeAdultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextileSKU = new System.Windows.Forms.TextBox();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtTextileName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbChooseColor = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSettingsTekstilSize = new System.Windows.Forms.Button();
            this.btnSettingsTekstilColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tekstil_ColorTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_ColorTableAdapter();
            this.tekstil_Size_AdultTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_Size_AdultTableAdapter();
            this.tekstil_FamilyTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_FamilyTableAdapter();
            this.tekstil_GenderTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_GenderTableAdapter();
            this.tekstilContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tekstil_ContentTableAdapter = new MyData.Resources.MyDatabaseTableAdapters.Tekstil_ContentTableAdapter();
            this.lblWarning3 = new System.Windows.Forms.Label();
            this.tcCreator.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilSizeAdultBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilContentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCreator
            // 
            this.tcCreator.Controls.Add(this.tabPage3);
            this.tcCreator.Controls.Add(this.tabPage4);
            this.tcCreator.Controls.Add(this.tpAbout);
            this.tcCreator.Controls.Add(this.tpSettings);
            this.tcCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCreator.Font = new System.Drawing.Font("Ubuntu", 8F);
            this.tcCreator.Location = new System.Drawing.Point(0, 0);
            this.tcCreator.Name = "tcCreator";
            this.tcCreator.SelectedIndex = 0;
            this.tcCreator.Size = new System.Drawing.Size(509, 452);
            this.tcCreator.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcCreator.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblWarning3);
            this.tabPage3.Controls.Add(this.cbCurrency);
            this.tabPage3.Controls.Add(this.cbProducent);
            this.tabPage3.Controls.Add(this.cboxSpecialProduct);
            this.tabPage3.Controls.Add(this.cbSpecialProduct);
            this.tabPage3.Controls.Add(this.txtOwnSize);
            this.tabPage3.Controls.Add(this.cbChooseSize);
            this.tabPage3.Controls.Add(this.txtPrice);
            this.tabPage3.Controls.Add(this.lblPrice);
            this.tabPage3.Controls.Add(this.imgDescription);
            this.tabPage3.Controls.Add(this.lblDesciption);
            this.tabPage3.Controls.Add(this.rbtDescription);
            this.tabPage3.Controls.Add(this.txtOwnColor);
            this.tabPage3.Controls.Add(this.btnTekstilWatch);
            this.tabPage3.Controls.Add(this.lblColorCount);
            this.tabPage3.Controls.Add(this.lblWarning2);
            this.tabPage3.Controls.Add(this.lblWarning1);
            this.tabPage3.Controls.Add(this.lblTextileSize);
            this.tabPage3.Controls.Add(this.lblTextileColor);
            this.tabPage3.Controls.Add(this.cbTextileGender);
            this.tabPage3.Controls.Add(this.lblGender);
            this.tabPage3.Controls.Add(this.cbTextileFamilly);
            this.tabPage3.Controls.Add(this.lblFamily);
            this.tabPage3.Controls.Add(this.btnTextileAdd);
            this.tabPage3.Controls.Add(this.lbTextileColor);
            this.tabPage3.Controls.Add(this.lbTextileSize);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtTextileSKU);
            this.tabPage3.Controls.Add(this.lblSKU);
            this.tabPage3.Controls.Add(this.txtTextileName);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.cbChooseColor);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(501, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tekstil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbCurrency
            // 
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "DKK",
            "EUR",
            "GBP"});
            this.cbCurrency.Location = new System.Drawing.Point(134, 230);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(61, 24);
            this.cbCurrency.TabIndex = 6;
            // 
            // cbProducent
            // 
            this.cbProducent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducent.FormattingEnabled = true;
            this.cbProducent.Items.AddRange(new object[] {
            "",
            "James & Nicholson",
            "B&C",
            "Myrtle Beach",
            "Sols"});
            this.cbProducent.Location = new System.Drawing.Point(74, 37);
            this.cbProducent.Name = "cbProducent";
            this.cbProducent.Size = new System.Drawing.Size(121, 24);
            this.cbProducent.TabIndex = 33;
            this.cbProducent.SelectedIndexChanged += new System.EventHandler(this.cbProducent_SelectedIndexChanged);
            // 
            // cboxSpecialProduct
            // 
            this.cboxSpecialProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSpecialProduct.Enabled = false;
            this.cboxSpecialProduct.FormattingEnabled = true;
            this.cboxSpecialProduct.Items.AddRange(new object[] {
            "Gruppe",
            "Konfigurerbart"});
            this.cboxSpecialProduct.Location = new System.Drawing.Point(15, 286);
            this.cboxSpecialProduct.Name = "cboxSpecialProduct";
            this.cboxSpecialProduct.Size = new System.Drawing.Size(181, 24);
            this.cboxSpecialProduct.TabIndex = 32;
            // 
            // cbSpecialProduct
            // 
            this.cbSpecialProduct.AutoSize = true;
            this.cbSpecialProduct.Location = new System.Drawing.Point(15, 260);
            this.cbSpecialProduct.Name = "cbSpecialProduct";
            this.cbSpecialProduct.Size = new System.Drawing.Size(213, 20);
            this.cbSpecialProduct.TabIndex = 6;
            this.cbSpecialProduct.Text = "Opret gruppe/konfigurebart produkt?";
            this.cbSpecialProduct.UseVisualStyleBackColor = true;
            this.cbSpecialProduct.CheckedChanged += new System.EventHandler(this.cbSpecialProduct_CheckedChanged);
            // 
            // txtOwnSize
            // 
            this.txtOwnSize.Location = new System.Drawing.Point(373, 23);
            this.txtOwnSize.Multiline = true;
            this.txtOwnSize.Name = "txtOwnSize";
            this.txtOwnSize.Size = new System.Drawing.Size(120, 212);
            this.txtOwnSize.TabIndex = 8;
            this.txtOwnSize.Visible = false;
            // 
            // cbChooseSize
            // 
            this.cbChooseSize.AutoSize = true;
            this.cbChooseSize.Location = new System.Drawing.Point(375, 236);
            this.cbChooseSize.Name = "cbChooseSize";
            this.cbChooseSize.Size = new System.Drawing.Size(125, 20);
            this.cbChooseSize.TabIndex = 10;
            this.cbChooseSize.Text = "Skriv egen størrelse";
            this.cbChooseSize.UseVisualStyleBackColor = true;
            this.cbChooseSize.CheckedChanged += new System.EventHandler(this.cbChooseSize_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(14, 232);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 20);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 213);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 16);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Pris:";
            // 
            // imgDescription
            // 
            this.imgDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDescription.Image = global::MyData.Properties.Resources.triangle_down;
            this.imgDescription.InitialImage = global::MyData.Properties.Resources.triangle_down;
            this.imgDescription.Location = new System.Drawing.Point(310, 260);
            this.imgDescription.Name = "imgDescription";
            this.imgDescription.Size = new System.Drawing.Size(12, 16);
            this.imgDescription.TabIndex = 27;
            this.imgDescription.TabStop = false;
            this.imgDescription.Click += new System.EventHandler(this.imgDescription_Click);
            // 
            // lblDesciption
            // 
            this.lblDesciption.AutoSize = true;
            this.lblDesciption.Location = new System.Drawing.Point(244, 259);
            this.lblDesciption.Name = "lblDesciption";
            this.lblDesciption.Size = new System.Drawing.Size(67, 16);
            this.lblDesciption.TabIndex = 26;
            this.lblDesciption.Text = "Beskrivelse:";
            // 
            // rbtDescription
            // 
            this.rbtDescription.Location = new System.Drawing.Point(247, 278);
            this.rbtDescription.Name = "rbtDescription";
            this.rbtDescription.Size = new System.Drawing.Size(246, 96);
            this.rbtDescription.TabIndex = 11;
            this.rbtDescription.Text = "";
            // 
            // txtOwnColor
            // 
            this.txtOwnColor.Location = new System.Drawing.Point(247, 23);
            this.txtOwnColor.Multiline = true;
            this.txtOwnColor.Name = "txtOwnColor";
            this.txtOwnColor.Size = new System.Drawing.Size(120, 212);
            this.txtOwnColor.TabIndex = 7;
            this.txtOwnColor.Visible = false;
            this.txtOwnColor.TextChanged += new System.EventHandler(this.txtOwnColor_TextChanged);
            // 
            // btnTekstilWatch
            // 
            this.btnTekstilWatch.Location = new System.Drawing.Point(452, 380);
            this.btnTekstilWatch.Name = "btnTekstilWatch";
            this.btnTekstilWatch.Size = new System.Drawing.Size(44, 39);
            this.btnTekstilWatch.TabIndex = 13;
            this.btnTekstilWatch.Text = "Se";
            this.btnTekstilWatch.UseVisualStyleBackColor = true;
            this.btnTekstilWatch.Click += new System.EventHandler(this.btnTekstilWatch_Click);
            // 
            // lblColorCount
            // 
            this.lblColorCount.AutoSize = true;
            this.lblColorCount.Location = new System.Drawing.Point(350, 7);
            this.lblColorCount.Name = "lblColorCount";
            this.lblColorCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColorCount.Size = new System.Drawing.Size(14, 16);
            this.lblColorCount.TabIndex = 23;
            this.lblColorCount.Text = "0";
            // 
            // lblWarning2
            // 
            this.lblWarning2.AutoSize = true;
            this.lblWarning2.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning2.ForeColor = System.Drawing.Color.Red;
            this.lblWarning2.Location = new System.Drawing.Point(197, 97);
            this.lblWarning2.Name = "lblWarning2";
            this.lblWarning2.Size = new System.Drawing.Size(17, 27);
            this.lblWarning2.TabIndex = 22;
            this.lblWarning2.Text = "!";
            this.lblWarning2.Visible = false;
            // 
            // lblWarning1
            // 
            this.lblWarning1.AutoSize = true;
            this.lblWarning1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning1.ForeColor = System.Drawing.Color.Red;
            this.lblWarning1.Location = new System.Drawing.Point(197, 56);
            this.lblWarning1.Name = "lblWarning1";
            this.lblWarning1.Size = new System.Drawing.Size(17, 27);
            this.lblWarning1.TabIndex = 21;
            this.lblWarning1.Text = "!";
            this.lblWarning1.Visible = false;
            // 
            // lblTextileSize
            // 
            this.lblTextileSize.AutoSize = true;
            this.lblTextileSize.Location = new System.Drawing.Point(373, 7);
            this.lblTextileSize.Name = "lblTextileSize";
            this.lblTextileSize.Size = new System.Drawing.Size(56, 16);
            this.lblTextileSize.TabIndex = 20;
            this.lblTextileSize.Text = "Størrelse:";
            // 
            // lblTextileColor
            // 
            this.lblTextileColor.AutoSize = true;
            this.lblTextileColor.Location = new System.Drawing.Point(244, 7);
            this.lblTextileColor.Name = "lblTextileColor";
            this.lblTextileColor.Size = new System.Drawing.Size(37, 16);
            this.lblTextileColor.TabIndex = 19;
            this.lblTextileColor.Text = "Farve:";
            // 
            // cbTextileGender
            // 
            this.cbTextileGender.DataSource = this.tekstilGenderBindingSource;
            this.cbTextileGender.DisplayMember = "Gender";
            this.cbTextileGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextileGender.FormattingEnabled = true;
            this.cbTextileGender.Location = new System.Drawing.Point(14, 186);
            this.cbTextileGender.Name = "cbTextileGender";
            this.cbTextileGender.Size = new System.Drawing.Size(181, 24);
            this.cbTextileGender.TabIndex = 4;
            this.cbTextileGender.ValueMember = "Gender";
            this.cbTextileGender.SelectedIndexChanged += new System.EventHandler(this.cbTextileGender_SelectedIndexChanged);
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
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(16, 167);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(30, 16);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Køn:";
            // 
            // cbTextileFamilly
            // 
            this.cbTextileFamilly.DataSource = this.tekstilFamilyBindingSource;
            this.cbTextileFamilly.DisplayMember = "Family";
            this.cbTextileFamilly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextileFamilly.FormattingEnabled = true;
            this.cbTextileFamilly.Location = new System.Drawing.Point(14, 142);
            this.cbTextileFamilly.Name = "cbTextileFamilly";
            this.cbTextileFamilly.Size = new System.Drawing.Size(181, 24);
            this.cbTextileFamilly.TabIndex = 3;
            this.cbTextileFamilly.ValueMember = "Family";
            this.cbTextileFamilly.SelectedIndexChanged += new System.EventHandler(this.cbTextileFamilly_SelectedIndexChanged);
            // 
            // tekstilFamilyBindingSource
            // 
            this.tekstilFamilyBindingSource.DataMember = "Tekstil_Family";
            this.tekstilFamilyBindingSource.DataSource = this.myDatabase;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(16, 122);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(33, 16);
            this.lblFamily.TabIndex = 15;
            this.lblFamily.Text = "Type:";
            // 
            // btnTextileAdd
            // 
            this.btnTextileAdd.Location = new System.Drawing.Point(6, 380);
            this.btnTextileAdd.Name = "btnTextileAdd";
            this.btnTextileAdd.Size = new System.Drawing.Size(445, 39);
            this.btnTextileAdd.TabIndex = 12;
            this.btnTextileAdd.Text = "Indsæt";
            this.btnTextileAdd.UseVisualStyleBackColor = true;
            this.btnTextileAdd.Click += new System.EventHandler(this.btnTextileAdd_Click);
            // 
            // lbTextileColor
            // 
            this.lbTextileColor.DataSource = this.tekstilColorBindingSource;
            this.lbTextileColor.DisplayMember = "Color";
            this.lbTextileColor.FormattingEnabled = true;
            this.lbTextileColor.ItemHeight = 16;
            this.lbTextileColor.Location = new System.Drawing.Point(247, 23);
            this.lbTextileColor.Name = "lbTextileColor";
            this.lbTextileColor.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTextileColor.Size = new System.Drawing.Size(120, 212);
            this.lbTextileColor.TabIndex = 13;
            this.lbTextileColor.ValueMember = "Color";
            this.lbTextileColor.SelectedIndexChanged += new System.EventHandler(this.lbTextileColor_SelectedIndexChanged);
            // 
            // tekstilColorBindingSource
            // 
            this.tekstilColorBindingSource.DataMember = "Tekstil_Color";
            this.tekstilColorBindingSource.DataSource = this.myDatabase;
            // 
            // lbTextileSize
            // 
            this.lbTextileSize.DataSource = this.tekstilSizeAdultBindingSource;
            this.lbTextileSize.DisplayMember = "Size";
            this.lbTextileSize.FormattingEnabled = true;
            this.lbTextileSize.ItemHeight = 16;
            this.lbTextileSize.Location = new System.Drawing.Point(373, 23);
            this.lbTextileSize.Name = "lbTextileSize";
            this.lbTextileSize.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTextileSize.Size = new System.Drawing.Size(120, 212);
            this.lbTextileSize.TabIndex = 12;
            this.lbTextileSize.ValueMember = "Size";
            // 
            // tekstilSizeAdultBindingSource
            // 
            this.tekstilSizeAdultBindingSource.DataMember = "Tekstil_Size_Adult";
            this.tekstilSizeAdultBindingSource.DataSource = this.myDatabase;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tekstil";
            // 
            // txtTextileSKU
            // 
            this.txtTextileSKU.Location = new System.Drawing.Point(14, 101);
            this.txtTextileSKU.Name = "txtTextileSKU";
            this.txtTextileSKU.Size = new System.Drawing.Size(181, 20);
            this.txtTextileSKU.TabIndex = 2;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Location = new System.Drawing.Point(15, 82);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(32, 16);
            this.lblSKU.TabIndex = 9;
            this.lblSKU.Text = "SKU:";
            // 
            // txtTextileName
            // 
            this.txtTextileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTextileName.Location = new System.Drawing.Point(14, 61);
            this.txtTextileName.MaxLength = 100;
            this.txtTextileName.Name = "txtTextileName";
            this.txtTextileName.Size = new System.Drawing.Size(181, 20);
            this.txtTextileName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Navn:";
            // 
            // cbChooseColor
            // 
            this.cbChooseColor.AutoSize = true;
            this.cbChooseColor.Location = new System.Drawing.Point(249, 236);
            this.cbChooseColor.Name = "cbChooseColor";
            this.cbChooseColor.Size = new System.Drawing.Size(106, 20);
            this.cbChooseColor.TabIndex = 9;
            this.cbChooseColor.Text = "Skriv egen farve";
            this.cbChooseColor.UseVisualStyleBackColor = true;
            this.cbChooseColor.CheckedChanged += new System.EventHandler(this.cbChooseColor_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.listBox3);
            this.tabPage4.Controls.Add(this.listBox4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(501, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Folie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(495, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(247, 7);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 228);
            this.listBox3.TabIndex = 20;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(373, 7);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 228);
            this.listBox4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 20F);
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Folie";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.labelVersion);
            this.tpAbout.Controls.Add(this.pictureBox1);
            this.tpAbout.Location = new System.Drawing.Point(4, 25);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(501, 423);
            this.tpAbout.TabIndex = 5;
            this.tpAbout.Text = "Om";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(244, 261);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(38, 16);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyData.Properties.Resources.kirneh;
            this.pictureBox1.Location = new System.Drawing.Point(244, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tabControl1);
            this.tpSettings.Location = new System.Drawing.Point(4, 25);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(501, 423);
            this.tpSettings.TabIndex = 6;
            this.tpSettings.Text = "Indstillinger";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSettingsTekstilSize);
            this.tabPage2.Controls.Add(this.btnSettingsTekstilColor);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(487, 388);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Tekstil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSettingsTekstilSize
            // 
            this.btnSettingsTekstilSize.Location = new System.Drawing.Point(88, 30);
            this.btnSettingsTekstilSize.Name = "btnSettingsTekstilSize";
            this.btnSettingsTekstilSize.Size = new System.Drawing.Size(75, 25);
            this.btnSettingsTekstilSize.TabIndex = 3;
            this.btnSettingsTekstilSize.Text = "Størrelser";
            this.btnSettingsTekstilSize.UseVisualStyleBackColor = true;
            this.btnSettingsTekstilSize.Click += new System.EventHandler(this.btnSettingsTekstilSize_Click);
            // 
            // btnSettingsTekstilColor
            // 
            this.btnSettingsTekstilColor.Location = new System.Drawing.Point(7, 30);
            this.btnSettingsTekstilColor.Name = "btnSettingsTekstilColor";
            this.btnSettingsTekstilColor.Size = new System.Drawing.Size(75, 25);
            this.btnSettingsTekstilColor.TabIndex = 2;
            this.btnSettingsTekstilColor.Text = "Farve";
            this.btnSettingsTekstilColor.UseVisualStyleBackColor = true;
            this.btnSettingsTekstilColor.Click += new System.EventHandler(this.btnSettingsTekstilColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indstillinger:";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage5.Size = new System.Drawing.Size(487, 388);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Folie";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tekstil_ColorTableAdapter
            // 
            this.tekstil_ColorTableAdapter.ClearBeforeFill = true;
            // 
            // tekstil_Size_AdultTableAdapter
            // 
            this.tekstil_Size_AdultTableAdapter.ClearBeforeFill = true;
            // 
            // tekstil_FamilyTableAdapter
            // 
            this.tekstil_FamilyTableAdapter.ClearBeforeFill = true;
            // 
            // tekstil_GenderTableAdapter
            // 
            this.tekstil_GenderTableAdapter.ClearBeforeFill = true;
            // 
            // tekstilContentBindingSource
            // 
            this.tekstilContentBindingSource.DataMember = "Tekstil_Content";
            this.tekstilContentBindingSource.DataSource = this.myDatabase;
            // 
            // tekstil_ContentTableAdapter
            // 
            this.tekstil_ContentTableAdapter.ClearBeforeFill = true;
            // 
            // lblWarning3
            // 
            this.lblWarning3.AutoSize = true;
            this.lblWarning3.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning3.ForeColor = System.Drawing.Color.Red;
            this.lblWarning3.Location = new System.Drawing.Point(197, 228);
            this.lblWarning3.Name = "lblWarning3";
            this.lblWarning3.Size = new System.Drawing.Size(17, 27);
            this.lblWarning3.TabIndex = 34;
            this.lblWarning3.Text = "!";
            this.lblWarning3.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 452);
            this.Controls.Add(this.tcCreator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Creator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcCreator.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilSizeAdultBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tekstilContentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCreator;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbTextileColor;
        private System.Windows.Forms.ListBox lbTextileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextileSKU;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtTextileName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTextileAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTextileSize;
        private System.Windows.Forms.Label lblTextileColor;
        private System.Windows.Forms.ComboBox cbTextileGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbTextileFamilly;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblWarning2;
        private System.Windows.Forms.Label lblWarning1;
        private Resources.MyDatabase myDatabase;
        private System.Windows.Forms.BindingSource tekstilColorBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_ColorTableAdapter tekstil_ColorTableAdapter;
        private System.Windows.Forms.BindingSource tekstilSizeAdultBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_Size_AdultTableAdapter tekstil_Size_AdultTableAdapter;
        private System.Windows.Forms.BindingSource tekstilFamilyBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_FamilyTableAdapter tekstil_FamilyTableAdapter;
        private System.Windows.Forms.BindingSource tekstilGenderBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_GenderTableAdapter tekstil_GenderTableAdapter;
        private System.Windows.Forms.BindingSource tekstilContentBindingSource;
        private Resources.MyDatabaseTableAdapters.Tekstil_ContentTableAdapter tekstil_ContentTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColorCount;
        private System.Windows.Forms.Button btnTekstilWatch;
        private System.Windows.Forms.Button btnSettingsTekstilColor;
        private System.Windows.Forms.TextBox txtOwnColor;
        private System.Windows.Forms.CheckBox cbChooseColor;
        private System.Windows.Forms.Label lblDesciption;
        private System.Windows.Forms.RichTextBox rbtDescription;
        private System.Windows.Forms.PictureBox imgDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox cbChooseSize;
        private System.Windows.Forms.TextBox txtOwnSize;
        private System.Windows.Forms.ComboBox cboxSpecialProduct;
        private System.Windows.Forms.CheckBox cbSpecialProduct;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnSettingsTekstilSize;
        private System.Windows.Forms.ComboBox cbProducent;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lblWarning3;
    }
}

