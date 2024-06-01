using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Diagnostics.Metrics;
using RPG.Class;
using System.Diagnostics;
using RPG.Properties;
using System.Xml.Linq;

namespace RPG
{
    public partial class FormBattleMode : Form
    {
        Thread thread;
        Random RNG = new Random();
        Player playereditor = new Player();
        Skills skillset = new Skills();
        Enemies enemies = new Enemies();

        public int maptype, xx, yy;
        public int cash, exp, level;
        public int rewardcash, rewardexp;

        public string pclass, name, condition, ultimatestat, skillstat, potion;
        public int fHP, fMP, fAtk, fDef, fArmor, fSpeed, fspecial, fcrit, fshield, RHP;
        public double HP, MP, Atk, Def, Armor, Speed, special, crit, shield, lifesteal;
        public double HPi, MPi, Atkm, Defm, Armorm, Speedm, specialm, critm;
        public int burned, poisoned, frozen, dizzy;
        public int guts, fire, ice, elec, poison, charge, frenzy, haste;

        public bool guarded, pause;

        public string ename;
        public int feHP, feMP, feAtk, feDef, feArmor, feSpeed, fespecial, fecrit, feshield, eRHP;
        public double eHP, eAtk, eDef, eArmor, eSpeed, especial, ecrit, eshield, elifesteal;
        public double eHPi, eMPi, eHPm ,eAtkm, eDefm, eArmorm, eSpeedm;
        public int eburned, epoisoned, efrozen, edizzy;
        public int eguts, efire, eice, eelec, epoison, echarge, efrenzy, ehaste;
        public string Eskill1, Eskill2, Eskill3;
        public string Skillname ,EskillName;

        public int encounter, red, rede, difficulty, ulticast, eulticast;
        public double actionspeedplayer, actionspeedenemy, initialspeed, initialspeede, ultibar, eultibar;
        public double progressp, progresse;

        public string idI, idA, idC;// resource picture for enemy
        public Object Image, playeridle, playerattack, playerguard, playerspellself, playerspelltarget, playerpotion;


