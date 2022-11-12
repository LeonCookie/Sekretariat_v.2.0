namespace Sekretariat_v._2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_EditBox = new System.Windows.Forms.TextBox();
            this.Code_EditBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.randomLink = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Password_EditBox = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textbox_wynik = new System.Windows.Forms.TextBox();
            this.SzukajButton = new System.Windows.Forms.Button();
            this.LiteraTextBox = new System.Windows.Forms.TextBox();
            this.KryteriaComboBox = new System.Windows.Forms.ComboBox();
            this.NazwaBomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DodajButton = new System.Windows.Forms.Button();
            this.klasaInput = new System.Windows.Forms.TextBox();
            this.NazwiskoInput = new System.Windows.Forms.TextBox();
            this.InputImie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weryfikacja";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wpisz znaki, które widzisz na poniższym obrazku, aby kontynuwać";
            // 
            // Name_EditBox
            // 
            this.Name_EditBox.Location = new System.Drawing.Point(394, 63);
            this.Name_EditBox.Name = "Name_EditBox";
            this.Name_EditBox.Size = new System.Drawing.Size(225, 31);
            this.Name_EditBox.TabIndex = 4;
            this.Name_EditBox.TextChanged += new System.EventHandler(this.Name_EditBox_TextChanged);
            // 
            // Code_EditBox
            // 
            this.Code_EditBox.Location = new System.Drawing.Point(394, 397);
            this.Code_EditBox.Name = "Code_EditBox";
            this.Code_EditBox.Size = new System.Drawing.Size(225, 31);
            this.Code_EditBox.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::Sekretariat_v._2._0.Properties.Resources._1;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(104, 382);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(244, 57);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // randomLink
            // 
            this.randomLink.AutoSize = true;
            this.randomLink.LinkColor = System.Drawing.Color.Black;
            this.randomLink.Location = new System.Drawing.Point(394, 447);
            this.randomLink.Name = "randomLink";
            this.randomLink.Size = new System.Drawing.Size(97, 25);
            this.randomLink.TabIndex = 8;
            this.randomLink.TabStop = true;
            this.randomLink.Text = "losuj nowy";
            this.randomLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.randomLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.randomLink_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(657, 462);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(159, 42);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password_EditBox
            // 
            this.Password_EditBox.Location = new System.Drawing.Point(394, 155);
            this.Password_EditBox.Name = "Password_EditBox";
            this.Password_EditBox.PasswordChar = '*';
            this.Password_EditBox.Size = new System.Drawing.Size(225, 31);
            this.Password_EditBox.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(821, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 577);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textbox_wynik);
            this.tabPage1.Controls.Add(this.SzukajButton);
            this.tabPage1.Controls.Add(this.LiteraTextBox);
            this.tabPage1.Controls.Add(this.KryteriaComboBox);
            this.tabPage1.Controls.Add(this.NazwaBomboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyszukaj ucznia/uczniów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textbox_wynik
            // 
            this.textbox_wynik.Location = new System.Drawing.Point(64, 352);
            this.textbox_wynik.Multiline = true;
            this.textbox_wynik.Name = "textbox_wynik";
            this.textbox_wynik.Size = new System.Drawing.Size(830, 100);
            this.textbox_wynik.TabIndex = 6;
            // 
            // SzukajButton
            // 
            this.SzukajButton.Location = new System.Drawing.Point(699, 215);
            this.SzukajButton.Name = "SzukajButton";
            this.SzukajButton.Size = new System.Drawing.Size(129, 33);
            this.SzukajButton.TabIndex = 5;
            this.SzukajButton.Text = "Szukaj";
            this.SzukajButton.UseVisualStyleBackColor = true;
            this.SzukajButton.Click += new System.EventHandler(this.SzukajButton_Click);
            // 
            // LiteraTextBox
            // 
            this.LiteraTextBox.Location = new System.Drawing.Point(699, 167);
            this.LiteraTextBox.Name = "LiteraTextBox";
            this.LiteraTextBox.Size = new System.Drawing.Size(150, 31);
            this.LiteraTextBox.TabIndex = 4;
            this.LiteraTextBox.TextChanged += new System.EventHandler(this.LiteraTextBox_TextChanged);
            // 
            // KryteriaComboBox
            // 
            this.KryteriaComboBox.FormattingEnabled = true;
            this.KryteriaComboBox.Items.AddRange(new object[] {
            "równe",
            "rozpoczyna się",
            "zawiera"});
            this.KryteriaComboBox.Location = new System.Drawing.Point(376, 167);
            this.KryteriaComboBox.Name = "KryteriaComboBox";
            this.KryteriaComboBox.Size = new System.Drawing.Size(281, 33);
            this.KryteriaComboBox.TabIndex = 3;
            this.KryteriaComboBox.SelectedIndexChanged += new System.EventHandler(this.KryteriaComboBox_SelectedIndexChanged);
            // 
            // NazwaBomboBox
            // 
            this.NazwaBomboBox.FormattingEnabled = true;
            this.NazwaBomboBox.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Klasa"});
            this.NazwaBomboBox.Location = new System.Drawing.Point(64, 167);
            this.NazwaBomboBox.Name = "NazwaBomboBox";
            this.NazwaBomboBox.Size = new System.Drawing.Size(281, 33);
            this.NazwaBomboBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Wczytaj kategorie wyszukiwania";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DodajButton);
            this.tabPage2.Controls.Add(this.klasaInput);
            this.tabPage2.Controls.Add(this.NazwiskoInput);
            this.tabPage2.Controls.Add(this.InputImie);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj ucznia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(320, 392);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(156, 93);
            this.DodajButton.TabIndex = 17;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // klasaInput
            // 
            this.klasaInput.Location = new System.Drawing.Point(284, 328);
            this.klasaInput.Name = "klasaInput";
            this.klasaInput.Size = new System.Drawing.Size(225, 31);
            this.klasaInput.TabIndex = 16;
            // 
            // NazwiskoInput
            // 
            this.NazwiskoInput.Location = new System.Drawing.Point(284, 202);
            this.NazwiskoInput.Name = "NazwiskoInput";
            this.NazwiskoInput.Size = new System.Drawing.Size(225, 31);
            this.NazwiskoInput.TabIndex = 15;
            // 
            // InputImie
            // 
            this.InputImie.Location = new System.Drawing.Point(284, 72);
            this.InputImie.Name = "InputImie";
            this.InputImie.Size = new System.Drawing.Size(225, 31);
            this.InputImie.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(69, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Klasa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(69, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Imie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 820);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Password_EditBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.randomLink);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Code_EditBox);
            this.Controls.Add(this.Name_EditBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sekretariat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Name_EditBox;
        private TextBox Code_EditBox;
        private PictureBox pictureBox;
        private LinkLabel randomLink;
        private Button LoginButton;
        private MaskedTextBox Password_EditBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private TextBox LiteraTextBox;
        private ComboBox KryteriaComboBox;
        private ComboBox NazwaBomboBox;
        private Button SzukajButton;
        private Button DodajButton;
        private TextBox klasaInput;
        private TextBox NazwiskoInput;
        private TextBox InputImie;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textbox_wynik;
    }
}