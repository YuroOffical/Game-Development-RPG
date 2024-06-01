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
using RPG.Class;
using System.Threading;

namespace RPG
{
    
    public partial class FormCharacterMenu : Form
    {
        Thread thread;
        protected string pclass;
        public string name = "";
        SlotChecker slot = new SlotChecker();

        public FormCharacterMenu()
        {
            InitializeComponent();
            track_m.Value = 5;
            track_d.Value = 3;
            track_r.Value = 1;

        }

        private void FormCharacterMenu_Load(object sender, EventArgs e)
        {

        }
        private void btn_class_warrior_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("warrior", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }
        private void btn_class_knight_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("knight", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void btn_class_lancer_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("lancer", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void btn_class_thief_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("thief", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            };
        }

        private void btn_class_ranger_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("ranger", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void btn_class_archer_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("archer", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void btn_class_wizard_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("wizard", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void btn_class_mage_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("mage", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }
        private void openmenu(object obj)
        {
            string mapcus = Convert.ToString(track_m.Value) + " " + Convert.ToString(track_d.Value) + " " + Convert.ToString(track_r.Value+1);
            File.WriteAllText("Temp2.txt", mapcus);
            Application.Run(new FormClassChoice());
        }

        private void txt_Chara_name_TextChanged(object sender, EventArgs e)
        {
            string name = txt_Chara_name.Text;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            name = txt_Chara_name.Text;
            if (txt_Chara_name.Text.Contains(' '))
            {
                name.Replace(' ', '_');
            }
            
            Random random = new Random();
            int chance = random.Next(1, 1001);
            if (chance == 1000)
            {
                MessageBox.Show($"{name} thats a horrible name, why would anyone pick THAT?!");
            }
            else
            {
                MessageBox.Show("name has been set");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_r_Click(object sender, EventArgs e)
        {

        }

        private void SliderUpdate(object sender, EventArgs e)
        {
            //dungeon
            if(track_d.Value < 4)
            {
                lbl_d.Text = "Scarce";
            }
            else if (track_d.Value > 6)
            {
                lbl_d.Text = "Sprawling";
            }
            else
            {
                lbl_d.Text = "Typical";
            }
            //mountain
            if (track_m.Value < 4)
            {
                lbl_m.Text = "Flat";
            }
            else if (track_m.Value > 6)
            {
                lbl_m.Text = "Mountinous";
            }
            else
            {
                lbl_m.Text = "Normal";
            }
            //random factor
            if (track_r.Value < 2)
            {
                lbl_r.Text = "Normal";
            }
            else if (track_r.Value > 5 && track_r.Value < 9)
            {
                lbl_r.Text = "Wild";
            }
            else if (track_r.Value >= 8)
            {
                lbl_r.Text = "Don't";
            }
            else
            {
                lbl_r.Text = "Spicy";
            }
        }

        private void button_stickboi_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("stickboi", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void track_m_Scroll(object sender, EventArgs e)
        {

        }

        private void button_slayer_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("slayer", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void button_curse_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("cursed", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }

        private void button_miko_Click(object sender, EventArgs e)
        {
            if (name != "")
            {
                slot.ClassCharacterSelected("miko", name);
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("set a name first");
            }
        }
    }
}
