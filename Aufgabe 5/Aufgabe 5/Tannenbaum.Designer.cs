namespace Aufgabe_5
{
    partial class Tannenbaum
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen geloescht werden sollen; andernfalls False.</param>
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
            this.inputbreite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputstammhoehe = new System.Windows.Forms.TextBox();
            this.zeichnen = new System.Windows.Forms.Button();
            this.ausgabe = new System.Windows.Forms.TextBox();
            this.inputkronenhoehe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputbreite
            // 
            this.inputbreite.Location = new System.Drawing.Point(209, 41);
            this.inputbreite.Name = "inputbreite";
            this.inputbreite.Size = new System.Drawing.Size(114, 31);
            this.inputbreite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stammhoehe";
            // 
            // inputstammhoehe
            // 
            this.inputstammhoehe.Location = new System.Drawing.Point(209, 100);
            this.inputstammhoehe.Name = "inputstammhoehe";
            this.inputstammhoehe.Size = new System.Drawing.Size(114, 31);
            this.inputstammhoehe.TabIndex = 3;
            // 
            // zeichnen
            // 
            this.zeichnen.Location = new System.Drawing.Point(374, 41);
            this.zeichnen.Name = "zeichnen";
            this.zeichnen.Size = new System.Drawing.Size(132, 150);
            this.zeichnen.TabIndex = 6;
            this.zeichnen.Text = "Zeichnen";
            this.zeichnen.UseVisualStyleBackColor = true;
            this.zeichnen.Click += new System.EventHandler(this.zeichnen_Click);
            // 
            // ausgabe
            // 
            this.ausgabe.Location = new System.Drawing.Point(43, 233);
            this.ausgabe.Multiline = true;
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.Size = new System.Drawing.Size(463, 582);
            this.ausgabe.TabIndex = 7;
            // 
            // inputkronenhoehe
            // 
            this.inputkronenhoehe.Location = new System.Drawing.Point(209, 160);
            this.inputkronenhoehe.Name = "inputkronenhoehe";
            this.inputkronenhoehe.Size = new System.Drawing.Size(114, 31);
            this.inputkronenhoehe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kronenhoehe";
            // 
            // Tannenbaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 884);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputkronenhoehe);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.zeichnen);
            this.Controls.Add(this.inputstammhoehe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputbreite);
            this.Name = "Tannenbaum";
            this.Text = "Tannenbaum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputbreite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputstammhoehe;
        private System.Windows.Forms.Button zeichnen;
        private System.Windows.Forms.TextBox ausgabe;
        private System.Windows.Forms.TextBox inputkronenhoehe;
        private System.Windows.Forms.Label label3;
    }
}

