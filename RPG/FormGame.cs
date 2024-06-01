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
using System.Timers;
using System.Drawing.Text;

namespace RPG
{
    public partial class FormGame : Form
    {
        Thread thread;
        Random RNG = new Random();
        public string[] playersavefile = { "Player 1.txt", "Player 2.txt", "Player 3.txt", "Player 4.txt", "Player 5.txt", "Player 6.txt" };
        #region public variables

        // Movement
        int movement;
        bool moving;
        bool moveup;
        bool movedown;
        bool moveleft;
        bool moveright;

        // Map and Location
        public int leftcontrol = 1;
        public int[,] map = new int[8, 19];
        public string seed;
        public string perlinnoise;
        public int savefilepicked;
        public string biome;

        // Player Stats
        public string name;
        public string pclass, potion;
        public double STR, DEX, VIT, AGI, INT, WIS;
        public double STRm, DEXm, VITm, AGIm, INTm, WISm;
        public double HP, MP, Atk ,Def, Armor, Speed, special, crit;
        public int helm, chest, leg, glove, weapon;
        public int cash, exp, level, skill, ng, SP, x, y;
        public double encountermeter;
        public int encounter, encounterreached, amiinbattlemode;

       

        public int difficulty;

        private void button_equipment_Click(object sender, EventArgs e)
        {
            FormEquipment equipment = new FormEquipment(cash, helm, chest, leg, glove, weapon);
            equipment.ShowDialog();
        }

        public int levellimit;

