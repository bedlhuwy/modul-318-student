namespace Fahrplan.cs
{
    partial class Fahrplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrplan));
            this.comboVon = new System.Windows.Forms.ComboBox();
            this.comboNach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btntausch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWeiterleiten = new System.Windows.Forms.Button();
            this.btnschliessen = new System.Windows.Forms.Button();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.dtZeit = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboVon
            // 
            this.comboVon.FormattingEnabled = true;
            this.comboVon.Location = new System.Drawing.Point(41, 74);
            this.comboVon.Name = "comboVon";
            this.comboVon.Size = new System.Drawing.Size(172, 24);
            this.comboVon.TabIndex = 1;
            this.comboVon.DropDown += new System.EventHandler(this.comboVon_DropDown);
            // 
            // comboNach
            // 
            this.comboNach.FormattingEnabled = true;
            this.comboNach.Location = new System.Drawing.Point(331, 74);
            this.comboNach.Name = "comboNach";
            this.comboNach.Size = new System.Drawing.Size(172, 24);
            this.comboNach.TabIndex = 2;
            this.comboNach.DropDown += new System.EventHandler(this.comboNach_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuchen.Location = new System.Drawing.Point(509, 64);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(156, 41);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Abfahrzeit,
            this.Ankunftzeit,
            this.Gleis});
            this.dataGridView1.Location = new System.Drawing.Point(41, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 201);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Width = 78;
            // 
            // Abfahrzeit
            // 
            this.Abfahrzeit.HeaderText = "Abfahrzeit";
            this.Abfahrzeit.Name = "Abfahrzeit";
            this.Abfahrzeit.Width = 101;
            // 
            // Ankunftzeit
            // 
            this.Ankunftzeit.HeaderText = "Ankunftzeit";
            this.Ankunftzeit.Name = "Ankunftzeit";
            this.Ankunftzeit.Width = 107;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            this.Gleis.Width = 69;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 32);
            this.toolStripMenuItem1.Text = "Abfahrttafel";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btntausch
            // 
            this.btntausch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btntausch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntausch.Location = new System.Drawing.Point(219, 65);
            this.btntausch.Name = "btntausch";
            this.btntausch.Size = new System.Drawing.Size(106, 40);
            this.btntausch.TabIndex = 8;
            this.btntausch.Text = "Tauschen";
            this.btntausch.UseVisualStyleBackColor = false;
            this.btntausch.Click += new System.EventHandler(this.btntausch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(509, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Löschen";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWeiterleiten
            // 
            this.btnWeiterleiten.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnWeiterleiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWeiterleiten.Location = new System.Drawing.Point(509, 111);
            this.btnWeiterleiten.Name = "btnWeiterleiten";
            this.btnWeiterleiten.Size = new System.Drawing.Size(156, 39);
            this.btnWeiterleiten.TabIndex = 6;
            this.btnWeiterleiten.Text = "Weiterleiten";
            this.btnWeiterleiten.UseVisualStyleBackColor = false;
            this.btnWeiterleiten.Click += new System.EventHandler(this.btnWeiterleiten_Click);
            // 
            // btnschliessen
            // 
            this.btnschliessen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnschliessen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnschliessen.Location = new System.Drawing.Point(509, 201);
            this.btnschliessen.Name = "btnschliessen";
            this.btnschliessen.Size = new System.Drawing.Size(156, 39);
            this.btnschliessen.TabIndex = 4;
            this.btnschliessen.Text = "Schliessen";
            this.btnschliessen.UseVisualStyleBackColor = false;
            this.btnschliessen.Click += new System.EventHandler(this.btnschliessen_Click);
            // 
            // dtDatum
            // 
            this.dtDatum.CustomFormat = "dd.MM.yyyy";
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDatum.Location = new System.Drawing.Point(41, 318);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(245, 22);
            this.dtDatum.TabIndex = 9;
            // 
            // dtZeit
            // 
            this.dtZeit.CustomFormat = "HH:mm";
            this.dtZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtZeit.Location = new System.Drawing.Point(292, 318);
            this.dtZeit.Name = "dtZeit";
            this.dtZeit.ShowUpDown = true;
            this.dtZeit.Size = new System.Drawing.Size(122, 22);
            this.dtZeit.TabIndex = 10;
            this.dtZeit.UseWaitCursor = true;
            this.dtZeit.Value = new System.DateTime(2018, 4, 23, 0, 0, 0, 0);
            this.dtZeit.ValueChanged += new System.EventHandler(this.dtZeit_ValueChanged);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(708, 379);
            this.Controls.Add(this.dtZeit);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.btnschliessen);
            this.Controls.Add(this.btnWeiterleiten);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btntausch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNach);
            this.Controls.Add(this.comboVon);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fahrplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Fahrplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboVon;
        private System.Windows.Forms.ComboBox comboNach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btntausch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWeiterleiten;
        private System.Windows.Forms.Button btnschliessen;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.DateTimePicker dtZeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
    }
}

