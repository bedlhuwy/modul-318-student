namespace Fahrplan.cs
{
    partial class Abfahrtstafel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abfahrtstafel));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZurück = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.comboStandort = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mein Standort:";
            // 
            // btnsuchen
            // 
            this.btnsuchen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuchen.Location = new System.Drawing.Point(12, 94);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(131, 35);
            this.btnsuchen.TabIndex = 2;
            this.btnsuchen.Text = "Suchen";
            this.btnsuchen.UseVisualStyleBackColor = false;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nach,
            this.Abfahrt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 382);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            // 
            // btnZurück
            // 
            this.btnZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZurück.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnZurück.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZurück.Location = new System.Drawing.Point(12, 564);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(131, 35);
            this.btnZurück.TabIndex = 4;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = false;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Location = new System.Drawing.Point(12, 523);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(131, 35);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Löschen";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // comboStandort
            // 
            this.comboStandort.FormattingEnabled = true;
            this.comboStandort.Location = new System.Drawing.Point(12, 64);
            this.comboStandort.Name = "comboStandort";
            this.comboStandort.Size = new System.Drawing.Size(327, 24);
            this.comboStandort.TabIndex = 1;
            this.comboStandort.DropDown += new System.EventHandler(this.comboStandort_DropDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(362, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1068, 790);
            this.webBrowser1.TabIndex = 5;
            // 
            // Nach
            // 
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            this.Nach.Width = 70;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 83;
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1442, 827);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboStandort);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abfahrtstafel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox comboStandort;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    }
}