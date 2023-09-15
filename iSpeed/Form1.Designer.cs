namespace iSpeed
{
    partial class Form1
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
            this.rbBrief = new System.Windows.Forms.RadioButton();
            this.rbPaket = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuEntfernung = new System.Windows.Forms.DomainUpDown();
            this.menuGewicht = new System.Windows.Forms.DomainUpDown();
            this.txtPorto = new System.Windows.Forms.TextBox();
            this.cboxSendungsart = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entfernung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBrief
            // 
            this.rbBrief.AutoSize = true;
            this.rbBrief.Location = new System.Drawing.Point(110, 63);
            this.rbBrief.Name = "rbBrief";
            this.rbBrief.Size = new System.Drawing.Size(46, 17);
            this.rbBrief.TabIndex = 0;
            this.rbBrief.TabStop = true;
            this.rbBrief.Text = "Brief";
            this.rbBrief.UseVisualStyleBackColor = true;
            // 
            // rbPaket
            // 
            this.rbPaket.AutoSize = true;
            this.rbPaket.Location = new System.Drawing.Point(201, 63);
            this.rbPaket.Name = "rbPaket";
            this.rbPaket.Size = new System.Drawing.Size(53, 17);
            this.rbPaket.TabIndex = 1;
            this.rbPaket.TabStop = true;
            this.rbPaket.Text = "Paket";
            this.rbPaket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sendungsart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entfernung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gewicht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Porto";
            // 
            // menuEntfernung
            // 
            this.menuEntfernung.Location = new System.Drawing.Point(110, 134);
            this.menuEntfernung.Name = "menuEntfernung";
            this.menuEntfernung.Size = new System.Drawing.Size(120, 20);
            this.menuEntfernung.TabIndex = 6;
            // 
            // menuGewicht
            // 
            this.menuGewicht.Location = new System.Drawing.Point(110, 174);
            this.menuGewicht.Name = "menuGewicht";
            this.menuGewicht.Size = new System.Drawing.Size(120, 20);
            this.menuGewicht.TabIndex = 7;
            // 
            // txtPorto
            // 
            this.txtPorto.Location = new System.Drawing.Point(110, 281);
            this.txtPorto.Name = "txtPorto";
            this.txtPorto.Size = new System.Drawing.Size(120, 20);
            this.txtPorto.TabIndex = 8;
            // 
            // cboxSendungsart
            // 
            this.cboxSendungsart.FormattingEnabled = true;
            this.cboxSendungsart.Location = new System.Drawing.Point(109, 97);
            this.cboxSendungsart.Name = "cboxSendungsart";
            this.cboxSendungsart.Size = new System.Drawing.Size(148, 21);
            this.cboxSendungsart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "€";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(354, 141);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(126, 58);
            this.btnBerechnen.TabIndex = 13;
            this.btnBerechnen.Text = "Porto berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(354, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 58);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Format,
            this.Entfernung,
            this.Gewicht,
            this.Porto});
            this.dataGridView1.Location = new System.Drawing.Point(9, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 170);
            this.dataGridView1.TabIndex = 15;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            // 
            // Entfernung
            // 
            this.Entfernung.HeaderText = "Entfernung";
            this.Entfernung.Name = "Entfernung";
            // 
            // Gewicht
            // 
            this.Gewicht.HeaderText = "Gewicht";
            this.Gewicht.Name = "Gewicht";
            // 
            // Porto
            // 
            this.Porto.HeaderText = "Porto";
            this.Porto.Name = "Porto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxSendungsart);
            this.Controls.Add(this.txtPorto);
            this.Controls.Add(this.menuGewicht);
            this.Controls.Add(this.menuEntfernung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPaket);
            this.Controls.Add(this.rbBrief);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBrief;
        private System.Windows.Forms.RadioButton rbPaket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown menuEntfernung;
        private System.Windows.Forms.DomainUpDown menuGewicht;
        private System.Windows.Forms.TextBox txtPorto;
        private System.Windows.Forms.ComboBox cboxSendungsart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entfernung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porto;
    }
}

