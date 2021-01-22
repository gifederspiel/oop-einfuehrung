namespace Aufgabe_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carKey1 = new System.Windows.Forms.CheckBox();
            this.Gas = new System.Windows.Forms.Button();
            this.Bremse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.carKey = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Gang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kmh = new System.Windows.Forms.Label();
            this.hupe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(268, 97);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(449, 33);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto wählen";
            // 
            // outputPS
            // 
            this.outputPS.AutoSize = true;
            this.outputPS.Location = new System.Drawing.Point(789, 100);
            this.outputPS.Name = "outputPS";
            this.outputPS.Size = new System.Drawing.Size(0, 25);
            this.outputPS.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carKey1);
            this.groupBox1.Controls.Add(this.Gas);
            this.groupBox1.Controls.Add(this.Bremse);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.hupe);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(108, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 784);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // carKey1
            // 
            this.carKey1.AutoSize = true;
            this.carKey1.Location = new System.Drawing.Point(6, 59);
            this.carKey1.Name = "carKey1";
            this.carKey1.Size = new System.Drawing.Size(28, 27);
            this.carKey1.TabIndex = 4;
            this.carKey1.UseVisualStyleBackColor = true;
            this.carKey1.Click += new System.EventHandler(this.carKey1_Click_1);
            // 
            // Gas
            // 
            this.Gas.Location = new System.Drawing.Point(800, 355);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(148, 359);
            this.Gas.TabIndex = 9;
            this.Gas.Text = "Gas";
            this.Gas.UseVisualStyleBackColor = true;
            this.Gas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gas_MouseDown);
            this.Gas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Gas_MouseUp);
            // 
            // Bremse
            // 
            this.Bremse.Location = new System.Drawing.Point(487, 355);
            this.Bremse.Name = "Bremse";
            this.Bremse.Size = new System.Drawing.Size(279, 359);
            this.Bremse.TabIndex = 8;
            this.Bremse.Text = "Bremse";
            this.Bremse.UseVisualStyleBackColor = true;
            this.Bremse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bremse_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.carKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Gang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.kmh);
            this.groupBox2.Location = new System.Drawing.Point(267, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // carKey
            // 
            this.carKey.AutoSize = true;
            this.carKey.Location = new System.Drawing.Point(-55, 10);
            this.carKey.Name = "carKey";
            this.carKey.Size = new System.Drawing.Size(28, 27);
            this.carKey.TabIndex = 10;
            this.carKey.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gear";
            // 
            // Gang
            // 
            this.Gang.AutoSize = true;
            this.Gang.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Gang.Location = new System.Drawing.Point(414, 117);
            this.Gang.Name = "Gang";
            this.Gang.Size = new System.Drawing.Size(0, 76);
            this.Gang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "km/h";
            // 
            // kmh
            // 
            this.kmh.AutoSize = true;
            this.kmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.kmh.Location = new System.Drawing.Point(175, 117);
            this.kmh.Name = "kmh";
            this.kmh.Size = new System.Drawing.Size(0, 76);
            this.kmh.TabIndex = 3;
            // 
            // hupe
            // 
            this.hupe.Location = new System.Drawing.Point(40, 253);
            this.hupe.Name = "hupe";
            this.hupe.Size = new System.Drawing.Size(198, 44);
            this.hupe.TabIndex = 2;
            this.hupe.Text = "Hupe";
            this.hupe.UseVisualStyleBackColor = true;
            this.hupe.Click += new System.EventHandler(this.hupe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 115);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 1113);
            this.Controls.Add(this.outputPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hupe;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Gas;
        private System.Windows.Forms.Button Bremse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Gang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kmh;
        private System.Windows.Forms.CheckBox carKey1;
        private System.Windows.Forms.CheckBox carKey;
    }
}

