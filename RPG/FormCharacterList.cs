using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RPG.Class;


namespace RPG
{
    public partial class FormCharacterList : Form
    {
        Thread thread;
        SlotChecker slotter = new SlotChecker();
        public int picker;
        public int savefilepicked;
        public string[] Playerfile = { "Player 1.txt", "Player 2.txt", "Player 3.txt", "Player 4.txt", "Player 5.txt", "Player 6.txt" };
        public FormCharacterList(int x)
        {

            InitializeComponent();
            picker = x;
            if (File.Exists("Player 1.txt"))
            {
                button_FCl_character_1.Text = Display(0);
                button_FCl_character_1.Size = new Size(298, 50);
                button_FCl_character_1.Enabled = false;
            }
            if (File.Exists("Player 2.txt"))
            {
                button_FCl_character_2.Text = Display(1);
                button_FCl_character_2.Size = new Size(298, 50);
                button_FCl_character_2.Enabled = false;
            }
            if (File.Exists("Player 3.txt"))
            {
                button_FCl_character_3.Text = Display(2);
                button_FCl_character_3.Size = new Size(298, 50);
                button_FCl_character_3.Enabled = false;
            }
            if (File.Exists("Player 4.txt"))
            {
                button_FCl_character_4.Text = Display(3);
                button_FCl_character_4.Size = new Size(298, 50);
                button_FCl_character_4.Enabled = false;
            }
            if (File.Exists("Player 5.txt"))
            {
                button_FCl_character_5.Text = Display(4);
                button_FCl_character_5.Size = new Size(298, 50);
                button_FCl_character_5.Enabled = false;
            }
            if (File.Exists("Player 6.txt"))
            {
                button_FCl_character_6.Text = Display(5);
                button_FCl_character_6.Size = new Size(298, 50);
                button_FCl_character_6.Enabled = false;
            }
            int n = 0;



            if (!File.Exists("Player 1.txt")&&picker==0)
            {
                button_FCl_character_1.Text = "Currently No Character";
                button_FCl_character_1.Size = new Size(371, 50);
                button_FCl_character_1.Enabled = true;
                slotter.Slot(1, "2");
            }
            else if (!File.Exists("Player 1.txt") && picker == 1)
            {
                button_FCl_character_1.Text = "Unavaiable to Play";
                button_FCl_character_1.Size = new Size(371, 50);
                button_FCl_character_1.Enabled = false;
            }
            else if (File.Exists("Player 1.txt") && picker == 1)
            {
                button_FCl_character_1.Enabled = true;
                slotter.Slot(1, "0");
            }
            if (!File.Exists("Player 2.txt") && picker == 0)
            {
                button_FCl_character_2.Text = "Currently No Character";
                button_FCl_character_2.Size = new Size(371, 50);
                slotter.Slot(2, "2");
            }
            else if (!File.Exists("Player 2.txt") && picker == 1)
            {
                button_FCl_character_2.Text = "Unavaiable to Play";
                button_FCl_character_2.Size = new Size(371, 50);
                button_FCl_character_2.Enabled = false;
            }
            else if (File.Exists("Player 2.txt") && picker == 1)
            {
                button_FCl_character_2.Enabled = true;
                slotter.Slot(2, "0");
            }
            if (!File.Exists("Player 3.txt") && picker == 0)
            {
                button_FCl_character_3.Text = "Currently No Character";
                button_FCl_character_3.Size = new Size(371, 50);
                slotter.Slot(3, "2");
            }
            else if (!File.Exists("Player 3.txt") && picker == 1)
            {
                button_FCl_character_3.Text = "Unavaiable to Play";
                button_FCl_character_3.Size = new Size(371, 50);
                button_FCl_character_3.Enabled = false;
            }
            else if (File.Exists("Player 3.txt") && picker == 1)
            {
                button_FCl_character_3.Enabled = true;
                slotter.Slot(3, "0");
            }
            if (!File.Exists("Player 4.txt") && picker == 0)
            {
                button_FCl_character_4.Text = "Currently No Character";
                button_FCl_character_4.Size = new Size(371, 50);
                slotter.Slot(4, "2");
            }
            else if (!File.Exists("Player 4.txt") && picker == 1)
            {
                button_FCl_character_4.Text = "Unavaiable to Play";
                button_FCl_character_4.Size = new Size(371, 50);
                button_FCl_character_4.Enabled = false;
            }
            else if (File.Exists("Player 4.txt") && picker == 1)
            {
                button_FCl_character_4.Enabled = true;
                slotter.Slot(4, "0");
            }
            if (!File.Exists("Player 5.txt") && picker == 0)
            {
                button_FCl_character_5.Text = "Currently No Character";
                button_FCl_character_5.Size = new Size(371, 50);
                slotter.Slot(5, "2");
            }
            else if (!File.Exists("Player 5.txt") && picker == 1)
            {
                button_FCl_character_5.Text = "Unavaiable to Play";
                button_FCl_character_5.Size = new Size(371, 50);
                button_FCl_character_5.Enabled = false;
            }
            else if(File.Exists("Player 5.txt") && picker == 1)
            {
                button_FCl_character_5.Enabled = true;
                slotter.Slot(5, "0");
            }
            if (!File.Exists("Player 6.txt") && picker == 0)
            {
                button_FCl_character_6.Text = "Currently No Character";
                button_FCl_character_6.Size = new Size(371, 50);
                slotter.Slot(6, "2");
            }
            else if (!File.Exists("Player 6.txt") && picker == 1)
            {
                button_FCl_character_6.Text = "Unavaiable to Play";
                button_FCl_character_6.Size = new Size(371, 50);
                button_FCl_character_6.Enabled = false;
            }
            else if (File.Exists("Player 6.txt") && picker == 1)
            {
                button_FCl_character_6.Enabled = true;
                slotter.Slot(6, "0");
            }
        }
        private void button_FCl_character_1_Click(object sender, EventArgs e)
        {
            slotter.Slot(1, "1");
            slotter.Set(1);
            savefilepicked = 1;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            
        }
        private void btn_mm_return_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(mainmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCharacterMenu charcreator = new FormCharacterMenu();
            charcreator.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button_FCl_character_1.Size = new Size(371, 50);
            slotter.Slot(1, "0");
            File.Delete("Player 1.txt");
            button_FCl_character_1.Text = "Currently No Character";
            button_FCl_character_1.Enabled = true;
        }

