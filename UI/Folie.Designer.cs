namespace MyData
{
    partial class Folie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.myData = new MyData.Resources.MyDatabase();
            this.folieColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folieSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Farve = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Størrelse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gruppe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folieColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folieSizeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Navn,
            this.SKU,
            this.Pris,
            this.Farve,
            this.Størrelse,
            this.Gruppe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // myData
            // 
            this.myData.DataSetName = "MyData";
            this.myData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // folieColorBindingSource
            // 
            this.folieColorBindingSource.DataMember = "Folie.Color";
            this.folieColorBindingSource.DataSource = this.myData;
            // 
            // folieSizeBindingSource
            // 
            this.folieSizeBindingSource.DataMember = "Folie.Size";
            this.folieSizeBindingSource.DataSource = this.myData;
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            // 
            // Farve
            // 
            this.Farve.DataPropertyName = "Color";
            this.Farve.DataSource = this.folieColorBindingSource;
            this.Farve.HeaderText = "Farve";
            this.Farve.Name = "Farve";
            // 
            // Størrelse
            // 
            this.Størrelse.DataPropertyName = "Size";
            this.Størrelse.DataSource = this.folieSizeBindingSource;
            this.Størrelse.HeaderText = "Størrelse";
            this.Størrelse.Name = "Størrelse";
            // 
            // Gruppe
            // 
            this.Gruppe.HeaderText = "Gruppe Produkt";
            this.Gruppe.Name = "Gruppe";
            // 
            // Folie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Folie";
            this.Text = "Folie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folieColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folieSizeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewComboBoxColumn Farve;
        private System.Windows.Forms.BindingSource folieColorBindingSource;
        private Resources.MyDatabase myData;
        private System.Windows.Forms.DataGridViewComboBoxColumn Størrelse;
        private System.Windows.Forms.BindingSource folieSizeBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gruppe;
    }
}