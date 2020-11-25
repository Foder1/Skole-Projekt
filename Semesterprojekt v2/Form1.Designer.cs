namespace Semesterprojekt
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ejendomsmæglerDataSet = new Semesterprojekt.EjendomsmæglerDataSet();
            this.køberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.køberTableAdapter = new Semesterprojekt.EjendomsmæglerDataSetTableAdapters.KøberTableAdapter();
            this.kundeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerDataSet1 = new Semesterprojekt.EjendomsmæglerDataSet1();
            this.solgtBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solgtBoligTableAdapter = new Semesterprojekt.EjendomsmæglerDataSet1TableAdapters.solgtBoligTableAdapter();
            this.boligIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStørrelseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerDataSet2 = new Semesterprojekt.EjendomsmæglerDataSet2();
            this.sælgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sælgerTableAdapter = new Semesterprojekt.EjendomsmæglerDataSet2TableAdapters.SælgerTableAdapter();
            this.kundeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejendomsmæglerDataSet3 = new Semesterprojekt.EjendomsmæglerDataSet3();
            this.tilSalgBoligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tilSalgBoligTableAdapter = new Semesterprojekt.EjendomsmæglerDataSet3TableAdapters.tilSalgBoligTableAdapter();
            this.boligIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAdresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bStørrelseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPrisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.køberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgtBoligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilSalgBoligBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boligIDDataGridViewTextBoxColumn3,
            this.bAdresseDataGridViewTextBoxColumn1,
            this.bStørrelseDataGridViewTextBoxColumn1,
            this.bPrisDataGridViewTextBoxColumn1,
            this.kundeIDDataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.tilSalgBoligBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(727, 374);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(696, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundeIDDataGridViewTextBoxColumn2,
            this.sNavnDataGridViewTextBoxColumn1,
            this.sTelefonDataGridViewTextBoxColumn1,
            this.sEmailDataGridViewTextBoxColumn1,
            this.boligIDDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.sælgerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 374);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(696, 170);
            this.dataGridView2.TabIndex = 30;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boligIDDataGridViewTextBoxColumn1,
            this.bAdresseDataGridViewTextBoxColumn,
            this.bStørrelseDataGridViewTextBoxColumn,
            this.bPrisDataGridViewTextBoxColumn,
            this.kundeIDDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.solgtBoligBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(727, 187);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(696, 170);
            this.dataGridView3.TabIndex = 31;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundeIDDataGridViewTextBoxColumn,
            this.sNavnDataGridViewTextBoxColumn,
            this.sTelefonDataGridViewTextBoxColumn,
            this.sEmailDataGridViewTextBoxColumn,
            this.boligIDDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.køberBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(23, 187);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(696, 170);
            this.dataGridView4.TabIndex = 32;
            // 
            // ejendomsmæglerDataSet
            // 
            this.ejendomsmæglerDataSet.DataSetName = "EjendomsmæglerDataSet";
            this.ejendomsmæglerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // køberBindingSource
            // 
            this.køberBindingSource.DataMember = "Køber";
            this.køberBindingSource.DataSource = this.ejendomsmæglerDataSet;
            // 
            // køberTableAdapter
            // 
            this.køberTableAdapter.ClearBeforeFill = true;
            // 
            // kundeIDDataGridViewTextBoxColumn
            // 
            this.kundeIDDataGridViewTextBoxColumn.DataPropertyName = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn.HeaderText = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kundeIDDataGridViewTextBoxColumn.Name = "kundeIDDataGridViewTextBoxColumn";
            this.kundeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNavnDataGridViewTextBoxColumn
            // 
            this.sNavnDataGridViewTextBoxColumn.DataPropertyName = "sNavn";
            this.sNavnDataGridViewTextBoxColumn.HeaderText = "sNavn";
            this.sNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNavnDataGridViewTextBoxColumn.Name = "sNavnDataGridViewTextBoxColumn";
            this.sNavnDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTelefonDataGridViewTextBoxColumn
            // 
            this.sTelefonDataGridViewTextBoxColumn.DataPropertyName = "sTelefon";
            this.sTelefonDataGridViewTextBoxColumn.HeaderText = "sTelefon";
            this.sTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTelefonDataGridViewTextBoxColumn.Name = "sTelefonDataGridViewTextBoxColumn";
            this.sTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEmailDataGridViewTextBoxColumn
            // 
            this.sEmailDataGridViewTextBoxColumn.DataPropertyName = "sEmail";
            this.sEmailDataGridViewTextBoxColumn.HeaderText = "sEmail";
            this.sEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEmailDataGridViewTextBoxColumn.Name = "sEmailDataGridViewTextBoxColumn";
            this.sEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "boligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "boligID";
            this.boligIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            this.boligIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ejendomsmæglerDataSet1
            // 
            this.ejendomsmæglerDataSet1.DataSetName = "EjendomsmæglerDataSet1";
            this.ejendomsmæglerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solgtBoligBindingSource
            // 
            this.solgtBoligBindingSource.DataMember = "solgtBolig";
            this.solgtBoligBindingSource.DataSource = this.ejendomsmæglerDataSet1;
            // 
            // solgtBoligTableAdapter
            // 
            this.solgtBoligTableAdapter.ClearBeforeFill = true;
            // 
            // boligIDDataGridViewTextBoxColumn1
            // 
            this.boligIDDataGridViewTextBoxColumn1.DataPropertyName = "boligID";
            this.boligIDDataGridViewTextBoxColumn1.HeaderText = "boligID";
            this.boligIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.boligIDDataGridViewTextBoxColumn1.Name = "boligIDDataGridViewTextBoxColumn1";
            this.boligIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bAdresseDataGridViewTextBoxColumn
            // 
            this.bAdresseDataGridViewTextBoxColumn.DataPropertyName = "bAdresse";
            this.bAdresseDataGridViewTextBoxColumn.HeaderText = "bAdresse";
            this.bAdresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bAdresseDataGridViewTextBoxColumn.Name = "bAdresseDataGridViewTextBoxColumn";
            this.bAdresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // bStørrelseDataGridViewTextBoxColumn
            // 
            this.bStørrelseDataGridViewTextBoxColumn.DataPropertyName = "bStørrelse";
            this.bStørrelseDataGridViewTextBoxColumn.HeaderText = "bStørrelse";
            this.bStørrelseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bStørrelseDataGridViewTextBoxColumn.Name = "bStørrelseDataGridViewTextBoxColumn";
            this.bStørrelseDataGridViewTextBoxColumn.Width = 125;
            // 
            // bPrisDataGridViewTextBoxColumn
            // 
            this.bPrisDataGridViewTextBoxColumn.DataPropertyName = "bPris";
            this.bPrisDataGridViewTextBoxColumn.HeaderText = "bPris";
            this.bPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bPrisDataGridViewTextBoxColumn.Name = "bPrisDataGridViewTextBoxColumn";
            this.bPrisDataGridViewTextBoxColumn.Width = 125;
            // 
            // kundeIDDataGridViewTextBoxColumn1
            // 
            this.kundeIDDataGridViewTextBoxColumn1.DataPropertyName = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn1.HeaderText = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kundeIDDataGridViewTextBoxColumn1.Name = "kundeIDDataGridViewTextBoxColumn1";
            this.kundeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ejendomsmæglerDataSet2
            // 
            this.ejendomsmæglerDataSet2.DataSetName = "EjendomsmæglerDataSet2";
            this.ejendomsmæglerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sælgerBindingSource
            // 
            this.sælgerBindingSource.DataMember = "Sælger";
            this.sælgerBindingSource.DataSource = this.ejendomsmæglerDataSet2;
            // 
            // sælgerTableAdapter
            // 
            this.sælgerTableAdapter.ClearBeforeFill = true;
            // 
            // kundeIDDataGridViewTextBoxColumn2
            // 
            this.kundeIDDataGridViewTextBoxColumn2.DataPropertyName = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn2.HeaderText = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.kundeIDDataGridViewTextBoxColumn2.Name = "kundeIDDataGridViewTextBoxColumn2";
            this.kundeIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // sNavnDataGridViewTextBoxColumn1
            // 
            this.sNavnDataGridViewTextBoxColumn1.DataPropertyName = "sNavn";
            this.sNavnDataGridViewTextBoxColumn1.HeaderText = "sNavn";
            this.sNavnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sNavnDataGridViewTextBoxColumn1.Name = "sNavnDataGridViewTextBoxColumn1";
            this.sNavnDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sTelefonDataGridViewTextBoxColumn1
            // 
            this.sTelefonDataGridViewTextBoxColumn1.DataPropertyName = "sTelefon";
            this.sTelefonDataGridViewTextBoxColumn1.HeaderText = "sTelefon";
            this.sTelefonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sTelefonDataGridViewTextBoxColumn1.Name = "sTelefonDataGridViewTextBoxColumn1";
            this.sTelefonDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sEmailDataGridViewTextBoxColumn1
            // 
            this.sEmailDataGridViewTextBoxColumn1.DataPropertyName = "sEmail";
            this.sEmailDataGridViewTextBoxColumn1.HeaderText = "sEmail";
            this.sEmailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sEmailDataGridViewTextBoxColumn1.Name = "sEmailDataGridViewTextBoxColumn1";
            this.sEmailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // boligIDDataGridViewTextBoxColumn2
            // 
            this.boligIDDataGridViewTextBoxColumn2.DataPropertyName = "boligID";
            this.boligIDDataGridViewTextBoxColumn2.HeaderText = "boligID";
            this.boligIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.boligIDDataGridViewTextBoxColumn2.Name = "boligIDDataGridViewTextBoxColumn2";
            this.boligIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ejendomsmæglerDataSet3
            // 
            this.ejendomsmæglerDataSet3.DataSetName = "EjendomsmæglerDataSet3";
            this.ejendomsmæglerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tilSalgBoligBindingSource
            // 
            this.tilSalgBoligBindingSource.DataMember = "tilSalgBolig";
            this.tilSalgBoligBindingSource.DataSource = this.ejendomsmæglerDataSet3;
            // 
            // tilSalgBoligTableAdapter
            // 
            this.tilSalgBoligTableAdapter.ClearBeforeFill = true;
            // 
            // boligIDDataGridViewTextBoxColumn3
            // 
            this.boligIDDataGridViewTextBoxColumn3.DataPropertyName = "boligID";
            this.boligIDDataGridViewTextBoxColumn3.HeaderText = "boligID";
            this.boligIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.boligIDDataGridViewTextBoxColumn3.Name = "boligIDDataGridViewTextBoxColumn3";
            this.boligIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // bAdresseDataGridViewTextBoxColumn1
            // 
            this.bAdresseDataGridViewTextBoxColumn1.DataPropertyName = "bAdresse";
            this.bAdresseDataGridViewTextBoxColumn1.HeaderText = "bAdresse";
            this.bAdresseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bAdresseDataGridViewTextBoxColumn1.Name = "bAdresseDataGridViewTextBoxColumn1";
            this.bAdresseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bStørrelseDataGridViewTextBoxColumn1
            // 
            this.bStørrelseDataGridViewTextBoxColumn1.DataPropertyName = "bStørrelse";
            this.bStørrelseDataGridViewTextBoxColumn1.HeaderText = "bStørrelse";
            this.bStørrelseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bStørrelseDataGridViewTextBoxColumn1.Name = "bStørrelseDataGridViewTextBoxColumn1";
            this.bStørrelseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bPrisDataGridViewTextBoxColumn1
            // 
            this.bPrisDataGridViewTextBoxColumn1.DataPropertyName = "bPris";
            this.bPrisDataGridViewTextBoxColumn1.HeaderText = "bPris";
            this.bPrisDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bPrisDataGridViewTextBoxColumn1.Name = "bPrisDataGridViewTextBoxColumn1";
            this.bPrisDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kundeIDDataGridViewTextBoxColumn3
            // 
            this.kundeIDDataGridViewTextBoxColumn3.DataPropertyName = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn3.HeaderText = "kundeID";
            this.kundeIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.kundeIDDataGridViewTextBoxColumn3.Name = "kundeIDDataGridViewTextBoxColumn3";
            this.kundeIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Køber";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Sælger";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(311, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Solgte huse";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(217, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "Til salg";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 587);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.køberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solgtBoligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sælgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilSalgBoligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private EjendomsmæglerDataSet ejendomsmæglerDataSet;
        private System.Windows.Forms.BindingSource køberBindingSource;
        private EjendomsmæglerDataSetTableAdapters.KøberTableAdapter køberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private EjendomsmæglerDataSet1 ejendomsmæglerDataSet1;
        private System.Windows.Forms.BindingSource solgtBoligBindingSource;
        private EjendomsmæglerDataSet1TableAdapters.solgtBoligTableAdapter solgtBoligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAdresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStørrelseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeIDDataGridViewTextBoxColumn1;
        private EjendomsmæglerDataSet2 ejendomsmæglerDataSet2;
        private System.Windows.Forms.BindingSource sælgerBindingSource;
        private EjendomsmæglerDataSet2TableAdapters.SælgerTableAdapter sælgerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn2;
        private EjendomsmæglerDataSet3 ejendomsmæglerDataSet3;
        private System.Windows.Forms.BindingSource tilSalgBoligBindingSource;
        private EjendomsmæglerDataSet3TableAdapters.tilSalgBoligTableAdapter tilSalgBoligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAdresseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bStørrelseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPrisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