        public FormBattleMode(int difficulty,string potion,string name,string pclass, int x,int cash, double HP, double MP, double Atk, double Def, double Armor, double Speed, double special, double crit, int encounter, string biome, int posx, int posy, int exp, int level)
        {
            InitializeComponent();
            #region loading
            pictureBox_Background.Controls.Add(pictureBoxplayer);
            pictureBoxplayer.Location = new Point(69, 180);
            pictureBoxplayer.BackColor = Color.Transparent;

            pictureBox_Background.Controls.Add(pictureBoxenemy);
            pictureBoxenemy.Location = new Point(880, 180);
            pictureBoxenemy.BackColor = Color.Transparent;
            this.maptype = x;
            xx = posx;
            yy = posy;
            this.CenterToScreen();

            this.HP = HP;
            this.MP = MP;
            this.Atk = Atk;
            this.Def = Def;
            this.Armor = Armor;
            this.Speed = Speed;
            this.special = special;
            this.crit = crit;
            this.potion = potion;
            this.cash = cash;
            this.difficulty = difficulty;
            pause = false;

            pictureBox_Burned_p.Visible = false;
            pictureBox_Poisoned_p.Visible = false;
            pictureBox_Frozen_p.Visible = false;

            pictureBox_Guts_p.Visible = false;
            pictureBox_Fire_p.Visible = false;
            pictureBox_Ice_p.Visible = false;
            pictureBox_Elec_p.Visible = false;
            pictureBox_Poison_p.Visible = false;

            pictureBox_Up_p.Visible = false;
            pictureBox_Up2_p.Visible = false;
            pictureBox_Up3_p.Visible = false;

            pictureBox_Frenzy_p.Visible = false;

            pictureBox_Dizzy_p.Visible = false;

            pictureBox_Burned_e.Visible = false;
            pictureBox_Poisoned_e.Visible = false;
            pictureBox_Frozen_e.Visible = false;

            pictureBox_Guts_e.Visible = false;
            pictureBox_Fire_e.Visible = false;
            pictureBox_Ice_e.Visible = false;
            pictureBox_Elec_e.Visible = false;
            pictureBox_Poison_e.Visible = false;

            pictureBox_Up_e.Visible = false;
            pictureBox_Up2_e.Visible = false;
            pictureBox_Up3_e.Visible = false;

            pictureBox_Frenzy_e.Visible = false;

            pictureBox_Dizzy_e.Visible = false;

            burned = 0;
            poisoned = 0;
            frozen = 0;
            dizzy = 0;
            guts = 0;
            fire = 0;
            ice = 0;
            elec = 0;
            poison = 0;
            charge = 0;
            frenzy = 0;
            haste = 0;

            eburned = 0;
            epoisoned = 0;
            efrozen = 0;
            edizzy = 0;
            eguts = 0;
            efire = 0;
            eice = 0;
            eelec = 0;
            epoison = 0;
            echarge = 0;
            efrenzy = 0;
            ehaste = 0;

            ulticast = 1;
            eulticast = 1;
            red = 311;
            rede = 311;

            #endregion
            #region loading button
            this.pclass = pclass;

            label_textp.Location = new Point(297, 209);
            label_texte.Location = new Point(827, 209);
            button_ulti.Enabled = false;
            button_attack.Enabled = false;
            button_skill.Enabled = false;
            button_item.Enabled = false;

            this.encounter = encounter;
            string enemy = enemies.Getinfo(encounter);
            #endregion
            #region Enemy Data Extractor

            string[] enemydata = enemy.Split(' ');
            foreach(string ed in enemydata)
            {
                if (ed.Contains("Ename"))
                {
                    ename = Convert.ToString(ed.Substring(6));
                }
                if (ed.Contains("Ehp"))
                {
                    eHP = Convert.ToDouble(ed.Substring(4)) * (1 + (Convert.ToDouble(difficulty) * 2 / 100));
                }
                if (ed.Contains("Eatk"))
                {
                    eAtk = Convert.ToDouble(ed.Substring(5)) * (1 + (Convert.ToDouble(difficulty) * 2 / 100));
                }
                if (ed.Contains("Edef"))
                {
                    eDef = Convert.ToDouble(ed.Substring(5)) * (1 + (Convert.ToDouble(difficulty) * 2 / 100));
                }
                if (ed.Contains("Earm"))
                {
                    eArmor = Convert.ToDouble(ed.Substring(5)) * (1 + (Convert.ToDouble(difficulty) * 2 / 100));
                }
                if (ed.Contains("Espe"))
                {
                    eSpeed = Convert.ToDouble(ed.Substring(5)) * (1 + (Convert.ToDouble(difficulty) * 1 / 100));
                }
                if (ed.Contains("Eskill1"))
                {
                    Eskill1 = ed.Substring(8);
                }
                if (ed.Contains("Eskill2")) 
                {
                    Eskill2 = ed.Substring(8);
                }
                if (ed.Contains("Eskill3"))
                {
                    Eskill3 = ed.Substring(8);
                }
                if (ed.Contains("idI"))
                {
                    idI = ed.Substring(4);
                }
                if (ed.Contains("idA"))
                {
                    idA = ed.Substring(4);
                }
                if (ed.Contains("idC"))
                {
                    idC = ed.Substring(4);
                }
                ecrit = eSpeed/5 + eAtk/10;
                especial = eHP / 10 + eAtk / 2;
            }
            Image = Resources.ResourceManager.GetObject(idI); //-------------------------------RIGHT HERE--------------------------------
            pictureBoxenemy.Image = (Image)Image;
            #endregion
            #region misc
            // Allocator
            this.HPi = HP; this.eHPi = eHP;
            this.MPi = MP; this.eMPi = MP;
            this.Atkm = 1; this.eAtkm = 1;
            this.Defm = 1; this.eDefm = 1;
            this.Armorm = 1; this.eArmorm = 1;
            this.Speedm = 1; this.eSpeedm = 1;
            this.specialm = 1;this.name = name;
            this.critm = 1;this.pclass = pclass;
            this.exp = exp;
            this.level = level;
            playereditor.EditorInt(maptype, "position:", xx, yy);
            fHP = Convert.ToInt32(311 * (HP / HPi));
            feHP = Convert.ToInt32(311 * (eHP / eHPi));

            // Background Picker
            if (biome == "Plains")
            {
                pictureBox_Background.Image = Properties.Resources.battlemode_plain;
            }
            else if (biome == "Forest")
            {
                pictureBox_Background.Image = Properties.Resources.battlemode_forest;
            }
            else if (biome == "Mount")
            {
                pictureBox_Background.Image = Properties.Resources.battlemode_mount;
            }
            else if (biome == "Dungen")
            {
                pictureBox_Background.Image = Properties.Resources.battlemode_dungeon;
            }
            else if (biome == "Rift")
            {
                pictureBox_Background.Image = Properties.Resources.battlemode_rift;
            }
            // Speed Setter
            if ((Speed * Speedm) > (eSpeed * eSpeedm))
            {
                actionspeedplayer = ((Speed * Speedm) / (eSpeed * eSpeedm));
                actionspeedenemy = 1;
            }
            else if ((Speed * Speedm) < (eSpeed * eSpeedm))
            {
                actionspeedplayer = 1;
                actionspeedenemy = ((eSpeed * eSpeedm) / (Speed * Speedm));
            }
            else
            {
                actionspeedplayer = 1;
                actionspeedenemy = 1;
            }
            initialspeed = actionspeedplayer;
            initialspeede = actionspeedenemy;

            //Reward
            rewardexp = Convert.ToInt32(eHP + (eAtk * 5) + (eDef * 4) + (eArmor * 4) + (eSpeed * 10));
            rewardcash = Convert.ToInt32(eHP + (eAtk * 4) + (eDef * 3) + (eArmor * 2) + (eSpeed * 4));

            // Character picture
            string dataextracted = playereditor.GetCharacterPicture(pclass);
            string [] dataprocessed = dataextracted.Split(' ');
            playeridle = Resources.ResourceManager.GetObject(dataprocessed[0]);
            playerattack = Resources.ResourceManager.GetObject(dataprocessed[1]);
            playerguard = Resources.ResourceManager.GetObject(dataprocessed[2]);
            playerspellself = Resources.ResourceManager.GetObject(dataprocessed[3]);
            playerspelltarget = Resources.ResourceManager.GetObject(dataprocessed[4]);
            playerpotion = Resources.ResourceManager.GetObject(dataprocessed[5]);
            pictureBoxplayer.Image = (Image)playeridle;

            

            ultimatestat = skillset.GetSkill(pclass);
            #endregion

        }
        private async void Realtimetick(object sender, EventArgs e) //---------------------------PLAYER AND ENEMY MOVEMENT-------------------------------
        {
            //Idle||
                await Task.Delay(10);
                pictureBoxplayer.Location = new Point(69, 180);
                await Task.Delay(500);
                pictureBoxplayer.Location = new Point(69, 183);

                await Task.Delay(100);
                pictureBoxenemy.Location = new Point(880, 180);
                await Task.Delay(600);
                pictureBoxenemy.Location = new Point(880, 183);
            if (progressp >= 300)//player turn
            {
                button_attack.Enabled = true;
                button_skill.Enabled = true;
                button_item.Enabled = true;
            }
            else
            {
                button_attack.Enabled = false;
                button_skill.Enabled = false;
                button_item.Enabled = false;
            }
            if (progresse >= 305)//enemy turn
            {
                double temp = actionspeedenemy;
                actionspeedenemy = 0;
                int action = RNG.Next(1, 11);
                switch (action)
                {
                    default:
                        Enemyattack();
                        break;
                    case 7:
                        //first skill
                        EnemySkill(Eskill1);
                        break;
                    case 8:
                        //first skill
                        EnemySkill(Eskill1);
                        break;
                    case 10:
                        //second skill
                        EnemySkill(Eskill2);
                        break;
                }
                actionspeedenemy = temp;
            }
        }

