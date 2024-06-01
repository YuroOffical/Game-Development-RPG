using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using RPG.Properties;

namespace RPG.Class
{
    public class Player : Entity
    {
        public string[] playersavefile = { "Player 1.txt", "Player 2.txt", "Player 3.txt", "Player 4.txt", "Player 5.txt", "Player 6.txt" };
        //Stat = helm: chest: leg: glove: weapon: cash: exp: Sp: skill: level: position: ng:0
        public void EditorInt(int file, string stat, int valu, int valuy)
        {
            string playerdata = File.ReadAllText(playersavefile[(file - 1)]);
            string[] pdatastring = playerdata.Split(' ');
            for (int i = 0; i < pdatastring.Length; i++)
            {
                if (pdatastring[i].Contains(stat) && stat != "position:")
                {
                    int data = Convert.ToInt32(pdatastring[i].Substring(stat.Length));
                    pdatastring[i] = stat+valu;
                }
                if (pdatastring[i].Contains("position:") && stat == "position:")
                {
                    string[] posxy = (pdatastring[i].Substring(9)).Split(',');
                    int datax = Convert.ToInt32(posxy[0]);
                    int datay = Convert.ToInt32(posxy[1]);
                    pdatastring[i] = stat+valu+","+valuy;
                }
            }
            string result = "";
            foreach (string p in pdatastring)
            {
                result = result + p + " ";
            }
            File.WriteAllText(playersavefile[(file - 1)], result);
        }
        public int GetInt(int file, string stat)
        {
            int result = 0;
            string playerdata = File.ReadAllText(playersavefile[(file - 1)]);
            string[] pdatastring = playerdata.Split(' ');
            for (int i = 0; i < pdatastring.Length; i++)
            {
                if (pdatastring[i].Contains(stat))
                {
                    result = Convert.ToInt32(pdatastring[i].Substring(stat.Length));
                }
            }
            return result;
        }
        public void EditString(int file, string stat, string valu)
        {
            string playerdata = File.ReadAllText(playersavefile[(file - 1)]);
            string[] pdatastring = playerdata.Split(' ');
            for (int i = 0; i < pdatastring.Length; i++)
            {
                if (pdatastring[i].Contains(stat))
                {
                    string data = pdatastring[i].Substring(stat.Length);
                    pdatastring[i] = stat + valu;
                }
            }
            string result = "";
            foreach (string p in pdatastring)
            {
                result = result + p + " ";
            }
            File.WriteAllText(playersavefile[(file - 1)], result);
        }
        public string GetCharacterPicture(string pclass)
        {
            string result = "";
            if (pclass == "Stickboi")
            {
                result = "Stickboi_idle Stickboi_Atk Stickboi_Guard Stickboi_Cast Stickboi_Skill Stickboi_potion";
            }
            else if (pclass == "Slayer")
            {
                result = "Slayer_idle Slayer_Atk Slayer_Guard Slayer_Cast Slayer_Skill Slayer_potion";
            }
            else if (pclass == "Cursed")
            {
                result = "Cursed_idle Cursed_Atk Cursed_Guard Cursed_Cast Cursed_Skill Cursed_potion";
            }
            else if (pclass == "Miko")
            {
                result = "Miko_idle Miko_Atk Miko_Guard Miko_Cast Miko_Skill Miko_potion";
            }
            return result;
        }
    }
}
