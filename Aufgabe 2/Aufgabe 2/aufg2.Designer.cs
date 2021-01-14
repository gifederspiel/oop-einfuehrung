namespace Aufgabe_2
{
    partial class aufg2
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
            this.ausgabeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.höhe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.breite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.berechnen = new System.Windows.Forms.Button();
            this.beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ausgabeBox
            // 
            this.ausgabeBox.AccessibleName = "";
            this.ausgabeBox.Location = new System.Drawing.Point(148, 162);
            this.ausgabeBox.Name = "ausgabeBox";
            this.ausgabeBox.ReadOnly = true;
            this.ausgabeBox.Size = new System.Drawing.Size(169, 20);
            this.ausgabeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ausgabe (Fläche)";
            // 
            // höhe
            // 
            this.höhe.AccessibleName = "";
            this.höhe.Location = new System.Drawing.Point(148, 109);
            this.höhe.Name = "höhe";
            this.höhe.Size = new System.Drawing.Size(169, 20);
            this.höhe.TabIndex = 2;
            this.höhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.höhe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // breite
            // 
            this.breite.AccessibleName = "";
            this.breite.Location = new System.Drawing.Point(148, 74);
            this.breite.Name = "breite";
            this.breite.Size = new System.Drawing.Size(169, 20);
            this.breite.TabIndex = 4;
            this.breite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.breite_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Breite des Rechtecks";
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(453, 74);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(80, 24);
            this.berechnen.TabIndex = 6;
            this.berechnen.Text = "Berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(453, 162);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(80, 24);
            this.beenden.TabIndex = 7;
            this.beenden.Text = "Beenden";
            this.beenden.UseVisualStyleBackColor = true;
            // 
            // aufg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.beenden);
            this.Controls.Add(this.berechnen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.breite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.höhe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ausgabeBox);
            this.Name = "aufg2";
            this.Text = "Fläche eines Rechtecks berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ausgabeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox höhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Button beenden;
    }
}

