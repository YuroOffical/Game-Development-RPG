using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace RPG.Class
{
    public class SlotChecker
    {
        public int temp;
        public string pclass="0";
        public string slotline;
        public string slotted;
        public int currentslot = 0;
        public String[] playerslotname = {"Player 1.txt", "Player 2.txt", "Player 3.txt", "Player 4.txt", "Player 5.txt", "Player 6.txt", };
        public void Slot(int x, string y)//x = id  y = state
        {
            if (File.Exists("Slots.txt"))
            {
                slotted = "";
                slotline = File.ReadAllText("Slots.txt");
                string[] slots = slotline.Split(' ');
                for (int i = 0; i < 7; i++)
                {
                    if (i == (x - 1))
                    {
                        slotted = slotted + y + " ";
                    }
                    else if (slots[i] == "1")
                    {
                        slotted = slotted + 1 + " ";
                    }
                    else if (slots[i] == "2")
                    {
                        slotted = slotted + 2 + " ";
                    }
                    else
                    {
                        slotted = slotted + 0 + " ";
                    }
                }
                File.WriteAllText("Slots.txt", slotted);
            }
            else
            {
                File.WriteAllText("Slots.txt", "0 0 0 0 0 0 0");
            }
        }
        public void Createplayer(string info)
        {
            int selected = 0;
            slotline = File.ReadAllText("Slots.txt");
            string[] slots = slotline.Split(' ');
            for (int i = 0; i < 7; i++)
            {
                if (slots[i] == "1")
                {
                    break;
                }
                else
                {
                    selected++;
                }
                Slot(selected, "2");
            }
            File.WriteAllText(playerslotname[selected], info);
        }
        public void ClassCharacterSelected(string info, string playername)
        {
            playername.Replace(" ", "_");
            File.WriteAllText("temp.txt", info + " " + playername);
        }
        public void Set(int x)
        {
        currentslot = x;
        }

        public int Check()
        {
            int selected = this.currentslot;
            slotline = File.ReadAllText("Slots.txt");
            string[] slots = slotline.Split(' ');
            if (slots[selected] == "1")
            {
                temp = 1;
            }
            else
            {
                temp = 0;
            }
            return temp;
        }
        public void SetClass(string pclass)
        {
            this.pclass = pclass;
        }
        public string GetClass()
        {
            MessageBox.Show(pclass);
            return this.pclass;
        }

    }
}




