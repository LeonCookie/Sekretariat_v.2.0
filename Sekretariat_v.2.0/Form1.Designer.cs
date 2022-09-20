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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(128, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(128, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
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
            this.Name_EditBox.Location = new System.Drawing.Point(394, 64);
            this.Name_EditBox.Name = "Name_EditBox";
            this.Name_EditBox.Size = new System.Drawing.Size(226, 31);
            this.Name_EditBox.TabIndex = 4;
            this.Name_EditBox.TextChanged += new System.EventHandler(this.Name_EditBox_TextChanged);
            // 
            // Code_EditBox
            // 
            this.Code_EditBox.Location = new System.Drawing.Point(394, 396);
            this.Code_EditBox.Name = "Code_EditBox";
            this.Code_EditBox.Size = new System.Drawing.Size(226, 31);
            this.Code_EditBox.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::Sekretariat_v._2._0.Properties.Resources._1;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(104, 381);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(244, 57);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
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
            this.LoginButton.Size = new System.Drawing.Size(159, 34);
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
            this.Password_EditBox.Size = new System.Drawing.Size(226, 31);
            this.Password_EditBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 544);
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
    }
}