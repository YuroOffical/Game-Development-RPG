using RPG;
using System.Threading;

namespace RPG
{
    public partial class Form_main_menu : Form
    {
        Thread thread;
        public Form_main_menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(pickmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button_mm_start_Click(object sender, EventArgs e)
        {
            if (File.Exists("Player 1.txt") || File.Exists("Player 2.txt") || File.Exists("Player 3.txt") || File.Exists("Player 4.txt") || File.Exists("Player 5.txt") || File.Exists("Player 6.txt"))
            {
                this.Close();
                thread = new Thread(startmenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Create a character first");
            }
        }

        private void button_mm_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_mm_load_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openmenu(object obj)
        {
            //Application.Run(new FormGame());
        }
        private void startmenu(object obj)
        {
            Application.Run(new FormCharacterList(1));
        }
        private void pickmenu(object obj)
        {
            Application.Run(new FormCharacterList(0));
        }
    }
}

