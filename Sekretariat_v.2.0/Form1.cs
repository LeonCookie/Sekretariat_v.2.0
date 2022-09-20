using System.Diagnostics;

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


        int random1 = 1;
        string Slogin,Spassword,Scode="";
        string ScheckCode = "mxyxw";
        private void randomLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Debug.WriteLine("kliknieto link");

            var randomGenerator = new Random();
             random1 = randomGenerator.Next(1, 7);


            
            if (random1 == 1)
            {
                pictureBox.Image = Properties.Resources._1;
                ScheckCode = "mxyxw";

            } else if (random1 == 2)
            {
                pictureBox.Image = Properties.Resources._2;
                ScheckCode = "b5nmm";

            } else if(random1 == 3)
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
            Debug.WriteLine(random1+"   "+ScheckCode);


        }

        bool BCanIdo = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_EditBox.Text) && (string.IsNullOrEmpty(Password_EditBox.Text) && (string.IsNullOrEmpty(Name_EditBox.Text))))
            {
                MessageBox.Show("Øadne pole nie moøe zostaÊ puste!");
                
            }
            else
            {
                if (Slogin == "admin" && Spassword== "Qwerty1@34")
                {
                    if(random1 == 1 && ScheckCode == "mxyxw")
                    {
                        BCanIdo = true;
                    }
                    else if(random1 == 2 && ScheckCode == "b5nmm")
                    {
                        BCanIdo = true;
                    }
                    else if(random1 == 3 && ScheckCode == "74853")
                    {
                        BCanIdo = true;
                    }
                    else if(random1 == 4 && ScheckCode == "cg5dd")
                    {
                        BCanIdo = true;
                    }
                    else if(random1 == 5 && ScheckCode == "x3deb")
                    {
                        BCanIdo = true;
                    }
                    else if(random1 == 6 && ScheckCode == "befbd")
                    {
                        BCanIdo = true;
                    }
                    else if(random1== 7 && ScheckCode== "c7gb3")
                    {
                        BCanIdo = true;
                    }


                }
                else
                {
                    BCanIdo = false;
                    MessageBox.Show("èle wype≥nionio dane");
                }

                if(BCanIdo == true)
                {
                    Debug.WriteLine("Witam w systemie");
                }
            }
        }
    }
}