        private async void MoveTimerEvent(object sender, EventArgs e) //---------------------------FOR FAST TICK MOVEMENT-------------------------------
        {
            label_Dmgdealt.Text = $"Damage: {Convert.ToInt32(((1 - ((eDef * eDefm) / 100)) * 1) * (((Atk * Atkm) - (eArmor * eArmor * 1)) * 1))}";
            label_MP.Text = $"MP: {Convert.ToInt32(MP)}/{Convert.ToInt32(MPi)}";
            label_debug.Text = $"";//Def: {Def*Defm}  Spe :{progressp} eSpe:{progresse}
            label_HP_val.Text = $"HP : {Convert.ToInt32(HPi)} / {Convert.ToInt32(HP)}";
            label_eHP_val.Text = $"HP : {Convert.ToInt32(eHPi)} / {Convert.ToInt32(eHP)}";
            Double movement = 11;
            int check = 0;
            check++;
            if (progressp < 311)
            {
                progressp = progressp + (actionspeedplayer * 3);
            }
            if (progresse < 311)
            {
                progresse = progresse + (actionspeedenemy * 3);
            }
            panel_speed_p.Size = new Size(Convert.ToInt32(progressp), 23);
            panel_speed_e.Size = new Size(Convert.ToInt32(progresse), 23);

            //Hp bar
            if (panel_HP.Size.Width > panel_redbar.Size.Width)
            {
                red = red + 1;
                panel_redbar.Width = red;
            }
            else if (panel_HP.Size.Width < panel_redbar.Size.Width)
            {
                red = red - 3;
                panel_redbar.Width = red;
            }

            // Enemy Health Bar
            if (panel_eHP.Size.Width > panel_redbare.Size.Width)
            {
                rede = rede + 1;
                panel_redbare.Width = rede;
            }
            else if (panel_eHP.Size.Width < panel_redbare.Size.Width)
            {
                rede = rede - 3;
                panel_redbare.Width = rede;
            }
            
            if(pause == true)
            {
                actionspeedenemy = 0;
                actionspeedplayer = 0;
            }


            //WIN LOSS
            if (eHP <= 0)
            {
                if (eguts > 0)
                {
                    eHP = 1;
                    eguts--;
                }
                else
                {
                    actionspeedplayer = 0;
                    actionspeedenemy = 0;
                    Blinkingp();
                    condition = "win";
                    await Task.Delay(1150);
                    this.Close();
                    thread = new Thread(winloss);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
            if (HP <= 0)
            {
                if (guts > 0)
                {
                    HP = 1;
                    guts--;
                }
                else
                {
                    actionspeedplayer = 0;
                    actionspeedenemy = 0;
                    Blinkinge();
                    condition = "lost";
                    await Task.Delay(1150);
                    this.Close();
                    thread = new Thread(winloss);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
        }
        private void StatuesAilmentTick(object sender, EventArgs e) //---------------------------STATUES AILMENT AND EFFECTS-------------------------------
        {
            int durationdeplete = 1;
            //if (progressp < 311 && progresse < 311)
            //{
            //    durationdeplete = 0;
            //}
            //else
            //{
            //    durationdeplete = 1;
            //}
            // duration
            #region player buff and debuff
            //Player Debuff


                if (lifesteal > 0 && pause == false)
                {
                    lifesteal -= durationdeplete;
                    pictureBox_ls.Visible = true;
                }
                else
                {
                    pictureBox_ls.Visible = false;
                }
                if (burned > 0 && pause == false)
                {
                    HP -= durationdeplete;
                    burned -= durationdeplete;
                    pictureBox_Burned_p.Visible = true;
                }
                else
                {
                    pictureBox_Burned_p.Visible = false;
                }
                if (poisoned > 0 && pause == false)
                {
                    HP -= durationdeplete * 3;
                    poisoned -= durationdeplete;
                    pictureBox_Poisoned_p.Visible = true;
                }
                else
                {
                    pictureBox_Poisoned_p.Visible = false;
                }
                if (frozen > 0 && pause == false)
                {
                    frozen -= durationdeplete;
                    pictureBox_Frozen_p.Visible = true;
                }
                else
                {
                    pictureBox_Frozen_p.Visible = false;
                }
                if (dizzy > 0 && pause == false)
                {
                    dizzy -= durationdeplete;
                    pictureBox_Dizzy_p.Visible = true;
                }
                else
                {
                    pictureBox_Dizzy_p.Visible = false;
                }
                // Player Buff
                if (fire > 0 && pause == false)
                {
                    fire -= durationdeplete;
                    pictureBox_Fire_p.Visible = true;
                }
                else
                {
                    pictureBox_Fire_p.Visible = false;
                }
                if (elec > 0 && pause == false)
                {
                    elec -= durationdeplete;
                    pictureBox_Elec_p.Visible = true;
                }
                else
                {
                    pictureBox_Elec_p.Visible = false;
                }
                if (ice > 0 && pause == false)
                {
                    ice -= durationdeplete;
                    pictureBox_Ice_p.Visible = true;
                }
                else
                {
                    pictureBox_Ice_p.Visible = false;
                }
                if (poison > 0 && pause == false)
                {
                    poison -= durationdeplete;
                    pictureBox_Poison_p.Visible = true;
                }
                else
                {
                    pictureBox_Poison_p.Visible = false;
                }
                if (frenzy > 0 && pause == false)
                {
                    frenzy -= durationdeplete;
                    pictureBox_Frenzy_p.Visible = true;
                }
                else
                {
                    pictureBox_Frenzy_p.Visible = false;
                }
                if (haste > 0 && pause == false)
                {
                    haste -= durationdeplete;
                    pictureBox_Haste_p.Visible = true;
                }
                else if (haste <= 0 && pause == false)
                {
                    pictureBox_Haste_p.Visible = false;
                }
            #endregion
            #region enemy buff and debuff
            //Enemy Debuff

                if (elifesteal > 0 && pause == false)
                {
                    elifesteal -= durationdeplete;
                    pictureBox_els.Visible = true;
                }
                else
                {
                    pictureBox_els.Visible = false;
                }
                if (eburned > 0 && pause == false)
                {
                    eHP -= durationdeplete;
                    eburned -= durationdeplete;
                    pictureBox_Burned_e.Visible = true;
                }
                else
                {
                    pictureBox_Burned_e.Visible = false;
                }
                if (epoisoned > 0 && pause == false)
                {
                    eHP -= durationdeplete * 3;
                    epoisoned -= durationdeplete;
                    pictureBox_Poisoned_e.Visible = true;
                }
                else
                {
                    pictureBox_Poisoned_e.Visible = false;
                }
                if (efrozen > 0 && pause == false)
                {
                    efrozen -= durationdeplete;
                    pictureBox_Frozen_e.Visible = true;
                }
                else
                {
                    pictureBox_Frozen_e.Visible = false;
                }
                if (edizzy > 0 && pause == false)
                {
                    edizzy -= durationdeplete;
                    pictureBox_Dizzy_e.Visible = true;
                }
                else
                {
                    pictureBox_Dizzy_e.Visible = false;
                }
                // Enemy Buff
                if (efire > 0 && pause == false)
                {
                    efire -= durationdeplete;
                    pictureBox_Fire_e.Visible = true;
                }
                else
                {
                    pictureBox_Fire_e.Visible = false;
                }
                if (eelec > 0 && pause == false)
                {
                    eelec -= durationdeplete;
                    pictureBox_Elec_e.Visible = true;
                }
                else
                {
                    pictureBox_Elec_e.Visible = false;
                }
                if (eice > 0 && pause == false)
                {
                    eice -= durationdeplete;
                    pictureBox_Ice_e.Visible = true;
                }
                else
                {
                    pictureBox_Ice_e.Visible = false;
                }
                if (epoison > 0 && pause == false)
                {
                    epoison -= durationdeplete;
                    pictureBox_Poison_e.Visible = true;
                }
                else
                {
                    pictureBox_Poison_e.Visible = false;
                }
                if (efrenzy > 0 && pause == false)
                {
                    efrenzy -= durationdeplete;
                    pictureBox_Frenzy_e.Visible = true;
                }
                else
                {
                    pictureBox_Frenzy_e.Visible = false;
                }
                if (ehaste > 0 && pause == false)
                {
                    ehaste -= durationdeplete;
                    pictureBox_Haste_e.Visible = true;
                }
                else if (ehaste <= 0 && pause == false)
            {
                    pictureBox_Haste_e.Visible = false;
                }
            #endregion
            // effect
            #region player Ailment Effects
            if (dizzy > 0)
            {
                Defm = 0.75;
                Speedm = 0.75;
            }
            if (burned > 0)
            {
                Defm = 0.75;
            }
            else
            {
                Defm = 1;
            }
            if (poisoned > 0)
            {
                Armorm = 0.75;
            }
            else
            {
                Armorm = 1;
            }
            if (frozen > 0)
            {
                actionspeedplayer = initialspeed/2;
            }
            else
            {
                actionspeedplayer = initialspeed;
            }
            if (frenzy > 0)
            {
                Atkm = 2;
                Speedm = 1.3;
                Defm = 0.5;
            }
            else
            {
                Atkm = 1;
                Speedm = 1;
                Defm = 1;
            }
            if (haste > 0 && pause == false)
            {
                actionspeedplayer = initialspeed * 4;
            }
            else if (pause == true)
            {
                actionspeedplayer = 0;
                actionspeedenemy = 0;
            }
            else
            {
                if ((Speed * Speedm) > (eSpeed * eSpeedm))
                {
                    actionspeedplayer = ((Speed * Speedm) / (eSpeed * eSpeedm));
                    actionspeedenemy = 1;
                }
                else if ((Speed * Speedm) < (eSpeed * eSpeedm))
                {
                    actionspeedplayer = 1;
                    actionspeedenemy = ((eSpeed * eSpeedm) / (Speed * Speedm));
                }
                else
                {
                    actionspeedplayer = 1;
                    actionspeedenemy = 1;
                }
            }
            #endregion
            #region enemy Ailment Effects
            if (edizzy > 0)
            {
                eDefm = 0.75;
                eSpeedm = 0.75;
            }
            if (eburned > 0)
            {
                eDefm = 0.75;
            }
            else
            {
                eDefm = 1;
            }
            if (epoisoned > 0)
            {
                eArmorm = 0.75;
            }
            else
            {
                eArmorm = 1;
            }
            if (efrozen > 0)
            {
                actionspeedenemy = initialspeede/2;
            }
            else
            {
                actionspeedenemy = initialspeede;
            }
            if (efrenzy > 0)
            {
                eAtkm = 2;
                eSpeedm = 1.3;
                eDefm = 0.5;
            }
            else
            {
                eAtkm = 1;
                eSpeedm = 1;
                eDefm = 1;
            }
            if (ehaste > 0 && pause == false)
            {
                actionspeedenemy = initialspeede * 4;
            }
            else if (pause == true)
            {
                actionspeedplayer = 0;
                actionspeedenemy = 0;
            }
            else
            {
                if ((Speed * Speedm) > (eSpeed * eSpeedm))
                {
                    actionspeedplayer = ((Speed * Speedm) / (eSpeed * eSpeedm));
                    actionspeedenemy = 1;
                }
                else if ((Speed * Speedm) < (eSpeed * eSpeedm))
                {
                    actionspeedplayer = 1;
                    actionspeedenemy = ((eSpeed * eSpeedm) / (Speed * Speedm));
                }
                else
                {
                    actionspeedplayer = 1;
                    actionspeedenemy = 1;
                }
            }
            #endregion
            HPupdater();
            Statsupdator();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            condition = "run";
            Finish();
            //playereditor.EditorInt(maptype, "position:", xx, yy);
            //playereditor.EditorInt(maptype, "cash:", cash, 0);
            //playereditor.EditorInt(maptype, "exp:", exp, 0);
            //this.Close();
            //thread = new Thread(game);
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {

        }
        private void game(object obj)
        {
            Application.Run(new FormGame(maptype));
        }
        private void pictureBox_Fire_p_Click(object sender, EventArgs e)
        {

        }
        private async void button_guard_Click(object sender, EventArgs e)
        {
            if (progressp > 40)
            {
                progressp = progressp - 40;
                button_guard.Enabled = false;
                Def = Def + 50;
                Textpop("player", "Guard Up");
                guarded = true;
                pictureBoxplayer.Image = (Image)playerguard;
                await Task.Delay(1000);
                pictureBoxplayer.Image = (Image)playeridle;
                button_guard.Enabled = true;
                await Task.Delay(500);
                guarded = false;
                Def = Def - 50;
            }
        }
        private async void button_attack_Click(object sender, EventArgs e)
        {
            Blinkingp();
            pictureBoxplayer.Location = new Point(639, 180);
            pictureBoxplayer.Image = (Image)playerattack;
            await Task.Delay(50);
            pictureBoxplayer.Location = new Point(669, 180);
            await Task.Delay(50);
            pictureBoxplayer.Location = new Point(679, 180);
            await Task.Delay(500);
            Blinkingp();
            pictureBoxplayer.Image = (Image)playeridle;
            pictureBoxplayer.Location = new Point(69, 180);
            DamageCalculator("player", "normal", 0);
            progressp = 0;
            Blinkinge();
        }
        private async void Blinkingp()
        {
            pictureBoxplayer.Visible = false;
            await Task.Delay(50);
            pictureBoxplayer.Visible = true;
            await Task.Delay(50);
            pictureBoxplayer.Visible = false;
            await Task.Delay(50);
            pictureBoxplayer.Visible = true;
            await Task.Delay(50);
            pictureBoxplayer.Visible = false;
            await Task.Delay(50);
            pictureBoxplayer.Visible = true;
        }
        private async void Blinkinge()
        {
            pictureBoxenemy.Visible = false;
            await Task.Delay(50);
            pictureBoxenemy.Visible = true;
            await Task.Delay(50);
            pictureBoxenemy.Visible = false;
            await Task.Delay(50);
            pictureBoxenemy.Visible = true;
            await Task.Delay(50);
            pictureBoxenemy.Visible = false;
            await Task.Delay(50);
            pictureBoxenemy.Visible = true;
        }
        private void DamageCalculator(string attacker,string type, double spellpower) //------------------------------ATK FORMULA--------------------------------
        {
            if (crit > 100)
            {
                crit = 100;
            }
            if (ecrit > 100)
            {
                ecrit = 100;
            }
            double damageresult = 0;
            double critchance = RNG.Next(1, 101);
            double powerupelement = 1;
            double epowerupelement = 1;
            double almightyelement = 1;
            if (type == "almighty")
            {
                almightyelement = 0;
            }
            if (charge > 0)
            {
                powerupelement = powerupelement + charge;
                charge = 0;
            }
            if (echarge > 0)
            {
                epowerupelement = epowerupelement + echarge;
                echarge = 0;
            }
            if ((crit*critm) > critchance)
            {
                powerupelement = powerupelement + 2.5;
                Textpop("player", "Critical Hit");
            }
            if ((ecrit) > critchance)
            {
                epowerupelement = epowerupelement + 2.5;
                Textpop("enemy", "Critical Hit");
            }
            // Normal Attack
            if (spellpower == 0)
            {

            }
            if (attacker == "player")
            {
                damageresult = (((1 - ((eDef * eDefm)/ 100)) * almightyelement) * (((Atk * Atkm) - (eArmor * eArmorm * almightyelement))* powerupelement));
                if (eshield > 0)
                {
                    eshield = eshield - damageresult;
                    if (shield <= 0)
                    {
                        eHP = eHP + shield;
                    }
                    ultibar = ultibar + damageresult * 1 / ulticast;
                    eultibar = eultibar + damageresult * 2 / eulticast;
                }
                else
                {
                    this.eHP = eHP - damageresult;
                    ultibar = ultibar + damageresult * 1 / ulticast;
                    eultibar = eultibar + damageresult * 4 / eulticast;
                }
            }
            else if (attacker == "enemy")
            {

                damageresult = (((1 - ((Def * Defm) / 100)) * almightyelement) * (((eAtk * eAtkm) - (Armor * Armorm * almightyelement)) * epowerupelement));
                if (shield > 0)
                {
                    shield = shield - damageresult;
                    if (shield <= 0)
                    {
                        HP = HP + shield;
                    }
                    ultibar = ultibar + damageresult * 2 / ulticast;
                    eultibar = eultibar + damageresult * 1 / eulticast;
                }
                else
                {
                    this.HP = HP - damageresult;
                    ultibar = ultibar + damageresult * 4/ulticast;
                    eultibar = eultibar + damageresult * 1 / eulticast;
                }
                
            }
            double HPgain = 0;
            if (lifesteal > 0)
            {
                HP = HP + damageresult;
                if (HP > HPi)
                {
                    HP = HPi;
                }
            }
            if (elifesteal > 0)
            {
                eHP = eHP + damageresult;
                if (eHP > eHPi)
                {
                    eHP = eHPi;
                }
            }
            HPupdater();
        }
        private async void tenthsecondtick(object sender, EventArgs e)// -------------------------------------------------A SIGHTLY FASTER TICK-----------------------------
        {
            panel_ultibar.Size = new Size(34, Convert.ToInt32(ultibar));
            panel_eultibar.Size = new Size(34, Convert.ToInt32(eultibar));
            // natural ultimate bar regen
            if (ultibar < 455 && progressp < 311 && progresse < 311 && pause == false)
            {
                ultibar = ultibar + 0.2;
            }
            if (eultibar < 455 && progressp < 311 && progresse < 311 && pause == false)
            {
                eultibar = eultibar + 0.2;
            }
            // ULTIMATE
            if (ultibar >= 454 && progressp < 311 && progresse < 311)
            {
                button_ulti.Text = "Ultimate";
                button_ulti.Enabled = true;
            }
            else
            {
                button_ulti.Text = "Locked";
                button_ulti.Enabled = false;
            }
            if (eultibar >= 454)
            {
                eultibar = 0;
                EnemySkill(Eskill3);
            }
            // Spell Caster
            if (File.Exists("TempSkill.txt"))
            {
                pause = false;
                progressp = progressp - 200;
                skillstat = File.ReadAllText("TempSkill.txt");
                File.Delete("TempSkill.txt");
                Blinkingp();
                if (skillstat.Contains("dmg"))
                {
                    pictureBoxplayer.Image = (Image)playerspelltarget;
                }
                else
                {
                    pictureBoxplayer.Image = (Image)playerspellself;
                }
                Skill("player", skillstat);
                await Task.Delay(450);
                pictureBoxplayer.Image = (Image)playeridle;
                Blinkingp();
            }
            if (File.Exists("Resume.txt"))
            {
                pause = false;
                File.Delete("Resume.txt");
            }
            if (File.Exists("Update.txt"))
            {
                string [] Yeees = File.ReadAllText("Update.txt").Split(' ');
                if (Yeees[1].Contains("HP"))
                {
                    HP = HP - Convert.ToInt32(Yeees[0]);
                    HPupdater();
                }
                else if (Yeees[1].Contains("MP"))
                {
                    MP = MP - Convert.ToInt32(Yeees[0]);
                }
                else
                {
                    cash = cash - Convert.ToInt32(Yeees[0]);
                }
                File.Delete("Update.txt");
            }
            if (File.Exists("Tempitem.txt"))
            {
                progressp = progressp - 150;
                skillstat = File.ReadAllText("Tempitem.txt");
                File.Delete("Tempitem.txt");
                Blinkingp();
                pictureBoxplayer.Image = (Image)playerpotion;
                Skill("player", skillstat);
                await Task.Delay(450);
                pictureBoxplayer.Image = (Image)playeridle;
                Blinkingp();
            }
        }
        private void Skill(string caster, string data)//-----------------------------------SKILL RELEASE----------------------------------
        {
            List<string> effect = new List<string>();
            List<string> effectduration = new List<string>();

            int Rng = RNG.Next(1, 101);
            string [] detail = data.Split(',');
            Skillname = detail[0].Replace("_"," ");
            double value = 0; // based number or time (in seconds)
            string type = detail[2]; //type of attack, buff, or debuff
            // 0 = Name of Spell    1 = Type of Spell   2 = Type of Attack      3 = Value of Spell

            if (detail[1].Contains("buf") || detail[1].Contains("dbf"))
            {
                if (detail[2].Contains('-'))
                {
                    string[]tempp = detail[2].Split('-');
                    string[] temppd = detail[3].Split('-');
                    effect.AddRange(tempp);
                    effectduration.AddRange(temppd);
                }
                else
                {
                    effect.Add(detail[2]);
                }
            }
            else
            {
                value = Convert.ToDouble(detail[3]);
            }

            if (caster == "player")
            {
                switch (detail[1])
                {
                    // --------------------------------------------TYPE MAGIC : DAMAGE SPELL---------------------------------------------
                    case "dmg":
                        switch (type)
                        {
                            case "fire":
                                if(Rng < 41)
                                {
                                    eburned = 10;
                                }
                                this.eHP = eHP - (value + special);
                                break;
                            case "ice":
                                if (Rng < 41)
                                {
                                    efrozen = 10;
                                }
                                this.eHP = eHP - (value + special);
                                break;
                            case "elec":
                                if (Rng < 41)
                                {
                                    edizzy = 10;
                                }
                                this.eHP = eHP - (value + special);
                                break;
                            case "poison":
                                if (Rng < 41)
                                {
                                    epoisoned= 10;
                                }
                                this.eHP = eHP - (value + special);
                                break;
                            case "almighty":
                                this.eHP = eHP - ((value + special) * 2);
                                break;
                            default:
                                this.eHP = eHP - (value + special);
                                break;
                        }
                        break;
                    // --------------------------------------------TYPE MAGIC : HEAL SPELL---------------------------------------------
                    case "hel":
                        switch (type)
                        {
                            case "normal":
                                double maxehp;
                                maxehp = HP + (value + special);
                                if (maxehp > HP)
                                {
                                    HP = HPi;
                                }
                                else
                                {
                                    HP = HP + (value + special);
                                }
                                break;
                            case "shield":
                                shield = shield + value + special;
                                break;
                        }
                        break;
                    // --------------------------------------------TYPE MAGIC : BUFF SPELL---------------------------------------------
                    case "buf":
                        for(int i = 0; i < effect.Count; i++)
                        {
                            if (effect[i] == "lifesteal")
                            {
                                lifesteal = lifesteal + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "fire")
                            {
                                fire = fire + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "ice")
                            {
                                ice = ice + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "elec")
                            {
                                elec = elec + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "poison")
                            {
                                poison = poison + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "guts")
                            {
                                guts = guts + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "frenzy")
                            {
                                frenzy = frenzy + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "charge")
                            {
                                charge = charge + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "haste")
                            {
                                haste = haste + Convert.ToInt32(effectduration[i]);
                            }
                        }
                        break;
                    // --------------------------------------------TYPE MAGIC : DAMAGE SPELL---------------------------------------------
                    case "dbf":
                        for (int i = 0; i < effect.Count; i++)
                        {
                            if (effect[i] == "burned")
                            {
                                eburned = eburned + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "dizzy")
                            {
                                edizzy = edizzy + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "frozen")
                            {
                                efrozen = efrozen + Convert.ToInt32(effectduration[i]);
                            }
                            if (effect[i] == "poisoned")
                            {
                                epoisoned = epoisoned + Convert.ToInt32(effectduration[i]);
                            }
                        }
                        break;
                }
                Textpop(caster, Skillname + " Casted");
                HPupdater();
                progressp = 0;
            }
            else if (caster == "enemy")
            {
                // --------------------------------------------TYPE MAGIC : DAMAGE SPELL---------------------------------------------
                
                if (detail[1].Contains("dmg"))
                {
                    if (detail[2].Contains("normal"))
                    {
                        HP = HP - (value + especial);
                    }
                    else if (detail[2].Contains("fire"))
                    {
                        if (Rng < 41)
                        {
                            burned = 10;
                        }
                        HP = HP - (value + especial);
                    }
                    else if (detail[2].Contains("ice"))
                    {
                        if (Rng < 41)
                        {
                            frozen = 10;
                        }
                        HP = HP - (value + especial);
                    }
                    else if (detail[2].Contains("elec"))
                    {
                        if (Rng < 41)
                        {
                            dizzy = 10;
                        }
                        HP = HP - (value + especial);
                    }
                    else if (detail[2].Contains("poison"))
                    {
                        if (Rng < 41)
                        {
                            poisoned = 10;
                        }
                        HP = HP - (value + especial);
                    }
                    else if (detail[2].Contains("almighty"))
                    {
                        HP = HP - ((value + especial) * 2);
                    }
                    else
                    {
                        HP = HP - (value + especial);
                    }
                    Blinkingp();
                }
                // --------------------------------------------TYPE MAGIC : HEAL SPELL---------------------------------------------
                if (detail[1].Contains("hel"))
                {
                    if (detail[2].Contains("normal"))
                    {
                        double HPGain;
                        HPGain = value + especial;
                        if ((HPGain+eHP) > eHP)
                        {
                            eHP = eHPi;
                        }
                        else
                        {
                            eHP = eHP + HPGain;
                        }
                    }
                    else if (detail[2].Contains("almighty"))
                    {
                        eshield = eshield + (value + especial * 2);
                    }
                }
                // --------------------------------------------TYPE MAGIC : BUFF SPELL---------------------------------------------
                if (detail[1].Contains("buf"))
                {
                    for (int i = 0; i < effect.Count; i++)
                    {
                        if (effect[i] == "lifesteal")
                        {
                            elifesteal = elifesteal + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "fire")
                        {
                            efire = efire + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "ice")
                        {
                            eice = eice + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "elec")
                        {
                            eelec = eelec + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "poison")
                        {
                            epoison = epoison + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "guts")
                        {
                            eguts = eguts + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "frenzy")
                        {
                            efrenzy = efrenzy + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "charge")
                        {
                            echarge = echarge + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "haste")
                        {
                            ehaste = ehaste + Convert.ToInt32(effectduration[i]);
                        }
                    }
                }
                // --------------------------------------------TYPE MAGIC : DEBUFF SPELL---------------------------------------------
                if (detail[1].Contains("dbf"))
                {
                    for (int i = 0; i < effect.Count; i++)
                    {
                        if (effect[i] == "burned")
                        {
                            burned = burned + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "dizzy")
                        {
                            dizzy = dizzy + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "frozen")
                        {
                            frozen = frozen + Convert.ToInt32(effectduration[i]);
                        }
                        if (effect[i] == "poisoned")
                        {
                            poisoned = poisoned + Convert.ToInt32(effectduration[i]);
                        }
                    }
                    Blinkingp();
                }
                Textpop(caster, Skillname + " Casted");
                HPupdater();
                progresse = 0;
            }
        }
        private async void button_skill_Click(object sender, EventArgs e)
        {
            pause = true;
            FormSkill spellcast = new FormSkill(maptype, level, HP, MP, HPi, MPi, cash, pclass);
            spellcast.Show();
        }
        private void button_analyze_Click(object sender, EventArgs e)
        {
            File.WriteAllText("newgame.txt", "");
            if (pause == true)
            {
                pause = false;
            }
            else if (pause == false)
            {
                pause = true;
            }
            //MessageBox.Show(efrenzy.ToString());
            //HPupdater();
            //Finish();
        }
        private void HPupdater()
        {
            fHP = Convert.ToInt32(311 * (HP / HPi));
            feHP = Convert.ToInt32(311 * (eHP / eHPi));
            panel_HP.Size = new Size(fHP, 23);
            panel_eHP.Size = new Size(feHP, 23);
        }
        private async void Enemyattack()//-------------------------------------------------ALL ENEMY ACTION------------------------------------------
        {
            progresse = 0;
            Blinkinge();
            pictureBoxenemy.Location = new Point(335, 180);
            Image = Resources.ResourceManager.GetObject(idA);
            pictureBoxenemy.Image = (Image)Image;
            await Task.Delay(50);
            pictureBoxenemy.Location = new Point(305, 180);
            await Task.Delay(50);
            pictureBoxenemy.Location = new Point(295, 180);
            await Task.Delay(500);
            Blinkinge();
            Image = Resources.ResourceManager.GetObject(idI);
            pictureBoxenemy.Image = (Image)Image;
            pictureBoxenemy.Location = new Point(880, 180);
            DamageCalculator("enemy", "normal", 0);
            Blinkingp();
        }
        private async void EnemySkill(string CastedSkill)
        {
            progresse = 0;
            Blinkinge();
            await Task.Delay(50);
            Image = Resources.ResourceManager.GetObject(idC);
            pictureBoxenemy.Image = (Image)Image;
            await Task.Delay(450);
            Image = Resources.ResourceManager.GetObject(idI);
            pictureBoxenemy.Image = (Image)Image;
            await Task.Delay(50);
            Blinkinge();
            Skill("enemy", CastedSkill);

        }
        private void BarColorUpdater(object sender, EventArgs e) //----------------------------------------BAR COLOR------------------------------------------
        {

        }
        private void Finish()
        {
            playereditor.EditorInt(maptype, "position:", xx, yy);
            playereditor.EditorInt(maptype, "cash:", cash, 0);
            playereditor.EditorInt(maptype, "exp:", exp, 0);
            this.Close();
            thread = new Thread(winloss);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void winloss(object obj)
        {
            Application.Run(new FormWinLoss(maptype, condition, exp, level, cash, rewardcash, rewardexp, pclass, name, ename));
        }
        private void pictureBox_Background_Click(object sender, EventArgs e)
        {

        }
        private void PSkill()
        {
            this.Close();
            thread = new Thread(PSkills);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void PSkills(object obj)
        {
            Application.Run(new FormSkill(maptype, level, HP, MP, HPi, MPi, cash, pclass));
        }

        private void button_ulti_Click(object sender, EventArgs e)
        {

        }
        private void Statsupdator()//----------------------------STATS THAT ARE NOT TIME BASED-----------------------------
        {
            if (charge > 0)
            {
                pictureBox_Up_p.Visible = true;
                pictureBox_Up2_p.Visible = true;
                pictureBox_Up3_p.Visible = true;
            }
            else
            {
                pictureBox_Up_p.Visible = false;
                pictureBox_Up2_p.Visible = false;
                pictureBox_Up3_p.Visible = false;
            }
            if (guts > 0)
            {
                pictureBox_Guts_p.Visible = true;
            }
            else
            {
                pictureBox_Guts_p.Visible = false;
            }
            if (echarge > 0)
            {
                pictureBox_Up_e.Visible = true;
                pictureBox_Up2_e.Visible = true;
                pictureBox_Up3_e.Visible = true;
            }
            else
            {
                pictureBox_Up_e.Visible = false;
                pictureBox_Up2_e.Visible = false;
                pictureBox_Up3_e.Visible = false;
            }
            if (eguts > 0)
            {
                pictureBox_Guts_e.Visible = true;
            }
            else
            {
                pictureBox_Guts_e.Visible = false;
            }
        }
        private async void Textpop(string side, string text)//-----------------------GENERAL POP UP TEXT-------------------------------
        {
            label_textp.Location = new Point(297, 219);
            label_texte.Location = new Point(827, 219);
            if (side == "player")
            {
                label_textp.Text = text;
                label_textp.Visible = true;
                label_textp.Location = new Point(297, 214);
                await Task.Delay(41);
                label_textp.Location = new Point(297, 209);
                await Task.Delay(41);
                label_textp.Location = new Point(297, 199);
                await Task.Delay(41);
                label_textp.Location = new Point(297, 179);
                await Task.Delay(300);
                label_textp.Visible = false;
                await Task.Delay(100);
                label_textp.Visible = true;
                await Task.Delay(100);
                label_textp.Visible = false;
                await Task.Delay(100);
                label_textp.Visible = true;
                await Task.Delay(100);
                label_textp.Visible = false;
            }
            if (side == "enemy")
            {
                label_texte.Text = text;
                label_texte.Visible = true;
                label_texte.Location = new Point(827, 214);
                await Task.Delay(100);
                label_texte.Location = new Point(827, 209);
                await Task.Delay(100);
                label_texte.Location = new Point(827, 199);
                await Task.Delay(100);
                label_texte.Location = new Point(827, 179);
                await Task.Delay(300);
                label_texte.Visible = false;
                await Task.Delay(100);
                label_texte.Visible = true;
                await Task.Delay(100);
                label_texte.Visible = false;
                await Task.Delay(100);
                label_texte.Visible = true;
                await Task.Delay(100);
                label_texte.Visible = false;
            }
        }
        private void button_item_Click(object sender, EventArgs e)
        {
            pause = true;
            FormItem potionuse = new FormItem(cash,maptype,potion,false);
            potionuse.Show();
        }
    }
}
