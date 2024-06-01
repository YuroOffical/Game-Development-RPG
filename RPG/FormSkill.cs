using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using RPG.Class;

namespace RPG
{
    public partial class FormSkill : Form
    {
        Skills skill = new Skills();

        List <string> skillstat = new List<string>();
        List<string> skilldesc = new List<string>();
        List<string> skillcost = new List<string>();
        List<string> skillcostc = new List<string>(); //currency used
        List<string> skillcostv = new List<string>(); //value

        public double HP, MP, MPi, HPi;
        public int cash, file, level;
        public string pclass;

        

        public FormSkill(int file,int level,double HP, double MP, double HPi, double MPi, int cash, string pclass)
        {
            InitializeComponent();
            this.file = file;
            this.level = level;
            this.HP = HP;
            this.MP = MP;
            this.MPi = MPi;
            this.HPi = HPi;
            this.cash = cash;
            this.pclass = pclass;
            skillstat.Clear();
            skilldesc.Clear();
            skillcost.Clear();
            skillcostc.Clear();
            skillcostv.Clear();
            Initialize();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[2] + " "+skillcostc[2]);
            File.WriteAllText("TempSkill.txt", skillstat[2]);
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Resume.txt", "");
            this.Close();
        }
        private async void Initialize()
        {
            string data = skill.GetSkill(pclass);
            string[] data2 = data.Split(' ');
            // Splits Stats, Description, and Cost
            foreach (string s in data2)
            {
                if (s.Contains("stat:"))
                {
                    skillstat.Add(s.Substring(5));
                }
                if (s.Contains("desc:"))
                {
                    skilldesc.Add(s.Substring(5).Replace('-',' '));
                }
                if (s.Contains("cost:"))
                {
                    skillcost.Add(s.Substring(5));
                }
            }
            // Skill Cost Setter
            foreach (string d in skillcost)
            {
                skillcostv.Add(d.Substring(2));
                if (d.Substring(0, 2) == "CS")
                {
                    skillcostc.Add("cash");
                }
                else
                {
                    skillcostc.Add(d.Substring(0,2));
                }
            }

            // Puts things in place
            string[] detail = skillstat[0].Split(',');
            button1.Text = detail[0].Replace('-', ' ');
            label1.Text = skilldesc[0];
            label1c.Text = $"Cost: {skillcostv[0]} {skillcostc[0]}";
            label1c.Visible = true;
            
            detail = skillstat[1].Split(',');
            button2.Text = detail[0].Replace('-', ' ');
            label2.Text = skilldesc[1];
            label2c.Text = $"Cost: {skillcostv[1]} {skillcostc[1]}";

            detail = skillstat[2].Split(',');
            button3.Text = detail[0].Replace('-', ' ');
            label3.Text = skilldesc[2];
            label3c.Text = $"Cost: {skillcostv[2]} {skillcostc[2]}";

            detail = skillstat[3].Split(',');
            button4.Text = detail[0].Replace('-', ' ');
            label4.Text = skilldesc[3];
            label4c.Text = $"Cost: {skillcostv[3]} {skillcostc[3]}";

            detail = skillstat[4].Split(',');
            button5.Text = detail[0].Replace('-', ' ');
            label5.Text = skilldesc[4];
            label5c.Text = $"Cost: {skillcostv[4]} {skillcostc[4]}";

            detail = skillstat[5].Split(',');
            button6.Text = detail[0].Replace('-', ' ');
            label6.Text = skilldesc[5];
            label6c.Text = $"Cost: {skillcostv[5]} {skillcostc[5]}";

            detail = skillstat[6].Split(',');
            label_Ultimate.Text = detail[0].Replace('-', ' ');
            label7.Text = skilldesc[6];
            label_ulti_cost.Text = $"Cost: Power meter at MAX";
            // Cost
            if (skillcostc[0].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[0]))
                {
                    button1.Text = "Too Weak";
                    button1.Enabled = false;
                }
            }
            else if (skillcostc[0].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[0]))
                {
                    button1.Text = "Too Low";
                    button1.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[0]))
                {
                    button1.Text = "Too Poor";
                    button1.Enabled = false;
                }
            }
            if (skillcostc[1].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[1]))
                {
                    button2.Text = "Too Weak";
                    button2.Enabled = false;
                }
            }
            else if (skillcostc[1].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[1]))
                {
                    button2.Text = "Too Low";
                    button2.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[1]))
                {
                    button2.Text = "Too Poor";
                    button2.Enabled = false;
                }
            }
            if (skillcostc[2].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[2]))
                {
                    button3.Text = "Too Weak";
                    button3.Enabled = false;
                }
            }
            else if (skillcostc[2].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[2]))
                {
                    button3.Text = "Too Low";
                    button3.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[2]))
                {
                    button3.Text = "Too Poor";
                    button3.Enabled = false;
                }
            }
            if (skillcostc[3].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[3]))
                {
                    button4.Text = "Too Weak";
                    button4.Enabled = false;
                }
            }
            else if (skillcostc[3].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[3]))
                {
                    button4.Text = "Too Low";
                    button4.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[3]))
                {
                    button4.Text = "Too Poor";
                    button4.Enabled = false;
                }
            }
            if (skillcostc[4].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[4]))
                {
                    button5.Text = "Too Weak";
                    button5.Enabled = false;
                }
            }
            else if (skillcostc[4].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[4]))
                {
                    button5.Text = "Too Low";
                    button5.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[4]))
                {
                    button5.Text = "Too Poor";
                    button5.Enabled = false;
                }
            }
            if (skillcostc[5].Contains("HP"))
            {
                if (HP < Convert.ToInt32(skillcostv[5]))
                {
                    button6.Text = "Too Weak";
                    button6.Enabled = false;
                }
            }
            else if (skillcostc[5].Contains("MP"))
            {
                if (MP < Convert.ToInt32(skillcostv[5]))
                {
                    button6.Text = "Too Low";
                    button6.Enabled = false;
                }
            }
            else
            {
                if (cash < Convert.ToInt32(skillcostv[5]))
                {
                    button6.Text = "Too Poor";
                    button6.Enabled = false;
                }
            }
            // Limiter

            if (level < 4)
            {
                button2.Text = "Locked";
                button2.Enabled = false;
                label2.Text = "Unlocked at level 4";
                label2c.Visible = false;
            }
            else
            {
                label2c.Visible = true;
            }
            if (level < 7)
            {
                button3.Text = "Locked";
                button3.Enabled = false;
                label3.Text = "Unlocked at level 7";
                label3c.Visible = false;
            }
            else
            {
                label3c.Visible = true;
            }
            if (level < 10)
            {
                button4.Text = "Locked";
                button4.Enabled = false;
                label4.Text = "Unlocked at level 10";
                label4c.Visible = false;
            }
            else
            {
                label4c.Visible = true;
            }
            if (level < 13)
            {
                button5.Text = "Locked";
                button5.Enabled = false;
                label5.Text = "Unlocked at level 13";
                label5c.Visible = false;
            }
            else
            {
                label5c.Visible = true;
            }
            if (level < 16)
            {
                button6.Text = "Locked";
                button6.Enabled = false;
                label6.Text = "Unlocked at level 16";
                label6c.Visible = false;
            }
            else
            {
                label6c.Visible = true;
            }

            if (file == 99)
            {
                button1.Enabled = false;
                button2.Enabled=false;
                button3.Enabled=false;
                button4.Enabled=false;
                button5.Enabled=false;
                button6.Enabled=false;
            }
        }
        private void Gametimetick(object sender, EventArgs e)
        {
            label_cash.Text = $"Cash: {cash}ඞ";
            label_hpmp.Text = $"HP: {Convert.ToInt32(HP)}/{Convert.ToInt32(HPi)} MP: {Convert.ToInt32(MP)}/{Convert.ToInt32(MPi)}";
            //Updator
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[0] + " " + skillcostc[0]);
            File.WriteAllText("TempSkill.txt", skillstat[0]);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[1] + " " + skillcostc[1]);
            File.WriteAllText("TempSkill.txt", skillstat[1]);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[3] + " " + skillcostc[3]);
            File.WriteAllText("TempSkill.txt", skillstat[3]);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[4] + " " + skillcostc[4]);
            File.WriteAllText("TempSkill.txt", skillstat[4]);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Update.txt", skillcostv[5] + " " + skillcostc[5]);
            File.WriteAllText("TempSkill.txt", skillstat[5]);
            this.Close();
        }
    }
}
