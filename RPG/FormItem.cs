using RPG.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace RPG
{
    
    public partial class FormItem : Form
    {
        Player player = new Player();
        public int potion1, potion2, potion3, potion4, potion5, potion6;
        public int amount, cash, file;
        public bool peace;
        public FormItem(int cash, int file, string potion, bool peace)
        {
            InitializeComponent();
            potion1 = Convert.ToInt32(potion[0].ToString());
            potion2 = Convert.ToInt32(potion[1].ToString());
            potion3 = Convert.ToInt32(potion[2].ToString());
            potion4 = Convert.ToInt32(potion[3].ToString());
            potion5 = Convert.ToInt32(potion[4].ToString());
            potion6 = Convert.ToInt32(potion[5].ToString());
            this.file = file;
            this.cash = cash;
            this.peace = peace;
            this.amount = potion1 + potion2 + potion3 + potion4 + potion5 + potion6;
        }

        private void Updatetick(object sender, EventArgs e)
        {
            label1.Text = $"Owned : {potion1}";
            label2.Text = $"Owned : {potion2}";
            label3.Text = $"Owned : {potion3}";
            label4.Text = $"Owned : {potion4}";
            label5.Text = $"Owned : {potion5}";
            label6.Text = $"Owned : {potion6}";

            if (peace == false && amount <= 5)
            {
                pictureBox_main.Image = Properties.Resources.Game_Stor1;
            }
            else if (peace == false && amount <= 10 && amount > 5)
            {
                pictureBox_main.Image = Properties.Resources.Game_Stor2;
            }
            else if (peace == false && amount <= 15 && amount > 10)
            {
                pictureBox_main.Image = Properties.Resources.Game_Stor3;
            }
            else if (peace == false && amount <= 20 && amount > 15)
            {
                pictureBox_main.Image = Properties.Resources.Game_Stor4;
            }
            else if (peace == false && amount <= 30 && amount > 20)
            {
                pictureBox_main.Image = Properties.Resources.Game_Stor5;
            }

            label_cash.Text = "Cash: " + cash + "ඞ";
            // I HAVE BROUGHT PEACE
            if (cash < 500 && peace == true && potion1 <= 8)
            {
                button1.Enabled = false;
                button1.Text = "Too Poor";
            }
            else if (potion1 > 8)
            {
                button1.Enabled = false;
                button1.Text = "Max";
            }
            if (cash < 1000 && peace == true && potion2 <= 8)
            {
                button2.Enabled = false;
                button2.Text = "Too Poor";
            }
            else if (potion2 > 8)
            {
                button2.Enabled = false;
                button2.Text = "Max";
            }
            if (cash < 1500 && peace == true && potion6 <= 8)
            {
                button6.Enabled = false;
                button6.Text = "Too Poor";
            }
            else if (potion6 > 8)
            {
                button6.Enabled = false;
                button6.Text = "Max";
            }
            if (cash < 2500 && peace == true && potion3 <= 8)
            {
                button3.Enabled = false;
                button3.Text = "Too Poor";
            }
            else if (potion3 > 8)
            {
                button3.Enabled = false;
                button3.Text = "Max";
            }
            if (cash < 2500 && peace == true && potion4 <= 8)
            {
                button4.Enabled = false;
                button4.Text = "Too Poor";
            }
            else if (potion4 > 8)
            {
                button4.Enabled = false;
                button4.Text = "Max";
            }
            if (cash < 5000 && peace == true && potion5 <= 8)
            {
                button5.Enabled = false;
                button5.Text = "Too Poor";
            }
            else if (potion5 > 8)
            {
                button4.Enabled = false;
                button4.Text = "Max";
            }
            // YOU WERE THE CHOSEN ONE ANAKIN
            if (potion1 > 0 && peace == false)
            {
                button1.Enabled = true;
                button1.Text = "Use";
                label1c.Visible = false;
            }
            else if (potion1 <= 0 && peace == false)
            {
                button1.Enabled = false;
                button1.Text = "Empty";
            }
            if (potion2 > 0 && peace == false)
            {
                button2.Enabled = true;
                button2.Text = "Use";
                label2c.Visible = false;
            }
            else if (potion2 <= 0 && peace == false)
            {
                button2.Enabled = false;
                button2.Text = "Empty";
            }
            if (potion3 > 0 && peace == false)
            {
                button3.Enabled = true;
                button3.Text = "Use";
                label3c.Visible = false;
            }
            else if (potion3 <= 0 && peace == false)
            {
                button3.Enabled = false;
                button3.Text = "Empty";
            }
            if (potion4 > 0 && peace == false)
            {
                button4.Enabled = true;
                button4.Text = "Use";
                label4c.Visible = false;
            }
            else if (potion4 <= 0 && peace == false)
            {
                button4.Enabled = false;
                button4.Text = "Empty";
            }
            if (potion5 > 0 && peace == false)
            {
                button5.Enabled = true;
                button5.Text = "Use";
                label5c.Visible = false;
            }
            else if (potion5 <= 0 && peace == false)
            {
                button5.Enabled = false;
                button5.Text = "Empty";
            }
            if (potion6 > 0 && peace == false)
            {
                button6.Enabled = true;
                button6.Text = "Use";
                label6c.Visible = false;
            }
            else if (potion6 <= 0 && peace == false)
            {
                button6.Enabled = false;
                button6.Text = "Empty";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (peace == false)
            {
                File.WriteAllText("TempItem.txt", "Pray,hel,normal,50");
                potion1--;
                potionupdator();
                this.Close();
            }
            else
            {
                potion1++;
                cash = cash - 500;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Resume.txt", "");
            string result = "";
            result = potion1 + "" + potion2 + "" + potion3 + "" + potion4 + "" + potion5 + "" + potion6 + " " + cash;
            File.WriteAllText("TempItemp.txt", result);
            potionupdator();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (peace == false)
            {
                File.WriteAllText("TempItem.txt", "Potion,buf,frozen-frozen,60-60");
                potion2--;
                potionupdator();
                this.Close();
            }
            else
            {
                potion2++;
                cash = cash - 1000;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (peace == false)
                {
                    File.WriteAllText("TempItem.txt", "Potion,buf,haste,25");
                    potion3--;
                    potionupdator();
                    this.Close();
                }
                else
                {
                    potion3++;
                    cash = cash - 2500;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (peace == false)
                {
                    File.WriteAllText("TempItem.txt", "Potion,dbf,dizzy-poison,25-25");
                    potion4--;
                    potionupdator();
                    this.Close();
                }
                else
                {
                    potion4++;
                    cash = cash - 2500;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (peace == false)
                {
                    File.WriteAllText("TempItem.txt", "Potion,dmg,almighty,125");
                    potion5--;
                    potionupdator();
                    this.Close();
                }
                else
                {
                    potion5++;
                    cash = cash - 2500;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (peace == false)
            {
                File.WriteAllText("TempItem.txt", "Potion,buf,fire-lifesteal-frenzy,20-20-20");
                potion6--;
                potionupdator();
                this.Close();
            }
            else
            {
                potion6++;
                cash = cash - 2500;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void potionupdator()
        {
            string result = "";
            result = "" + potion1 + "" + potion2 + "" + potion3 + "" + potion4 + "" + potion5 + "" + potion6;
            player.EditString(file, "potion:", result);
            player.EditorInt(file, "cash:", cash, 0);
        }
    }
}

