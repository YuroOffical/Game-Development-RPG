using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Threading;

namespace RPG
{
    
    public partial class FormEquipment : Form
    {
        Thread thread;
        public int cash, helm, chest, leg, glove, weapon;
        public FormEquipment(int cash, int helm, int chest, int leg, int glove, int weapon)
        {
            InitializeComponent();
            Application.EnableVisualStyles();

            this.cash = cash;
            this.helm = helm;
            this.chest = chest;
            this.leg = leg;
            this.glove = glove;
            this.weapon = weapon;

            button_helm.Text = $"Upgrade Cost : {100 + (helm * 125)} ඞ";
            buttonglove.Text = $"Upgrade Cost : {100 + (glove * 125)} ඞ";
            buttonchest.Text = $"Upgrade Cost : {100 + (chest * 125)} ඞ";
            buttonleg.Text = $"Upgrade Cost : {100 + (leg * 125)} ඞ";
            buttonwep.Text = $"Upgrade Cost : {100 + (weapon * 125)} ඞ";
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            string data = $"{cash} {helm} {chest} {leg} {glove} {weapon}";
            File.WriteAllText("TempEquipment.txt", data);
            this.Close();
        }

        private void Realtimetick(object sender, EventArgs e)
        {
            label_cash.Text = $"Cash : {cash} ඞ";
            label_helm.Text = $"Level: {helm}";
            label_chest.Text = $"Level: {chest}";
            label_glove.Text = $"Level: {glove}";
            label_leg.Text = $"Level: {leg}";
            label_wep.Text = $"Level: {weapon}";


            if ((helm*10) > progressBarhelm.Value && progressBarhelm.Value < 210)
            {
                progressBarhelm.Value = progressBarhelm.Value + 1 * helm;
            }
            if ((chest * 10) > progressBarchest.Value && progressBarchest.Value < 210)
            {
                progressBarchest.Value = progressBarchest.Value + 1 * chest;
            }
            if ((glove * 10) > progressBarglove.Value && progressBarglove.Value < 210)
            {
                progressBarglove.Value= progressBarglove.Value + 1 * glove; 
            }
            if ((leg * 10) > progressBarleg.Value && progressBarleg.Value < 210)
            {
                progressBarleg.Value = progressBarleg.Value + 1 * leg;
            }
            if ((weapon * 10) > progressBarwep.Value && progressBarwep.Value < 210)
            {
                progressBarwep.Value = progressBarwep.Value + 1 * weapon;
            }

            if (progressBarhelm.Value >= 210)
            {
                button_helm.Text = "Maxed";
                button_helm.Enabled = false;
            }
            if (progressBarchest.Value >= 210)
            {
                buttonchest.Text = "Maxed";
                buttonchest.Enabled = false;
            }
            if (progressBarleg.Value >= 210)
            {
                buttonleg.Text = "Maxed";
                buttonleg.Enabled = false;
            }
            if (progressBarglove.Value >= 210)
            {
                buttonglove.Text = "Maxed";
                buttonglove.Enabled = false;
            }
            if (progressBarwep.Value >= 210)
            {
                buttonwep.Text = "Maxed";
                buttonwep.Enabled = false;
            }
        }
        private void button_helm_Click(object sender, EventArgs e)
        {
            if (cash >= 100 + (helm * 125) && progressBarhelm.Value < 210)
            {
                cash = cash - (100 + (helm * 125));
                helm++;
                button_helm.Text = "Upgraded!";
                Task.Delay(500).Wait();
                button_helm.Text = $"Upgrade Cost : {100 + (helm * 125)} ඞ";
            }
            else
            {
                button_helm.Text = "You're too poor";
                Task.Delay(500).Wait();
                button_helm.Text = $"Upgrade Cost : {100 + (helm * 125)} ඞ";
            }
        }

        private void buttonchest_Click(object sender, EventArgs e)
        {
            if (cash >= 100 + (chest * 125) && progressBarchest.Value < 210)
            {
                cash = cash - (100 + (chest * 125));
                chest++;
                buttonchest.Text = "Upgraded!";
                Task.Delay(500).Wait();
                buttonchest.Text = $"Upgrade Cost : {100 + (chest * 125)} ඞ";
            }
            else if (progressBarchest.Value >= 210)
            {
                buttonchest.Text = "Maxed level reached";
            }
            else
            {
                buttonchest.Text = "You're too poor";
                Task.Delay(500).Wait();
                buttonchest.Text = $"Upgrade Cost : {100 + (chest * 125)} ඞ";
            }
        }

        private void buttonglove_Click(object sender, EventArgs e)
        {
            if (cash >= 100 + (glove * 125) && progressBarglove.Value < 210)
            {
                cash = cash - (100 + (glove * 125));
                glove++;
                buttonglove.Text = "Upgraded!";
                Task.Delay(500).Wait();
                buttonglove.Text = $"Upgrade Cost : {100 + (glove * 125)} ඞ";
            }
            else
            {
                buttonglove.Text = "You're too poor";
                Task.Delay(500).Wait();
                buttonglove.Text = $"Upgrade Cost : {100 + (glove * 125)} ඞ";
            }
        }
        private void buttonleg_Click(object sender, EventArgs e)
        {
            if (cash >= 100 + (leg * 125) && progressBarleg.Value < 210)
            {
                cash = cash - (100 + (leg * 125));
                leg++;
                buttonleg.Text = "Upgraded!";
                Task.Delay(500).Wait();
                buttonleg.Text = $"Upgrade Cost : {100 + (leg * 125)} ඞ";
            }
            else
            {
                buttonleg.Text = "You're too poor";
                Task.Delay(500).Wait();
                buttonleg.Text = $"Upgrade Cost : {100 + (leg * 125)} ඞ";
            }
        }
        private void buttonwep_Click(object sender, EventArgs e)
        {
            if (cash >= 100 + (weapon * 125) && progressBarwep.Value < 210)
            {
                cash = cash - (100 + (weapon * 125));
                weapon++;
                buttonwep.Text = "Upgraded!";
                Task.Delay(500).Wait();
                buttonwep.Text = $"Upgrade Cost : {100 + (weapon * 125)} ඞ";
            }
            else
            {
                buttonwep.Text = "You're too poor";
                Task.Delay(500).Wait();
                buttonwep.Text = $"Upgrade Cost : {100 + (weapon * 125)} ඞ";
            }
        }
    }
}
