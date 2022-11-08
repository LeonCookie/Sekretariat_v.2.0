using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Sekretariat_v._2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomIMG();
            //tabControl1.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Name_EditBox_TextChanged(object sender, EventArgs e)
        {

        }


        void randomIMG()
        {
            var randomGenerator = new Random();
            random1 = randomGenerator.Next(1, 7);



            if (random1 == 1)
            {
                pictureBox.Image = Properties.Resources._1;
                ScheckCode = "mxyxw";

            }
            else if (random1 == 2)
            {
                pictureBox.Image = Properties.Resources._2;
                ScheckCode = "b5nmm";

            }
            else if (random1 == 3)
            {
                pictureBox.Image = Properties.Resources._3;
                ScheckCode = "74853";
            }
            else if (random1 == 4)
            {
                pictureBox.Image = Properties.Resources._4;
                ScheckCode = "cg5dd";
            }
            else if (random1 == 5)
            {
                pictureBox.Image = Properties.Resources._5;
                ScheckCode = "x3deb";
            }
            else if (random1 == 6)
            {
                pictureBox.Image = Properties.Resources._6;
                ScheckCode = "befbd";
            }
            else if (random1 == 7)
            {
                pictureBox.Image = Properties.Resources._7;
                ScheckCode = "c7gb3";
            }
            Debug.WriteLine(random1 + "   " + ScheckCode);
        }


        int random1 = 1;
        string Slogin, Spassword, Scode = "";
        string ScheckCode = "";
        private void randomLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Debug.WriteLine("kliknieto link");
            randomIMG();


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void LiteraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KryteriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string Search, Simie, Snaziwsko, Sklasa = "";
        int INazwaCombobox;
        int IKryteriaCombobox;

        private void SzukajButton_Click(object sender, EventArgs e)
        {


            
              //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\student\Desktop\uczen.txt");
              string[] lines = System.IO.File.ReadAllLines(@"C:\Users\leonr\OneDrive\Pulpit\uczen.txt");
            LiteraTextBox.Text = "";
            foreach (string line in lines)
            {
                if (NazwaBomboBox.SelectedIndex == 0)
                {
                    if (KryteriaComboBox.SelectedIndex == 0)
                    {
                        if (LiteraTextBox.Text == line.Split(' ')[0])
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[0].Contains(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[0].StartsWith(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                }
                if (NazwaBomboBox.SelectedIndex == 1)
                {
                    if (KryteriaComboBox.SelectedIndex == 0)
                    {
                        if (LiteraTextBox.Text == line.Split(' ')[1])
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[1].Contains(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[1].StartsWith(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                }
                if (NazwaBomboBox.SelectedIndex == 2)
                {
                    if (KryteriaComboBox.SelectedIndex == 0)
                    {
                        if (LiteraTextBox.Text == line.Split(' ')[2])
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[2].Contains(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }
                    if (KryteriaComboBox.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[2].StartsWith(LiteraTextBox.Text))
                            textbox_wynik.AppendText(line + "\r\n");
                    }

                }
            }
        }

        private async void DodajButton_Click(object sender, EventArgs e)
        {
            if (InputImie.Text != "" && NazwiskoInput.Text != "" && klasaInput.Text != "")
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // zapisywanie do pliku
                using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt"), true))
                {
                    outputFile.WriteLine(InputImie.Text + " " + NazwiskoInput.Text + " " + klasaInput.Text);
                }
                InputImie.Text = " ";
                NazwiskoInput.Text = " ";
                klasaInput.Text = " ";

                MessageBox.Show("Dodano ucznia!");
            }
            else
            {
                MessageBox.Show("Prosze dokladnie wpisac dane do wprowadzeia");
            }
        }

        bool BCanIdo = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_EditBox.Text) && (string.IsNullOrEmpty(Password_EditBox.Text) && (string.IsNullOrEmpty(Name_EditBox.Text))))
            {
                MessageBox.Show("�adne pole nie mo�e zosta� puste!");

            }
            else
            {
                Slogin = Name_EditBox.Text;
                Spassword = Password_EditBox.Text;
                ScheckCode = Code_EditBox.Text;


                if (random1 == 1 && ScheckCode == "mxyxw")
                {
                    BCanIdo = true;
                }
                else if (random1 == 2 && ScheckCode == "b5nmm")
                {
                    BCanIdo = true;
                }
                else if (random1 == 3 && ScheckCode == "74853")
                {
                    BCanIdo = true;
                }
                else if (random1 == 4 && ScheckCode == "cg5dd")
                {
                    BCanIdo = true;
                }
                else if (random1 == 5 && ScheckCode == "x3deb")
                {
                    BCanIdo = true;
                }
                else if (random1 == 6 && ScheckCode == "befbd")
                {
                    BCanIdo = true;
                }
                else if (random1 == 7 && ScheckCode == "c7gb3")
                {
                    BCanIdo = true;
                }

                if (Slogin == "admin" && Spassword == "Qwerty1@34" && BCanIdo == true)
                {


                    Debug.WriteLine("Witam w systemie");
                    Slogin = "";
                    Spassword = "";
                    Name_EditBox.Clear();
                    Password_EditBox.Clear();
                    Code_EditBox.Clear();
                    randomIMG();

                    tabControl1.Location = (Location = new System.Drawing.Point(21, 20));
                    tabControl1.Show();

                }
                else
                {
                    BCanIdo = false;
                    MessageBox.Show("�le wype�nionio dane");
                    Slogin = "";
                    Spassword = "";
                    Name_EditBox.Clear();
                    Password_EditBox.Clear();
                    Code_EditBox.Clear();
                    randomIMG();
                }


            }
        }
    }
}