        private void Gamesituation(object sender, EventArgs e)
        {
            
            // Transfer Data
            if (File.Exists("TempStat.txt"))
            {
                string[] statdata = File.ReadAllText("TempStat.txt").Split(' ');
                this.STR = Convert.ToDouble(statdata[0]);
                this.DEX = Convert.ToDouble(statdata[1]);
                this.VIT = Convert.ToDouble(statdata[2]);
                this.AGI = Convert.ToDouble(statdata[3]);
                this.INT = Convert.ToDouble(statdata[4]);
                this.WIS = Convert.ToDouble(statdata[5]);
                this.SP = Convert.ToInt32(statdata[6]);
                File.Delete("TempStat.txt");
                Save();
            }
            if (File.Exists("TempEquipment.txt"))
            {
                string[] statdata = File.ReadAllText("TempEquipment.txt").Split(' ');
                this.cash = Convert.ToInt32(statdata[0]);
                this.helm = Convert.ToInt32(statdata[1]);
                this.chest = Convert.ToInt32(statdata[2]);
                this.leg = Convert.ToInt32(statdata[3]);
                this.glove = Convert.ToInt32(statdata[4]);
                this.weapon = Convert.ToInt32(statdata[5]);
                File.Delete("TempEquipment.txt");
                Save();
            }
            if (File.Exists("TempItemp.txt"))
            {
                string[] statdata = File.ReadAllText("TempItemp.txt").Split(' ');
                this.potion = statdata[0];
                this.cash = Convert.ToInt32(statdata[1]);
                File.Delete("TempItemp.txt");
                Save();
            }
            
            // Stats Calculator
            // Pool = No Limit, Fixed/Percetage = try to not go overboard
            HP = ((STR * STRm) * 10) + ((VIT * VITm) * 10) + (chest * 5) + (helm * 2) + 30;
            MP = ((INT * INTm) * 10) + ((WIS * WISm) * 3) + ((DEX * DEXm) * 1);
            Atk = ((STR * STRm) * 2) + ((DEX * DEXm) * 2) + (weapon * 2) + glove;
            Def = (((STR * STRm) * 2) + ((VIT * VITm) * 1) + (chest / 5) + (glove / 5)) / 2;
            Armor = ((VIT * VITm) + chest + glove + helm) / 5;
            Speed = (((AGI * AGIm) * 4) + ((DEX * DEXm) * 2) + weapon + leg * 2) / 4;
            special = ((INT * INTm) * 5) + ((WIS * WISm) * 3);
            crit = ((AGI * AGIm) * 2) + ((WIS * WISm) * 3) + weapon;

            // Level update
            levellimit = 800 + (level * 200);
            label_level.Text = $"Level : {level}";
            progressBar_level.Maximum = levellimit;
            progressBar_level.Value = exp;
            if (exp >= levellimit)
            {
                level++;
                exp = 0;
                SP = SP + 2;
            }

            //encounter
            if (moving == true)
            {
                progressBarenc.Value = progressBarenc.Value + Convert.ToInt32(encountermeter);
            }
            encounterreached = RNG.Next(250, 10001);
            if (progressBarenc.Value + 50 > encounterreached && amiinbattlemode == 0)
            {
                amiinbattlemode = 1;
                progressBarenc.Value = 0;
                if (ng == 0)
                {
                    encounter = 10;
                }
                else if (ng == 1)
                {
                    encounter = 12;
                }
                else
                {
                    encounter = 10;
                }
                this.Close();
                thread = new Thread(battlemode);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            if (amiinbattlemode == 1)
            {
                progressBarenc.Value = 0;
            }
        }

        private void button_stats_Click(object sender, EventArgs e)
        {
            FormGameStat statsview = new FormGameStat(name, pclass, cash, exp,level, STR, DEX, VIT, AGI, INT, WIS, STRm, DEXm, VITm, AGIm, INTm, WISm, HP, MP, Atk, Def, Armor, Speed, special, crit, SP, helm, chest, leg, glove, weapon, savefilepicked);
            statsview.ShowDialog();
        }

        public string counterer ="";
        #endregion
        public FormGame(int savefilepicked)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.savefilepicked = savefilepicked;
            this.KeyPreview = true;
            int counter = 0;
            int count = 0;


            //Player save set
            #region decompiler
            string playerdata = File.ReadAllText(playersavefile[(savefilepicked - 1)]);
            string[] pdatastring = playerdata.Split(' ');
            foreach(string p in pdatastring)
            {
                if (p.Contains("name"))
                {
                    this.name = p.Substring(5);
                }
                if (p.Contains("class"))
                {
                    this.pclass = p.Substring(6);
                }
                if (p.Contains("Str"))
                {
                    string strdata = p.Substring(4);
                    string[] str = strdata.Split('m');
                    this.STR = Convert.ToDouble(str[0]);
                    this.STRm = Convert.ToDouble(str[1]);
                }
                if (p.Contains("Dex"))
                {
                    string dexdata = p.Substring(4);
                    string[] dex = dexdata.Split('m');
                    this.DEX = Convert.ToDouble(dex[0]);
                    this.DEXm = Convert.ToDouble(dex[1]);
                }
                if (p.Contains("Vit"))
                {
                    string vitdata = p.Substring(4);
                    string[] vit = vitdata.Split('m');
                    this.VIT = Convert.ToDouble(vit[0]);
                    this.VITm = Convert.ToDouble(vit[1]);
                }
                if (p.Contains("Agi"))
                {
                    string agidata = p.Substring(4);
                    string[] agi = agidata.Split('m');
                    this.AGI = Convert.ToDouble(agi[0]);
                    this.AGIm = Convert.ToDouble(agi[1]);
                }
                if (p.Contains("Int"))
                {
                    string intdata = p.Substring(4);
                    string[] inte = intdata.Split('m');
                    this.INT = Convert.ToDouble(inte[0]);
                    this.INTm = Convert.ToDouble(inte[1]);
                }
                if (p.Contains("Wis"))
                {
                    string wisdata = p.Substring(4);
                    string[] wis = wisdata.Split('m');
                    this.WIS = Convert.ToDouble(wis[0]);
                    this.WISm = Convert.ToDouble(wis[1]);
                }
                if (p.Contains("helm"))
                {
                    helm = Convert.ToInt32(p.Substring(5));
                }
                if (p.Contains("chest"))
                {
                    chest = Convert.ToInt32(p.Substring(6));
                }
                if (p.Contains("leg"))
                {
                    leg = Convert.ToInt32(p.Substring(4));
                }
                if (p.Contains("glove"))
                {
                    glove = Convert.ToInt32(p.Substring(6));
                }
                if (p.Contains("weapon"))
                {
                    weapon = Convert.ToInt32(p.Substring(7));
                }
                if (p.Contains("cash"))
                {
                    cash = Convert.ToInt32(p.Substring(5));
                }
                if (p.Contains("potion"))
                {
                    potion = p.Substring(7);
                }
                if (p.Contains("exp"))
                {
                    exp = Convert.ToInt32(p.Substring(4));
                }
                if (p.Contains("skill"))
                {
                    skill = Convert.ToInt32(p.Substring(6));
                }
                if (p.Contains("level"))
                {
                    level = Convert.ToInt32(p.Substring(6));
                }
                if (p.Contains("Sp"))
                {
                    SP = Convert.ToInt32(p.Substring(3));
                }
                if (p.Contains("ng"))
                {
                    ng = Convert.ToInt32(p.Substring(3));
                }
                if (p.Contains("position"))
                {
                    string[] posxy = (p.Substring(9)).Split(',');
                    x = Convert.ToInt32(posxy[0]);
                    y = Convert.ToInt32(posxy[1]);
                }
                if (p.Contains("mapseed"))
                {
                    perlinnoise = p.Substring(8);
                }
            }
            #endregion
            //Map Rearranger
            #region Map
            if (File.Exists("newgame.txt"))
            {
                this.ng = 1;
                string result = "";
                foreach (char corrupt in perlinnoise)
                {
                    int rifted = RNG.Next(0, 5);
                    if (rifted == 0)
                    {
                        result = result + 6;
                    }
                    else if (rifted == 1 || rifted == 2)
                    {
                        result = result + 3;
                    }
                    else if (rifted == 3 || rifted == 4)
                    {
                        result = result + 2;
                    }
                    else
                    {
                        result = result + Convert.ToString(corrupt);
                    }
                }
                perlinnoise = result;
                File.Delete("newgame.txt");
                Save();
            }
            string Correctedperlinnoise = "44";
            string MaplayoutCompensation = "141 140 138 139 134 135 136 137 133 132 131 130 129 128 127 126 125 124 123 122 121 120 118 119 114 115 116 117 113 112 111 110 109 108 107 106 105 104 103 102 82 83 84 85 86 87 88 89 90 91 92 93 97 96 95 94 99 98 100 101 62 63 64 65 66 67 68 69 70 71 72 73 77 76 75 74 79 78 80 81 42 43 44 45 46 47 48 49 50 51 52 53 57 56 55 54 59 58 60 61 41 40 38 39 34 35 36 37 33 32 31 30 29 28 27 26 25 24 23 22 21 20 2 3 4 5 6 7 8 9 10 11 15 14 13 12 17 16 18 19";
            string[] TrueMap = MaplayoutCompensation.Split(' ');
            foreach (string TM in TrueMap)
            {
                Correctedperlinnoise = Correctedperlinnoise + perlinnoise[Convert.ToInt32(TrueMap[count])];
                count++;
            }
            //image replaacer
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    PictureBox picturebox = (PictureBox)x;
                    if (counter > 141)
                    {
                        picturebox.Name = "weird" + counter;
                        counter++;
                        continue;
                    }
                    int maplayout = Convert.ToInt32(Correctedperlinnoise[counter]);
                    int rando = RNG.Next(0, 4);
                    switch (maplayout - 48)
                    {
                        case 0:
                            picturebox.Name = "Plains";
                            if (rando == 0)
                            {
                                picturebox.Image = Properties.Resources.Plains1;
                            }
                            else if (rando == 1)
                            {
                                picturebox.Image = Properties.Resources.Plains2;
                            }
                            else
                            {

                            }
                            break;
                        case 1:
                            picturebox.Name = "Forest";
                            if (rando == 0)
                            {
                                picturebox.Image = Properties.Resources.Forest1;
                            }
                            else if (rando == 1)
                            {
                                picturebox.Image = Properties.Resources.Forest2;
                            }
                            else if (rando == 2)
                            {
                                picturebox.Image = Properties.Resources.Forest3;
                            }
                            else if (rando == 3)
                            {
                                picturebox.Image = Properties.Resources.Forest4;
                            }
                            break;
                        case 2:
                            picturebox.Name = "Mounts";
                            if (rando == 0)
                            {
                                picturebox.Image = Properties.Resources.Mount1;
                            }
                            else if (rando == 1)
                            {
                                picturebox.Image = Properties.Resources.Mount2;
                            }
                            else if (rando == 2)
                            {
                                picturebox.Image = Properties.Resources.Mount3;
                            }
                            else if (rando == 3)
                            {
                                picturebox.Image = Properties.Resources.Mount4;
                            }
                            break;
                        case 3:
                            picturebox.Name = "Dungen";
                            picturebox.Image = Properties.Resources.Dungeon;
                            break;
                        case 6:
                            picturebox.Name = "Rift";
                            picturebox.Image = Properties.Resources.Riftup;
                            break;
                    }

                }
                counter++;
            }
            Player.Image = Properties.Resources.stickboi;
            Player.Name = "Player";
            Player.Location = new Point(x, y);
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(battlemode);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            string stats = $"name:{name} class:{pclass} Str:{STR}m{STRm} Dex:{DEX}m{DEXm} Vit:{VIT}m{VITm} Agi:{AGI}m{AGIm} Int:{INT}m{INTm} Wis:{WIS}m{WISm} helm:{helm} chest:{chest} leg:{leg} glove:{glove} weapon:{weapon} potion:{potion} cash:{cash} exp:{exp} Sp:{SP} skill:{skill} level:{level} position:{x},{y} ng:{ng} mapseed:{perlinnoise}";
            File.WriteAllText(playersavefile[(savefilepicked - 1)], stats);
            this.Close();
            thread = new Thread(openmenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void openmenu(object obj)
        {
            Application.Run(new Form_main_menu());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void p31_Click(object sender, EventArgs e)
        {

        }

        private void Realtime_Tick(object sender, EventArgs e) //-------------------------------------------- 100 ms -----------------------
        {
            pictureBox_player.Location = Player.Location;
            Player.Visible = false;
            if (File.Exists("Resume.txt"))
            {
                File.Delete("Resume.txt");
            }
            label_cash_bar.Text = $"Cash: {cash} ඞ";
            difficulty = (level * 5) + weapon + chest + glove + leg + helm;

            if (moving == true)
            {
                amiinbattlemode = 0;
            }
            x = Player.Location.X;
            y = Player.Location.Y;

            // Player Movement 
            if (moveleft == true && Player.Left >= 24)
            {
                Player.Left -= movement;
            }
            if (moveright == true && Player.Left <= 1313)
            {
                Player.Left += movement;
            }
            if (moveup == true && Player.Top >= 94)
            {
                Player.Top -= movement;
            }
            if (movedown == true && Player.Top <= 538)
            {
                Player.Top += movement;
            }

            //Biome Label
            if (biome == "Plains")
            {
                label_biome.Text = "Current Biome: Plains       -Low Threat-";
                movement = 5;
                encounter = RNG.Next(0, 3);//1,2
                encountermeter = 5;
            }
            else if (biome == "Forest")
            {
                label_biome.Text = "Current Biome: Forest       -Medium Threat-";
                movement = 3;
                encounter = RNG.Next(2, 5);//2,3,4
                encountermeter = 10;
            }
            else if (biome == "Mounts")
            {
                label_biome.Text = "Current Biome: Mountain     -High Threat-";
                movement = 1;
                encounter = RNG.Next(4, 8);//4,5,6,7
                encountermeter = 15;
            }
            else if (biome == "Dungen")
            {
                label_biome.Text = "Warning, you're currently on a Dungeon";
                movement = 2;
                encounter = RNG.Next(7, 10);//7,8,9
                encountermeter = 20;
            }
            else if (biome == "Rift")
            {
                label_biome.Text = "Current Biome: ?????";
                movement = 1;
                encounter = 11;
                encountermeter = 15;
            }
            else
            {
                label_biome.Text = "Current Biome: Plains       -Low Threat-";
                movement = 5;
                encounter = RNG.Next(0, 3);//1,2
                encountermeter = 5;
            }
        }
        private void Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                moveup = true;
                moving = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                movedown = true;
                moving = true;
            }
            else if (e.KeyCode == Keys.A)
            {
                moveleft = true;
                moving = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                moveright = true;
                moving = true;
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveup = false;
                moving = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                movedown = false;
                moving = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                moveleft = false;
                moving = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                moveright = false;
                moving = false;
            }
        }

