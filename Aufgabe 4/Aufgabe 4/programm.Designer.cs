namespace Aufgabe_4
{
    partial class programm
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
            this.jahre = new System.Windows.Forms.RadioButton();
            this.monate = new System.Windows.Forms.RadioButton();
            this.wochen = new System.Windows.Forms.RadioButton();
            this.tage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selector = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.berechnen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // jahre
            // 
            this.jahre.AutoSize = true;
            this.jahre.Location = new System.Drawing.Point(28, 67);
            this.jahre.Name = "jahre";
            this.jahre.Size = new System.Drawing.Size(97, 29);
            this.jahre.TabIndex = 0;
            this.jahre.TabStop = true;
            this.jahre.Text = "Jahre";
            this.jahre.UseVisualStyleBackColor = true;
            // 
            // monate
            // 
            this.monate.AutoSize = true;
            this.monate.Location = new System.Drawing.Point(218, 67);
            this.monate.Name = "monate";
            this.monate.Size = new System.Drawing.Size(115, 29);
            this.monate.TabIndex = 1;
            this.monate.TabStop = true;
            this.monate.Text = "Monate";
            this.monate.UseVisualStyleBackColor = true;
            // 
            // wochen
            // 
            this.wochen.AutoSize = true;
            this.wochen.Location = new System.Drawing.Point(422, 67);
            this.wochen.Name = "wochen";
            this.wochen.Size = new System.Drawing.Size(122, 29);
            this.wochen.TabIndex = 2;
            this.wochen.TabStop = true;
            this.wochen.Text = "Wochen";
            this.wochen.UseVisualStyleBackColor = true;
            // 
            // tage
            // 
            this.tage.AutoSize = true;
            this.tage.Location = new System.Drawing.Point(634, 67);
            this.tage.Name = "tage";
            this.tage.Size = new System.Drawing.Size(92, 29);
            this.tage.TabIndex = 3;
            this.tage.TabStop = true;
            this.tage.Text = "Tage";
            this.tage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tage);
            this.groupBox1.Controls.Add(this.wochen);
            this.groupBox1.Controls.Add(this.monate);
            this.groupBox1.Controls.Add(this.jahre);
            this.groupBox1.Location = new System.Drawing.Point(41, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einheit";
            // 
            // selector
            // 
            this.selector.Location = new System.Drawing.Point(218, 52);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(443, 31);
            this.selector.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geburtsdatum";
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(682, 45);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(128, 48);
            this.berechnen.TabIndex = 7;
            this.berechnen.Text = "Berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.berechnen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.selector);
            this.groupBox2.Location = new System.Drawing.Point(41, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingabe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alter";
            // 
            // ausgabe
            // 
            this.ausgabe.Location = new System.Drawing.Point(218, 59);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.Size = new System.Drawing.Size(443, 31);
            this.ausgabe.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ausgabe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(41, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 131);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausgabe";
            // 
            // programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "programm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton jahre;
        private System.Windows.Forms.RadioButton monate;
        private System.Windows.Forms.RadioButton wochen;
        private System.Windows.Forms.RadioButton tage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ausgabe;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

