namespace Proje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resimIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimBoyutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimSahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimEklenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resimlerDataSet = new Proje.ResimlerDataSet();
            this.resimlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resimlerTableAdapter = new Proje.ResimlerDataSetTableAdapters.ResimlerTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resimIdLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resimAdiLbl = new System.Windows.Forms.Label();
            this.resimBoyutuLbl = new System.Windows.Forms.Label();
            this.resimSahibiLbl = new System.Windows.Forms.Label();
            this.resimTuruLbl = new System.Windows.Forms.Label();
            this.resimTarihiLbl = new System.Windows.Forms.Label();
            this.resimEklenmeTarihiLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            this.DegistirBtn = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resimIDDataGridViewTextBoxColumn,
            this.resimAdiDataGridViewTextBoxColumn,
            this.resimBoyutuDataGridViewTextBoxColumn,
            this.resimSahibiDataGridViewTextBoxColumn,
            this.resimTürüDataGridViewTextBoxColumn,
            this.resimTarihiDataGridViewTextBoxColumn,
            this.resimEklenmeTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resimlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1580, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // resimIDDataGridViewTextBoxColumn
            // 
            this.resimIDDataGridViewTextBoxColumn.DataPropertyName = "Resim_ID";
            this.resimIDDataGridViewTextBoxColumn.HeaderText = "Resim_ID";
            this.resimIDDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimIDDataGridViewTextBoxColumn.Name = "resimIDDataGridViewTextBoxColumn";
            this.resimIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimIDDataGridViewTextBoxColumn.Width = 167;
            // 
            // resimAdiDataGridViewTextBoxColumn
            // 
            this.resimAdiDataGridViewTextBoxColumn.DataPropertyName = "Resim_Adi";
            this.resimAdiDataGridViewTextBoxColumn.HeaderText = "Resim_Adi";
            this.resimAdiDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimAdiDataGridViewTextBoxColumn.Name = "resimAdiDataGridViewTextBoxColumn";
            this.resimAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimAdiDataGridViewTextBoxColumn.Width = 179;
            // 
            // resimBoyutuDataGridViewTextBoxColumn
            // 
            this.resimBoyutuDataGridViewTextBoxColumn.DataPropertyName = "Resim_Boyutu";
            this.resimBoyutuDataGridViewTextBoxColumn.HeaderText = "Resim_Boyutu";
            this.resimBoyutuDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimBoyutuDataGridViewTextBoxColumn.Name = "resimBoyutuDataGridViewTextBoxColumn";
            this.resimBoyutuDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimBoyutuDataGridViewTextBoxColumn.Width = 217;
            // 
            // resimSahibiDataGridViewTextBoxColumn
            // 
            this.resimSahibiDataGridViewTextBoxColumn.DataPropertyName = "Resim_Sahibi";
            this.resimSahibiDataGridViewTextBoxColumn.HeaderText = "Resim_Sahibi";
            this.resimSahibiDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimSahibiDataGridViewTextBoxColumn.Name = "resimSahibiDataGridViewTextBoxColumn";
            this.resimSahibiDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimSahibiDataGridViewTextBoxColumn.Width = 212;
            // 
            // resimTürüDataGridViewTextBoxColumn
            // 
            this.resimTürüDataGridViewTextBoxColumn.DataPropertyName = "Resim_Türü";
            this.resimTürüDataGridViewTextBoxColumn.HeaderText = "Resim_Türü";
            this.resimTürüDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimTürüDataGridViewTextBoxColumn.Name = "resimTürüDataGridViewTextBoxColumn";
            this.resimTürüDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimTürüDataGridViewTextBoxColumn.Width = 194;
            // 
            // resimTarihiDataGridViewTextBoxColumn
            // 
            this.resimTarihiDataGridViewTextBoxColumn.DataPropertyName = "Resim_Tarihi";
            this.resimTarihiDataGridViewTextBoxColumn.HeaderText = "Resim_Tarihi";
            this.resimTarihiDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimTarihiDataGridViewTextBoxColumn.Name = "resimTarihiDataGridViewTextBoxColumn";
            this.resimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimTarihiDataGridViewTextBoxColumn.Width = 206;
            // 
            // resimEklenmeTarihiDataGridViewTextBoxColumn
            // 
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "Resim_Eklenme_Tarihi";
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.HeaderText = "Resim_Eklenme_Tarihi";
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.Name = "resimEklenmeTarihiDataGridViewTextBoxColumn";
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimEklenmeTarihiDataGridViewTextBoxColumn.Width = 314;
            // 
            // resimlerBindingSource1
            // 
            this.resimlerBindingSource1.DataMember = "Resimler";
            this.resimlerBindingSource1.DataSource = this.resimlerDataSet;
            // 
            // resimlerDataSet
            // 
            this.resimlerDataSet.DataSetName = "ResimlerDataSet";
            this.resimlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resimlerBindingSource
            // 
            this.resimlerBindingSource.DataMember = "Resimler";
            this.resimlerBindingSource.DataSource = this.resimlerDataSet;
            // 
            // resimlerTableAdapter
            // 
            this.resimlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tableLayoutPanel1.Controls.Add(this.resimIdLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.resimAdiLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.resimBoyutuLbl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.resimSahibiLbl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.resimTuruLbl, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.resimTarihiLbl, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.resimEklenmeTarihiLbl, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1574, 89);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // resimIdLbl
            // 
            this.resimIdLbl.AutoSize = true;
            this.resimIdLbl.Location = new System.Drawing.Point(5, 49);
            this.resimIdLbl.Name = "resimIdLbl";
            this.resimIdLbl.Size = new System.Drawing.Size(0, 29);
            this.resimIdLbl.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(1217, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Resim_Eklenme_Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(1015, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Resim_Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(611, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resim_Sahibi                                     ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(409, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resim_Boyutu                            ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resim_ID                                    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(157, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resim_Adi                                                 ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(823, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resim_Türü                                     ";
            // 
            // resimAdiLbl
            // 
            this.resimAdiLbl.AutoSize = true;
            this.resimAdiLbl.Location = new System.Drawing.Point(157, 49);
            this.resimAdiLbl.Name = "resimAdiLbl";
            this.resimAdiLbl.Size = new System.Drawing.Size(0, 29);
            this.resimAdiLbl.TabIndex = 7;
            // 
            // resimBoyutuLbl
            // 
            this.resimBoyutuLbl.AutoSize = true;
            this.resimBoyutuLbl.Location = new System.Drawing.Point(409, 49);
            this.resimBoyutuLbl.Name = "resimBoyutuLbl";
            this.resimBoyutuLbl.Size = new System.Drawing.Size(0, 29);
            this.resimBoyutuLbl.TabIndex = 8;
            // 
            // resimSahibiLbl
            // 
            this.resimSahibiLbl.AutoSize = true;
            this.resimSahibiLbl.Location = new System.Drawing.Point(611, 49);
            this.resimSahibiLbl.Name = "resimSahibiLbl";
            this.resimSahibiLbl.Size = new System.Drawing.Size(0, 29);
            this.resimSahibiLbl.TabIndex = 9;
            // 
            // resimTuruLbl
            // 
            this.resimTuruLbl.AutoSize = true;
            this.resimTuruLbl.Location = new System.Drawing.Point(823, 49);
            this.resimTuruLbl.Name = "resimTuruLbl";
            this.resimTuruLbl.Size = new System.Drawing.Size(0, 29);
            this.resimTuruLbl.TabIndex = 10;
            // 
            // resimTarihiLbl
            // 
            this.resimTarihiLbl.AutoSize = true;
            this.resimTarihiLbl.Location = new System.Drawing.Point(1015, 49);
            this.resimTarihiLbl.Name = "resimTarihiLbl";
            this.resimTarihiLbl.Size = new System.Drawing.Size(0, 29);
            this.resimTarihiLbl.TabIndex = 11;
            // 
            // resimEklenmeTarihiLbl
            // 
            this.resimEklenmeTarihiLbl.AutoSize = true;
            this.resimEklenmeTarihiLbl.Location = new System.Drawing.Point(1217, 49);
            this.resimEklenmeTarihiLbl.Name = "resimEklenmeTarihiLbl";
            this.resimEklenmeTarihiLbl.Size = new System.Drawing.Size(0, 29);
            this.resimEklenmeTarihiLbl.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(485, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 41);
            this.textBox1.TabIndex = 4;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(757, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sadece resim adı ve resim sahibi değiştirilebilir.";
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SilBtn.Location = new System.Drawing.Point(1417, 151);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(192, 75);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // DegistirBtn
            // 
            this.DegistirBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.DegistirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DegistirBtn.Location = new System.Drawing.Point(262, 151);
            this.DegistirBtn.Name = "DegistirBtn";
            this.DegistirBtn.Size = new System.Drawing.Size(192, 75);
            this.DegistirBtn.TabIndex = 3;
            this.DegistirBtn.Text = "Değiştir";
            this.DegistirBtn.UseVisualStyleBackColor = false;
            this.DegistirBtn.Click += new System.EventHandler(this.DegistirBtn_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.BackColor = System.Drawing.Color.Gold;
            this.yenileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yenileBtn.Location = new System.Drawing.Point(29, 151);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(192, 75);
            this.yenileBtn.TabIndex = 6;
            this.yenileBtn.Text = "Yenile";
            this.yenileBtn.UseVisualStyleBackColor = false;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1637, 838);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DegistirBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Resimler Tablosu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimlerBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ResimlerDataSet resimlerDataSet;
        private System.Windows.Forms.BindingSource resimlerBindingSource;
        private ResimlerDataSetTableAdapters.ResimlerTableAdapter resimlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimBoyutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimSahibiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimEklenmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resimIdLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resimAdiLbl;
        private System.Windows.Forms.Label resimBoyutuLbl;
        private System.Windows.Forms.Label resimSahibiLbl;
        private System.Windows.Forms.Label resimTuruLbl;
        private System.Windows.Forms.Label resimTarihiLbl;
        private System.Windows.Forms.Label resimEklenmeTarihiLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button DegistirBtn;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resimlerBindingSource1;
    }
}