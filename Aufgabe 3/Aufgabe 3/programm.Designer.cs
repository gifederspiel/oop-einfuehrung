namespace Aufgabe_3
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
            this.inTagen = new System.Windows.Forms.RadioButton();
            this.inStunden = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inputKmh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.berechnen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inTagen
            // 
            this.inTagen.AutoSize = true;
            this.inTagen.Location = new System.Drawing.Point(139, 203);
            this.inTagen.Name = "inTagen";
            this.inTagen.Size = new System.Drawing.Size(127, 29);
            this.inTagen.TabIndex = 0;
            this.inTagen.TabStop = true;
            this.inTagen.Text = "in Tagen";
            this.inTagen.UseVisualStyleBackColor = true;
            // 
            // inStunden
            // 
            this.inStunden.AutoSize = true;
            this.inStunden.Location = new System.Drawing.Point(451, 203);
            this.inStunden.Name = "inStunden";
            this.inStunden.Size = new System.Drawing.Size(146, 29);
            this.inStunden.TabIndex = 1;
            this.inStunden.TabStop = true;
            this.inStunden.Text = "in Stunden";
            this.inStunden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(134, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reisedauer zum Mond berechnen";
            // 
            // inputKmh
            // 
            this.inputKmh.Location = new System.Drawing.Point(362, 269);
            this.inputKmh.Name = "inputKmh";
            this.inputKmh.Size = new System.Drawing.Size(235, 31);
            this.inputKmh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geschwindigkeit km/h";
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(140, 343);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(457, 64);
            this.berechnen.TabIndex = 6;
            this.berechnen.Text = "Reisedauer berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ausgabe Reisedauer";
            // 
            // ausgabe
            // 
            this.ausgabe.Location = new System.Drawing.Point(352, 502);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.Size = new System.Drawing.Size(235, 31);
            this.ausgabe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputKmh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inStunden);
            this.Controls.Add(this.inTagen);
            this.Name = "Form1";
            this.Text = "Reisedauer zum Mond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inTagen;
        private System.Windows.Forms.RadioButton inStunden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputKmh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ausgabe;
    }
}

