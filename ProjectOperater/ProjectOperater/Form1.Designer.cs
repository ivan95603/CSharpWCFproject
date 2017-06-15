namespace ProjectOperater
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Delovi = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Korisnici = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Izmena = new System.Windows.Forms.TabPage();
            this.listBoxPopravke = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAutomobili = new System.Windows.Forms.ListBox();
            this.listBoxKorisnici = new System.Windows.Forms.ListBox();
            this.Dodavanje = new System.Windows.Forms.TabPage();
            this.listBoxDeloviZaPopravku = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.commandOutputBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Delovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Korisnici.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Izmena.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(392, 4);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(81, 6);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 20);
            this.textUserName.TabIndex = 3;
            this.textUserName.Text = "ivan";
            // 
            // maskedPassword
            // 
            this.maskedPassword.Location = new System.Drawing.Point(286, 7);
            this.maskedPassword.Mask = "****";
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.Size = new System.Drawing.Size(100, 20);
            this.maskedPassword.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 355);
            this.listBox1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Delovi);
            this.tabControl1.Controls.Add(this.Korisnici);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 593);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Delovi
            // 
            this.Delovi.Controls.Add(this.button1);
            this.Delovi.Controls.Add(this.textBox1);
            this.Delovi.Controls.Add(this.label5);
            this.Delovi.Controls.Add(this.label4);
            this.Delovi.Controls.Add(this.label3);
            this.Delovi.Controls.Add(this.numericUpDown2);
            this.Delovi.Controls.Add(this.numericUpDown1);
            this.Delovi.Controls.Add(this.listBox2);
            this.Delovi.Location = new System.Drawing.Point(4, 22);
            this.Delovi.Name = "Delovi";
            this.Delovi.Padding = new System.Windows.Forms.Padding(3);
            this.Delovi.Size = new System.Drawing.Size(684, 448);
            this.Delovi.TabIndex = 1;
            this.Delovi.Text = "Delovi";
            this.Delovi.UseVisualStyleBackColor = true;
            this.Delovi.Click += new System.EventHandler(this.Delovi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sacuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(358, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Naziv dela:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Dela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena dela:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(358, 85);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(358, 111);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 225);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Korisnici
            // 
            this.Korisnici.Controls.Add(this.tabControl2);
            this.Korisnici.Location = new System.Drawing.Point(4, 22);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(836, 567);
            this.Korisnici.TabIndex = 4;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Izmena);
            this.tabControl2.Controls.Add(this.Dodavanje);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(832, 560);
            this.tabControl2.TabIndex = 0;
            // 
            // Izmena
            // 
            this.Izmena.Controls.Add(this.commandOutputBox);
            this.Izmena.Controls.Add(this.buttonExecute);
            this.Izmena.Controls.Add(this.commandBox);
            this.Izmena.Controls.Add(this.listBoxDeloviZaPopravku);
            this.Izmena.Controls.Add(this.listBoxPopravke);
            this.Izmena.Controls.Add(this.button3);
            this.Izmena.Controls.Add(this.button2);
            this.Izmena.Controls.Add(this.textBox2);
            this.Izmena.Controls.Add(this.label11);
            this.Izmena.Controls.Add(this.label10);
            this.Izmena.Controls.Add(this.label8);
            this.Izmena.Controls.Add(this.label7);
            this.Izmena.Controls.Add(this.label9);
            this.Izmena.Controls.Add(this.label6);
            this.Izmena.Controls.Add(this.listBoxAutomobili);
            this.Izmena.Controls.Add(this.listBoxKorisnici);
            this.Izmena.Location = new System.Drawing.Point(4, 22);
            this.Izmena.Name = "Izmena";
            this.Izmena.Padding = new System.Windows.Forms.Padding(3);
            this.Izmena.Size = new System.Drawing.Size(824, 534);
            this.Izmena.TabIndex = 0;
            this.Izmena.Text = "Izmena";
            this.Izmena.UseVisualStyleBackColor = true;
            // 
            // listBoxPopravke
            // 
            this.listBoxPopravke.FormattingEnabled = true;
            this.listBoxPopravke.Location = new System.Drawing.Point(253, 71);
            this.listBoxPopravke.Name = "listBoxPopravke";
            this.listBoxPopravke.Size = new System.Drawing.Size(100, 173);
            this.listBoxPopravke.TabIndex = 14;
            this.listBoxPopravke.SelectedIndexChanged += new System.EventHandler(this.listBoxPopravke_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Promeni Naziv Korisnika";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sacuvaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(253, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Korisnici:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Naziv korisnika:";
            // 
            // listBoxAutomobili
            // 
            this.listBoxAutomobili.FormattingEnabled = true;
            this.listBoxAutomobili.Location = new System.Drawing.Point(131, 71);
            this.listBoxAutomobili.Name = "listBoxAutomobili";
            this.listBoxAutomobili.Size = new System.Drawing.Size(116, 173);
            this.listBoxAutomobili.TabIndex = 6;
            this.listBoxAutomobili.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBoxKorisnici
            // 
            this.listBoxKorisnici.FormattingEnabled = true;
            this.listBoxKorisnici.Location = new System.Drawing.Point(6, 71);
            this.listBoxKorisnici.Name = "listBoxKorisnici";
            this.listBoxKorisnici.Size = new System.Drawing.Size(119, 173);
            this.listBoxKorisnici.TabIndex = 6;
            this.listBoxKorisnici.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Dodavanje
            // 
            this.Dodavanje.Location = new System.Drawing.Point(4, 22);
            this.Dodavanje.Name = "Dodavanje";
            this.Dodavanje.Padding = new System.Windows.Forms.Padding(3);
            this.Dodavanje.Size = new System.Drawing.Size(574, 423);
            this.Dodavanje.TabIndex = 1;
            this.Dodavanje.Text = "Dodavanje";
            this.Dodavanje.UseVisualStyleBackColor = true;
            // 
            // listBoxDeloviZaPopravku
            // 
            this.listBoxDeloviZaPopravku.FormattingEnabled = true;
            this.listBoxDeloviZaPopravku.Location = new System.Drawing.Point(359, 71);
            this.listBoxDeloviZaPopravku.Name = "listBoxDeloviZaPopravku";
            this.listBoxDeloviZaPopravku.Size = new System.Drawing.Size(100, 173);
            this.listBoxDeloviZaPopravku.TabIndex = 15;
            this.listBoxDeloviZaPopravku.SelectedIndexChanged += new System.EventHandler(this.listBoxDeloviZaPopravku_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Korisnik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Automobili:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Popravke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Delovi za popravku:";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(6, 269);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(453, 20);
            this.commandBox.TabIndex = 16;
            this.commandBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandBox_KeyPress);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(484, 266);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 17;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // commandOutputBox
            // 
            this.commandOutputBox.Location = new System.Drawing.Point(6, 305);
            this.commandOutputBox.Name = "commandOutputBox";
            this.commandOutputBox.Size = new System.Drawing.Size(453, 102);
            this.commandOutputBox.TabIndex = 18;
            this.commandOutputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.maskedPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Delovi.ResumeLayout(false);
            this.Delovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Korisnici.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Izmena.ResumeLayout(false);
            this.Izmena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Delovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Korisnici;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Izmena;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxKorisnici;
        private System.Windows.Forms.TabPage Dodavanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxAutomobili;
        private System.Windows.Forms.ListBox listBoxPopravke;
        private System.Windows.Forms.ListBox listBoxDeloviZaPopravku;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.RichTextBox commandOutputBox;
    }
}