        private void button_slot_2_del_Click(object sender, EventArgs e)
        {
            button_FCl_character_2.Size = new Size(371, 50);
            slotter.Slot(2, "0");
            File.Delete("Player 2.txt");
            button_FCl_character_2.Text = "Currently No Character";
            button_FCl_character_2.Enabled = true;
        }

        private void button_slot_3_del_Click(object sender, EventArgs e)
        {
            button_FCl_character_3.Size = new Size(371, 50);
            slotter.Slot(3, "0");
            File.Delete("Player 3.txt");
            button_FCl_character_3.Text = "Currently No Character";
            button_FCl_character_3.Enabled = true;
        }

        private void button_slot_4_del_Click(object sender, EventArgs e)
        {
            button_FCl_character_4.Size = new Size(371, 50);
            slotter.Slot(4, "0");
            File.Delete("Player 4.txt");
            button_FCl_character_4.Text = "Currently No Character";
            button_FCl_character_4.Enabled = true;
        }

        private void button_slot_5_del_Click(object sender, EventArgs e)
        {
            button_FCl_character_5.Size = new Size(371, 50);
            slotter.Slot(5, "0");
            File.Delete("Player 5.txt");
            button_FCl_character_5.Text = "Currently No Character";
            button_FCl_character_5.Enabled = true;
        }

        private void button_slot_6_del_Click(object sender, EventArgs e)
        {
            button_FCl_character_6.Size = new Size(371, 50);
            slotter.Slot(6, "0");
            File.Delete("Player 6.txt");
            button_FCl_character_6.Text = "Currently No Character";
            button_FCl_character_6.Enabled = true;
        }

        private void button_FCl_character_2_Click(object sender, EventArgs e)
        {
            slotter.Slot(2, "1");
            slotter.Set(2);
            savefilepicked = 2;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void button_FCl_character_3_Click(object sender, EventArgs e)
        {
            slotter.Slot(3, "1");
            slotter.Set(3);
            savefilepicked = 3;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void button_FCl_character_4_Click(object sender, EventArgs e)
        {
            slotter.Slot(4, "1");
            slotter.Set(4);
            savefilepicked = 4;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void button_FCl_character_5_Click(object sender, EventArgs e)
        {
            slotter.Slot(5, "1");
            slotter.Set(5);
            savefilepicked = 5;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void button_FCl_character_6_Click(object sender, EventArgs e)
        {
            slotter.Slot(6, "1");
            slotter.Set(6);
            savefilepicked = 6;
            if (picker == 0)
            {
                
                this.Close();
                thread = new Thread(openmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                this.Close();
                thread = new Thread(gamestartmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        private void openmenu(object obj)
        {
            Application.Run(new FormCharacterMenu());
        }
        private void mainmenu(object obj)
        {
            Application.Run(new Form_main_menu());
        }
        
        private void gamestartmenu(object obj)
        {
            Application.Run(new FormGame(savefilepicked));
        }
        private string Display(int y)
        {
            string result = "";
            string data = File.ReadAllText(Playerfile[y]);
            string[] stat = data.Split(' ');
            foreach (var stats in stat)
            {
                if (stats.Contains("name"))
                {
                    result = result + "Name: " + (stats.Substring(5, stats.Length - 5).Replace('_',' '));
                }
                if (stats.Contains("class"))
                {
                    result = result + " Class: " + (stats.Substring(6, stats.Length - 6));
                }
                if (stats.Contains("level"))
                {
                    result = result + " Level: " + (stats.Substring(6, stats.Length - 6));
                }
                if (stats.Contains("cash"))
                {
                    result = result + " Cash: ඞ" + (stats.Substring(5, stats.Length - 5));
                }
            }
            return result;
        }
    }
}
