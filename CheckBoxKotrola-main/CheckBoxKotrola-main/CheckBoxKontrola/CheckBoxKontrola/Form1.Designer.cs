namespace _01_Check_box_kontrola
{
    partial class Form1
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
            this.Posalji = new System.Windows.Forms.Button();
            this.Dorucak = new System.Windows.Forms.CheckBox();
            this.Rucak = new System.Windows.Forms.CheckBox();
            this.Vecera = new System.Windows.Forms.CheckBox();
            this.SakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.Tekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Posalji
            // 
            this.Posalji.Location = new System.Drawing.Point(129, 384);
            this.Posalji.Name = "Posalji";
            this.Posalji.Size = new System.Drawing.Size(75, 23);
            this.Posalji.TabIndex = 0;
            this.Posalji.Text = "Posalji";
            this.Posalji.UseVisualStyleBackColor = true;
            this.Posalji.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dorucak
            // 
            this.Dorucak.AutoSize = true;
            this.Dorucak.Location = new System.Drawing.Point(129, 87);
            this.Dorucak.Name = "Dorucak";
            this.Dorucak.Size = new System.Drawing.Size(67, 17);
            this.Dorucak.TabIndex = 1;
            this.Dorucak.Text = "Dorucak";
            this.Dorucak.UseVisualStyleBackColor = true;
            this.Dorucak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Rucak
            // 
            this.Rucak.AutoSize = true;
            this.Rucak.Location = new System.Drawing.Point(129, 137);
            this.Rucak.Name = "Rucak";
            this.Rucak.Size = new System.Drawing.Size(58, 17);
            this.Rucak.TabIndex = 2;
            this.Rucak.Text = "Rucak";
            this.Rucak.UseVisualStyleBackColor = true;
            // 
            // Vecera
            // 
            this.Vecera.AutoSize = true;
            this.Vecera.Location = new System.Drawing.Point(129, 194);
            this.Vecera.Name = "Vecera";
            this.Vecera.Size = new System.Drawing.Size(60, 17);
            this.Vecera.TabIndex = 3;
            this.Vecera.Text = "Vecera";
            this.Vecera.UseVisualStyleBackColor = true;
            // 
            // SakrijNarudzbu
            // 
            this.SakrijNarudzbu.AutoSize = true;
            this.SakrijNarudzbu.Location = new System.Drawing.Point(316, 390);
            this.SakrijNarudzbu.Name = "SakrijNarudzbu";
            this.SakrijNarudzbu.Size = new System.Drawing.Size(99, 17);
            this.SakrijNarudzbu.TabIndex = 4;
            this.SakrijNarudzbu.Text = "Sakrij narudžbu";
            this.SakrijNarudzbu.UseVisualStyleBackColor = true;
            // 
            // Tekst
            // 
            this.Tekst.Location = new System.Drawing.Point(316, 87);
            this.Tekst.Multiline = true;
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(219, 164);
            this.Tekst.TabIndex = 5;
            this.Tekst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tekst);
            this.Controls.Add(this.SakrijNarudzbu);
            this.Controls.Add(this.Vecera);
            this.Controls.Add(this.Rucak);
            this.Controls.Add(this.Dorucak);
            this.Controls.Add(this.Posalji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Posalji;
        private System.Windows.Forms.CheckBox Dorucak;
        private System.Windows.Forms.CheckBox Rucak;
        private System.Windows.Forms.CheckBox Vecera;
        private System.Windows.Forms.CheckBox SakrijNarudzbu;
        private System.Windows.Forms.TextBox Tekst;
    }
}

