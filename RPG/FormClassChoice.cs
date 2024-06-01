using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RPG.Class;

namespace RPG
{
    public partial class FormClassChoice : Form
    {
        Mapgenerator map = new Mapgenerator();
        SlotChecker slot = new SlotChecker();
        FormCharacterMenu fcm = new FormCharacterMenu();
        public string setclass;
        public string stat;
        Thread thread;
        public FormClassChoice()
        {
            InitializeComponent();
            setclass = File.ReadAllText("temp.txt");
            string[] data = setclass.Split(' ');
            if (data[0] == "warrior")
            {
                label_FCC.Text = "Warrior Class";
                btn_accept.Text = "I like to cut things";
                btn_reject.Text = ":l";
                stat = $"name:{data[1]} class:Warrior Str:1m3 Dex:1m2 Vit:1m1.5 Agi:1m0.8 Int:1m0.7 Wis:1m1 helm:0 chest:0 leg:0 glove:0 weapon:0 cash:1000 exp:0 Sp:2 skill:0 level:1 position:53,512 ng:0 mapseed:";
            }
            else if (data[0] == "knight")
            {
                label_FCC.Text = "Knight Class";
                btn_accept.Text = "Thicc";
                btn_reject.Text = "being a peasent wasnt so bad";
                stat = $"name:{data[1]}";
            }
            else if (data[0] == "ranger")
            {
                label_FCC.Text = "Ranger Class";
                btn_accept.Text = "Guns, guns everywhere";
                btn_reject.Text = "I blew my hand off once, aint doing it again damnit";
            }
            else if (data[0] == "archer")
            {
                label_FCC.Text = "Archer Class";
                btn_accept.Text = "wooosh";
                btn_reject.Text = "my KNEE";
            }
            else if (data[0] == "lancer")
            {
                label_FCC.Text = "Lancer Class";
            }
            else if (data[0] == "thief")
            {
                label_FCC.Text = "Thief Class";
            }
            else if (data[0] == "wizard")
            {
                label_FCC.Text = "Wizard Class";
            }
            else if (data[0] == "mage")
            {
                label_FCC.Text = "Mage Class";
            }
            else if (data[0] == "stickboi")
            {
                label_FCC.Text = "Stick Prayer Class";
                label_desc1.Text = "Balance Stats";
                label_desc2.Text = "Mix Skillset good all-rounder";
                label_desc3.Text = "Can Yeet a star at your enemies";
                picture_FCC.Image = Properties.Resources.Charastat0000;
                btn_accept.Text = "Accept the Stick";
                btn_reject.Text = "Shame";
                stat = $"name:{data[1]} class:Stickboi Str:1m1.5 Dex:1m1.5 Vit:1m1.5 Agi:1m1.5 Int:1m1.5 Wis:1m1.5 helm:0 chest:0 leg:0 glove:0 weapon:0 potion:000000 cash:1000 exp:0 Sp:2 skill:0 level:1 position:53,512 ng:0 mapseed:";
            }
            else if (data[0] == "miko")
            {
                label_FCC.Text = "Shrine Maiden Class";
                label_desc1.Text = "Magic based Stats, Great Caster";
                label_desc2.Text = "Powerful Cast and Skills, Weak Melee";
                label_desc3.Text = "In a pinch, just summon your shrine";
                picture_FCC.Image = Properties.Resources.Charastat0003;
                btn_accept.Text = "Purify EVERYTHING";
                btn_reject.Text = "Return";
                stat = $"name:{data[1]} class:Miko Str:1m0.7 Dex:1m1.2 Vit:1m1.2 Agi:1m1.2 Int:1m2.5 Wis:1m2.5 helm:0 chest:0 leg:0 glove:0 weapon:0 potion:000000 cash:1000 exp:0 Sp:2 skill:0 level:1 position:53,512 ng:0 mapseed:";
            }
            else if (data[0] == "slayer")
            {
                label_FCC.Text = "Slayer Class";
                label_desc1.Text = "Formidable Stats, Tears everything";
                label_desc2.Text = "Buffs, Slash, Guns, Powerful Skillsets";
                label_desc3.Text = "If all else fails, call an airstrike";
                picture_FCC.Image = Properties.Resources.Charastat0001;
                btn_accept.Text = "Rip and Tear";
                btn_reject.Text = "Return";
                stat = $"name:{data[1]} class:Slayer Str:1m3.5 Dex:1m3.5 Vit:1m1.5 Agi:1m1.2 Int:1m0.7 Wis:1m0.7 helm:0 chest:0 leg:0 glove:0 weapon:0 potion:000000 cash:1000 exp:0 Sp:2 skill:0 level:1 position:53,512 ng:0 mapseed:";
            }
            else if (data[0] == "cursed")
            {
                label_FCC.Text = "Cursed User";
                label_desc1.Text = "Survivability Based Stats";
                label_desc2.Text = "Cursed by the void, Suffering";
                label_desc3.Text = "Extend your domain with your ultimate";
                picture_FCC.Image = Properties.Resources.Charastat0002;
                btn_accept.Text = "⚐︎♒︎ ♑︎□︎♎︎ ⬥︎♒︎⍓︎";
                btn_reject.Text = "Return";
                stat = $"name:{data[1]} class:Cursed Str:1m0.9 Dex:1m1.1 Vit:1m2.5 Agi:1m2.5 Int:1m1.1 Wis:1m0.9 helm:0 chest:0 leg:0 glove:0 weapon:0 potion:000000 cash:1000 exp:0 Sp:2 skill:0 level:1 position:53,512 ng:0 mapseed:";
            }
            File.Delete("temp.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string seed = map.Mapgen();
            stat = stat + seed;
            slot.Createplayer(stat);
            File.Delete("Temp2.txt");
            this.Close();
            thread = new Thread(mainmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openmenu(object obj)
        {
            Application.Run(new FormCharacterMenu());
        }
        private void mainmenu(object obj)
        {
            Application.Run(new Form_main_menu());
        }

        private void label_desc1_Click(object sender, EventArgs e)
        {

        }
    }
}
