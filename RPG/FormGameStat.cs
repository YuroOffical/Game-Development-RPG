using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RPG
{
    public partial class FormGameStat : Form
    {
        public string name;
        public string pclass;
        public double STR, DEX, VIT, AGI, INT, WIS;
        public double STRm, DEXm, VITm, AGIm, INTm, WISm;
        public double HP, mana, Atk, Def, Armor, Speed, special, crit;

        private void label_hp_Click(object sender, EventArgs e)
        {

        }

        private void button_skill_Click(object sender, EventArgs e)
        {
            FormSkill fs = new FormSkill(99,level,HP,mana,HP, mana, cash,pclass);
            fs.Show();
        }

        public int helm, chest, leg, glove, weapon;
        public int cash, exp, level, SP;
        public int savefilepicked;

        private void button_agi_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                AGI++;
                SP--;
            }
            
        }

        private void button_int_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                INT++;
                SP--;
            }
            
        }

        private void button_wis_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                WIS++;
                SP--;
            }
        }

        private void button_vit_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                VIT++;
                SP--;
            }
        }

        private void button_dex_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                DEX++;
                SP--;
            }
        }


        private void button_str_Click(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                STR++;
                SP--;
            }
        }

        
        public FormGameStat(string name, string pclass, int cash, int exp,int level, double STR, double DEX, double VIT, double AGI, double INT, double WIS, double STRm, double DEXm, double VITm, double AGIm, double INTm, double WISm, double HP, double mana, double Atk, double Def, double Armor, double Speed, double special, double crit, int SP, int helm, int chest, int leg, int  glove, int weapon, int savefilepicked)
        {
            InitializeComponent();
            this.name = name;
            this.pclass = pclass;
            this.cash = cash;
            this.level = level;
            this.SP = SP;
            this.exp = exp;

            this.DEX = DEX;
            this.STR = STR;
            this.VIT = VIT;
            this.AGI = AGI;
            this.INT = INT;
            this.WIS = WIS;

            this.STRm = STRm;
            this.DEXm = DEXm;
            this.VITm = VITm;
            this.AGIm = AGIm;
            this.INTm = INTm;
            this.WISm = WISm;

            this.helm = helm;
            this.chest = chest;
            this.leg = leg;
            this.glove = glove;
            this.weapon = weapon;

            this.savefilepicked = savefilepicked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = $"{STR} {DEX} {VIT} {AGI} {INT} {WIS} {SP}";
            File.WriteAllText("TempStat.txt",data);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Realtimetick(object sender, EventArgs e)
        {
            if (SP != 0)
            {
                button_str.Visible = true;
                button_dex.Visible = true;
                button_vit.Visible = true;
                button_agi.Visible = true;
                button_int.Visible = true;
                button_wis.Visible = true;
            }
            else
            {
                button_str.Visible = false;
                button_dex.Visible = false;
                button_vit.Visible = false;
                button_agi.Visible = false;
                button_int.Visible = false;
                button_wis.Visible = false;
            }



            HP = ((STR * STRm) * 5) + ((VIT * VITm) * 10) + (chest * 5) + (helm * 2) + 30;
            mana = ((INT * INTm) * 10) + ((WIS * WISm) * 3) + ((DEX * DEXm) * 1);
            Atk = ((STR * STRm) * 1) + ((DEX * DEXm) * 2) + (weapon * 2) + glove;
            Def = (((STR * STRm) * 1) + ((VIT * VITm) * 1) + (chest / 5) + (glove / 5))/2;
            Armor = ((VIT * VITm) + chest + glove + helm) / 5;
            Speed = (((AGI * AGIm) * 4) + ((DEX * DEXm) * 2) + weapon + leg * 2)/4;
            special = ((INT * INTm) * 5) + ((WIS * WISm) * 3);
            crit = ((AGI * AGIm) * 1) + ((WIS * WISm) * 2);

            // stat modifier

            label_name.Text = "Name : " + name.Replace('_',' ');
            label_cash.Text = "Cash : " + cash.ToString() + " ඞ";
            label_level.Text = "Level : " + level.ToString();
            label_class.Text = "Class : " + pclass;

            label_str.Text = "STR : " + STR.ToString();
            label_dex.Text = "DEX : " + DEX.ToString();
            label_vit.Text = "VIT : " + VIT.ToString();
            label_agi.Text = "AGI : " + AGI.ToString();
            label_int.Text = "INT : " + INT.ToString();
            label_wis.Text = "WIS : " + WIS.ToString();

            int levellimit = (level * 200) + 800;
            label_hp.Text = "HP : " + Convert.ToInt32(HP).ToString();
            label_xp.Text = "XP : " + exp.ToString() + "/" + levellimit.ToString();
            label_Mana.Text = "Mana : " + Convert.ToInt32(mana).ToString();
            label_attack.Text = "Attack Power : " + Convert.ToInt32(Atk).ToString();
            label_defense.Text = "Defense : " + Convert.ToInt32(Def).ToString() + "%";
            label_armor.Text = "Armor : " + Convert.ToInt32(Armor).ToString() + " Negated Damage";
            label_speed.Text = "Speed : " + Convert.ToInt32(Speed).ToString();
            label_special.Text = "Special Amplifier : " + Convert.ToInt32(special).ToString();
            label_crit.Text = "Critical Chance : " + Convert.ToInt32(crit).ToString() + "%";

            label_sp.Text = "Available Skill point : " + SP;

        }
        private void label_xp_Click(object sender, EventArgs e)
        {

        }
    }

}
