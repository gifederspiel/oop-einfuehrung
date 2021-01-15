namespace Aufgabe_6
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
            this.puffervalue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.createPuffer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eingabe = new System.Windows.Forms.TextBox();
            this.putbutton = new System.Windows.Forms.Button();
            this.getbutton = new System.Windows.Forms.Button();
            this.getallbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puffervalue)).BeginInit();
            this.SuspendLayout();
            // 
            // puffervalue
            // 
            this.puffervalue.Location = new System.Drawing.Point(196, 113);
            this.puffervalue.Name = "puffervalue";
            this.puffervalue.Size = new System.Drawing.Size(118, 31);
            this.puffervalue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puffergrösse";
            // 
            // createPuffer
            // 
            this.createPuffer.Location = new System.Drawing.Point(393, 106);
            this.createPuffer.Name = "createPuffer";
            this.createPuffer.Size = new System.Drawing.Size(227, 42);
            this.createPuffer.TabIndex = 3;
            this.createPuffer.Text = "Puffer erstellen";
            this.createPuffer.UseVisualStyleBackColor = true;
            this.createPuffer.Click += new System.EventHandler(this.createPuffer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eingabe";
            // 
            // eingabe
            // 
            this.eingabe.Location = new System.Drawing.Point(140, 204);
            this.eingabe.Name = "eingabe";
            this.eingabe.Size = new System.Drawing.Size(174, 31);
            this.eingabe.TabIndex = 5;
            // 
            // putbutton
            // 
            this.putbutton.Location = new System.Drawing.Point(393, 198);
            this.putbutton.Name = "putbutton";
            this.putbutton.Size = new System.Drawing.Size(227, 42);
            this.putbutton.TabIndex = 6;
            this.putbutton.Text = "Put";
            this.putbutton.UseVisualStyleBackColor = true;
            this.putbutton.Click += new System.EventHandler(this.putbutton_Click);
            // 
            // getbutton
            // 
            this.getbutton.Location = new System.Drawing.Point(48, 296);
            this.getbutton.Name = "getbutton";
            this.getbutton.Size = new System.Drawing.Size(173, 42);
            this.getbutton.TabIndex = 8;
            this.getbutton.Text = "Get";
            this.getbutton.UseVisualStyleBackColor = true;
            this.getbutton.Click += new System.EventHandler(this.getbutton_Click);
            // 
            // getallbutton
            // 
            this.getallbutton.Location = new System.Drawing.Point(48, 374);
            this.getallbutton.Name = "getallbutton";
            this.getallbutton.Size = new System.Drawing.Size(173, 42);
            this.getallbutton.TabIndex = 9;
            this.getallbutton.Text = "GetAll";
            this.getallbutton.UseVisualStyleBackColor = true;
            this.getallbutton.Click += new System.EventHandler(this.getallbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ausgabe";
            // 
            // ausgabe
            // 
            this.ausgabe.Location = new System.Drawing.Point(393, 344);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.ReadOnly = true;
            this.ausgabe.Size = new System.Drawing.Size(227, 31);
            this.ausgabe.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(40, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "FiFo Puffer testen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getallbutton);
            this.Controls.Add(this.getbutton);
            this.Controls.Add(this.putbutton);
            this.Controls.Add(this.eingabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createPuffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puffervalue);
            this.Name = "Form1";
            this.Text = "FiFo Puffer";
            ((System.ComponentModel.ISupportInitialize)(this.puffervalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown puffervalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPuffer;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox eingabe;
        private System.Windows.Forms.Button putbutton;
        private System.Windows.Forms.Button getbutton;
        private System.Windows.Forms.Button getallbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ausgabe;
        private System.Windows.Forms.Label label4;
    }
}

