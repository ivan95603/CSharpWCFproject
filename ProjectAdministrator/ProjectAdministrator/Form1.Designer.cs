namespace ProjectAdministrator
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
            this.commandOutputBox = new System.Windows.Forms.RichTextBox();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.listBoxDeloviZaPopravku = new System.Windows.Forms.ListBox();
            this.listBoxPopravke = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAutomobili = new System.Windows.Forms.ListBox();
            this.listBoxKorisnici = new System.Windows.Forms.ListBox();
            this.buttonSacuvajDeo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBoxDelovi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // commandOutputBox
            // 
            this.commandOutputBox.Location = new System.Drawing.Point(27, 313);
            this.commandOutputBox.Name = "commandOutputBox";
            this.commandOutputBox.Size = new System.Drawing.Size(453, 102);
            this.commandOutputBox.TabIndex = 28;
            this.commandOutputBox.Text = "";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(27, 277);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(453, 20);
            this.commandBox.TabIndex = 27;
            this.commandBox.TextChanged += new System.EventHandler(this.commandBox_TextChanged);
            this.commandBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandBox_KeyPress);
            // 
            // listBoxDeloviZaPopravku
            // 
            this.listBoxDeloviZaPopravku.FormattingEnabled = true;
            this.listBoxDeloviZaPopravku.Location = new System.Drawing.Point(380, 79);
            this.listBoxDeloviZaPopravku.Name = "listBoxDeloviZaPopravku";
            this.listBoxDeloviZaPopravku.Size = new System.Drawing.Size(100, 173);
            this.listBoxDeloviZaPopravku.TabIndex = 26;
            // 
            // listBoxPopravke
            // 
            this.listBoxPopravke.FormattingEnabled = true;
            this.listBoxPopravke.Location = new System.Drawing.Point(274, 79);
            this.listBoxPopravke.Name = "listBoxPopravke";
            this.listBoxPopravke.Size = new System.Drawing.Size(100, 173);
            this.listBoxPopravke.TabIndex = 25;
            this.listBoxPopravke.SelectedIndexChanged += new System.EventHandler(this.listBoxPopravke_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Delovi za popravku:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Popravke:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Automobili:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Korisnik:";
            // 
            // listBoxAutomobili
            // 
            this.listBoxAutomobili.FormattingEnabled = true;
            this.listBoxAutomobili.Location = new System.Drawing.Point(152, 79);
            this.listBoxAutomobili.Name = "listBoxAutomobili";
            this.listBoxAutomobili.Size = new System.Drawing.Size(116, 173);
            this.listBoxAutomobili.TabIndex = 19;
            this.listBoxAutomobili.SelectedIndexChanged += new System.EventHandler(this.listBoxAutomobili_SelectedIndexChanged);
            // 
            // listBoxKorisnici
            // 
            this.listBoxKorisnici.FormattingEnabled = true;
            this.listBoxKorisnici.Location = new System.Drawing.Point(27, 79);
            this.listBoxKorisnici.Name = "listBoxKorisnici";
            this.listBoxKorisnici.Size = new System.Drawing.Size(119, 173);
            this.listBoxKorisnici.TabIndex = 20;
            this.listBoxKorisnici.SelectedIndexChanged += new System.EventHandler(this.listBoxKorisnici_SelectedIndexChanged);
            // 
            // buttonSacuvajDeo
            // 
            this.buttonSacuvajDeo.Location = new System.Drawing.Point(625, 424);
            this.buttonSacuvajDeo.Name = "buttonSacuvajDeo";
            this.buttonSacuvajDeo.Size = new System.Drawing.Size(75, 23);
            this.buttonSacuvajDeo.TabIndex = 36;
            this.buttonSacuvajDeo.Text = "Sacuvaj";
            this.buttonSacuvajDeo.UseVisualStyleBackColor = true;
            this.buttonSacuvajDeo.Click += new System.EventHandler(this.buttonSacuvajDeo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(625, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Naziv dela:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ID Dela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cena dela:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(625, 333);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 30;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(625, 359);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // listBoxDelovi
            // 
            this.listBoxDelovi.FormattingEnabled = true;
            this.listBoxDelovi.Location = new System.Drawing.Point(553, 63);
            this.listBoxDelovi.Name = "listBoxDelovi";
            this.listBoxDelovi.Size = new System.Drawing.Size(192, 225);
            this.listBoxDelovi.TabIndex = 29;
            this.listBoxDelovi.SelectedIndexChanged += new System.EventHandler(this.listBoxDelovi_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 496);
            this.Controls.Add(this.buttonSacuvajDeo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBoxDelovi);
            this.Controls.Add(this.commandOutputBox);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.listBoxDeloviZaPopravku);
            this.Controls.Add(this.listBoxPopravke);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxAutomobili);
            this.Controls.Add(this.listBoxKorisnici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox commandOutputBox;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.ListBox listBoxDeloviZaPopravku;
        private System.Windows.Forms.ListBox listBoxPopravke;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxAutomobili;
        private System.Windows.Forms.ListBox listBoxKorisnici;
        private System.Windows.Forms.Button buttonSacuvajDeo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBoxDelovi;
    }
}