        private void Tickeringdo(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        //x.BackColor = Color.Gray;
                        biome = x.Name;
                    }
                    else
                    {
                        //x.BackColor = Color.White;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
        public void Newstat(double STR, double DEX, double VIT, double AGI, double INT, double WIS)
        {
            this.STR = STR;
            this.DEX = DEX;
            this.VIT = VIT;
            this.AGI = AGI;
            this.INT = INT;
            this.WIS = WIS;
        }
        private void battlemode(object obj)
        {
            Application.Run(new FormBattleMode(difficulty,potion,name, pclass, savefilepicked, cash , HP, MP, Atk, Def, Armor, Speed, special, crit, encounter, biome, x, y, exp, level));
        }
        private void Save()
        {
            string stats = $"name:{name} class:{pclass} Str:{STR}m{STRm} Dex:{DEX}m{DEXm} Vit:{VIT}m{VITm} Agi:{AGI}m{AGIm} Int:{INT}m{INTm} Wis:{WIS}m{WISm} helm:{helm} chest:{chest} leg:{leg} glove:{glove} weapon:{weapon} potion:{potion} cash:{cash} exp:{exp} Sp:{SP} skill:{skill} level:{level} position:{x},{y} ng:{ng} mapseed:{perlinnoise}";
            File.WriteAllText(playersavefile[(savefilepicked - 1)], stats);
        }
        private void button_shop_Click(object sender, EventArgs e)
        {
            FormItem item = new FormItem(cash, savefilepicked ,potion, true);
            item.Show();
        }
        private void mapgenerator()
        {

        }
    }
}
