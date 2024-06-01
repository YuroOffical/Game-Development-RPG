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
using RPG.Class;

namespace RPG
{
    public partial class FormWinLoss : Form
    {
        Thread thread;
        Player playereditor = new Player();
        Random random = new Random();
        public int exp, level, cash, rewardcash, rewardexp, lostcash, file, SP, currentlevellimit;
        public int explimit, lostexp, timer, expbarlimit, levellimit, checkskill, checkbonus, exprecieved, exprecieved2, cashrecieved , cutexp, XP, XPc, levellup;
        public double currentexp, reset;

        

        int expbar;

        

        public string pclass, name, showexp;
        public FormWinLoss(int file, string condition ,int exp, int level, int cash, int rewardcash, int rewardexp, string pclass, string name, string ename)
        {
            InitializeComponent();
            this.exp = exp;
            this.level = level;
            this.cash = cash;
            this.rewardcash = rewardcash;
            this.rewardexp = rewardexp;
            this.pclass = pclass;
            this.name = name;
            this.file = file;
            XPc = this.exp;

            if (condition == "win")
            {
                label_screen.Text = "Victory Screen";
                label_taos.Text = $"You have defeated a {ename.Replace('-',' ')}";
                label_earn_cash.Text = $"You've earn {Convert.ToInt32(rewardcash)} ඞ";
                cashrecieved = cash + rewardcash;
                exprecieved2 = exp + this.rewardexp;
            }
            if (condition == "lost")
            {
                pictureBox_player.Image = Properties.Resources.Defeated;
                label_screen.Text = "Defeat Screen";
                label_title.Text = "Git Gud";
                label_text.Text = "farm more, suck less";
                label_taos.Text = $"a {ename.Replace('-', ' ')} has defeated you";
                label_earn_cash.Text = $"You've lost {Convert.ToInt32(lostcash)} ඞ";
                cashrecieved = cash - rewardcash/2;
                this.rewardexp = rewardexp /2;
                if (cashrecieved < 0)
                {
                    cashrecieved = 0;
                }
                exprecieved2 = exp + this.rewardexp;
            }
            if (condition == "run")
            {
                pictureBox_player.Image = Properties.Resources.Run_away;
                label_screen.Text = "Escaped Screen";
                label_title.Text = "Coward";
                label_text.Text = "fight to the death ya lade";
                label_taos.Text = $"You've escaped from a {ename.Replace('-', ' ')}";
                label_earn_cash.Text = $"No money gained";
                this.rewardcash = 0;
                this.rewardexp = 0;
                this.expbarlimit = 0;
                cashrecieved = cash;
                exprecieved2 = exp ;
                Expbar.Enabled = false;
            }

            reset = 0;
            checkbonus = 2;
            checkskill = 2;
            levellimit = 800 + (level * 200);
            currentlevellimit = levellimit;
            explimit = exp + this.rewardexp;
            label_level.Text = $"Level : {level}";
            label_exp.Text = $"XP : {exp}/{levellimit}";
            currentexp = exp;

            if (explimit > levellimit) // levelup
            {
                level=level+1;
                levellup = level;
                exprecieved2 = explimit - levellimit;
                cutexp = levellimit - exp;
                explimit = levellimit;
                SP = playereditor.GetInt(file, "Sp:");
                SP = SP + 3;
                playereditor.EditorInt(file, "Sp:", SP, 0);
                if (level % 5 == 1)
                {
                    SP = playereditor.GetInt(file, "Sp:");
                    SP = SP + 5;
                }
                playereditor.EditorInt(file, "Sp:", SP, 0);
                playereditor.EditorInt(file, "exp:", cutexp, 0);
                playereditor.EditorInt(file, "level:", level, 0);
            }
            exprecieved = exp + this.rewardexp;
            expbar = Convert.ToInt32(400 * (Convert.ToDouble(exp) / Convert.ToDouble(levellimit)));
            expbarlimit = Convert.ToInt32(400 * (Convert.ToDouble(explimit) / Convert.ToDouble(levellimit)));
            panel_expbarblue.Size = new Size(expbar, 31);

            Stylebaby(condition);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"xp{expbar} + {expbarlimit} level{level} cash{cashrecieved}  { expbar}  ");
        }
        private async void Realtimetick(object sender, EventArgs e)
        {
            timer++;
            showexp = expshower(timer);
            label_exp_earn.Text = $"+ {showexp} XP";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            playereditor.EditorInt(file, "level:", levellup, 0);
            this.Close();
            thread = new Thread(game);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void game(object obj)
        {
            playereditor.EditorInt(file, "exp:", exprecieved2, 0);
            playereditor.EditorInt(file, "cash:", cashrecieved, 0);
            Application.Run(new FormGame(file));
        }
        private async void Stylebaby(string condition)
        {
            label_title.Visible = true;
            await Task.Delay(150);
            Realtime.Enabled = true;    
            label_title.Font = new Font("Sina-Regular", 40);
            await Task.Delay(150);
            label_title.Font = new Font("Sina-Regular", 36);

            await Task.Delay(400);

            label_taos.Visible = true;
            await Task.Delay(150);
            label_taos.Font = new Font("Sina-Regular", 22);
            await Task.Delay(150);
            label_taos.Font = new Font("Sina-Regular", 16);

            await Task.Delay(400);

            label_earn_cash.Visible = true;
            await Task.Delay(150);
            label_earn_cash.Font = new Font("Sina-Regular", 22);
            await Task.Delay(150);
            label_earn_cash.Font = new Font("Sina-Regular", 16);

    
            
            await Task.Delay(400);
            label_exp_earn.Visible = true;

            await Task.Delay(1420);
            label_exp_earn.Font = new Font("Sina-Regular", 22);
            await Task.Delay(150);
            label_exp_earn.Font = new Font("Sina-Regular", 16);
            await Task.Delay(150);
            Realtime.Enabled = false;
            await Task.Delay(250);
            if (condition == "run")
            {
                Expbar.Enabled = false;
                button1.Visible = true;
            }
            else
            {
                Expbar.Enabled = true;
            }
            if (label_taos.Text.Contains("Abyssal") && condition == "win")
            {
                File.WriteAllText("newgame.txt", "");
                button1.Text = "World is Collapsing";
            }
            await Task.Delay(3000);
            button1.Visible = true;
        }
        private string expshower(int val)
        {
            rewardexp = this.rewardexp;
            string result = "";
            for(int i = 0; i < rewardexp.ToString().Length; i++)
            {
                if (val > 55 && rewardexp != 0)
                {
                    result = result + rewardexp.ToString().Substring(i, rewardexp.ToString().Length - (i+1));
                }
                else if (val > 54 && rewardexp == 0)
                {
                    result = "0";
                }
                else
                {
                    result = result + random.Next(1, 10).ToString();
                }
            }
            return result;
        }
        private async void Expvaluetick(object sender, EventArgs e)
        {
            if (XPc < levellimit && Expbar.Enabled == true && XPc != exprecieved2 )
            {
                XPc = XPc + 1;
                label_exp.Text = $"XP : {XPc}/{levellimit}";
            }
            else if (levellimit < XPc)
            {
                label_exp.Text = $"XP : Level up!";
            }
        }
        private async void Expbartick(object sender, EventArgs e)
        {
            if (reset == 1)
            {
                currentexp = currentexp + cutexp;
                reset = 0;
            }
            int showexp = Convert.ToInt32(currentexp);
            levellimit = 800 + (level * 200);
            if (expbar <= expbarlimit)
            {
                expbar++;
                currentexp = expbar * (levellimit / 400);
                panel_expbarblue.Size = new Size(expbar, 31);
            }
            else if (expbar > 400)
            {
                expbar = 0;
                Expbar.Enabled = false;
                label_exp.Text = $"XP : Level up!";
                explimit = exprecieved - levellimit;
                label_levelup.Visible = true;
                await Task.Delay(150);
                label_levelup.Font = new Font("Sina-Regular", 22);
                await Task.Delay(150);
                label_levelup.Font = new Font("Sina-Regular", 16);
                await Task.Delay(350);
                label_level.Text = "Level: " + level;
                label_level.Font = new Font("Sina-Regular", 14);
                await Task.Delay(150);
                label_level.Font = new Font("Sina-Regular", 12);
                checkskill = 0;
                checkbonus = 0;
                explimit = exp + rewardexp;
                reset = 1;
                expbarlimit = Convert.ToInt32(400 * (Convert.ToDouble(explimit) / Convert.ToDouble(levellimit)));
                

                if (level % 3 == 1)
                {
                    checkskill++;
                    label_newskill.Visible = true;
                    await Task.Delay(150);
                    label_newskill.Font = new Font("Sina-Regular", 22);
                    await Task.Delay(150);
                    label_newskill.Font = new Font("Sina-Regular", 16);
                }
                if (level % 5 == 1)
                {
                    checkbonus++;
                    await Task.Delay(150);
                    label_bonus.Visible = true;
                    await Task.Delay(150);
                    label_bonus.Font = new Font("Sina-Regular", 22);
                    await Task.Delay(150);
                    label_bonus.Font = new Font("Sina-Regular", 16);
                }
            }
            else
            {
                button1.Visible = true;
            }
        }
    }
}
