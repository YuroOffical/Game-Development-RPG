using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    public class Skills
    {
        public string GetSkill(string pclass)
        {
            string result = "";
            if (pclass == "Stickboi")
            {
                result = result + "stat:Firestick,dmg,fire,15 desc:Deal's-fire-damage-to-the-Target cost:MP15 " ;
                result = result + "stat:Pray,buf,charge-guts,2-1 desc:Recieve-blessing cost:MP20 ";
                result = result + "stat:Stick-Yeet,dmg,almighty,15 desc:Deal's-almighty-damage-to-the-Target cost:CS150 ";
                result = result + "stat:Preach,dbf,dizzy-dizzy,11-11 desc:Make's-the-target-dizzy cost:MP25 ";
                result = result + "stat:Stick-Ritual,buf,charge-lifesteal-frenzy,3-20-20 desc:Trade-blood-for-power cost:HP50 ";
                result = result + "stat:Bestow-Pride,dbf,burned-frozen-dizzy-poisoned,25-25-25-25 desc:Target-is-severely-debuffed cost:MP15 ";
                result = result + "stat:Fallen-Star,dmg,almighty,500 desc:Deal's-Colossal-Almighty-damage-to-the-Target cost:Powerbar";
            }
            else if (pclass == "Slayer")
            {
                result = result + "stat:Buckshot,dmg,normal,20 desc:Deal's-High-Damage,-low-recoil cost:HP12 ";
                result = result + "stat:Dragon-Pellet,dmg,fire,15 desc:Deal's-Fire-Damage,-no-recoil cost:CS150 ";
                result = result + "stat:Grind,buf,guts-charge,1-2 desc:The-Grind-Never-Stops cost:MP10 ";
                result = result + "stat:Slug,dmg,almighty,20 desc:Deal's-Severe-Damage,-High-recoil cost:HP25 ";
                result = result + "stat:Slam-Fire,dbf,burned-dizzy,40-40 desc:Waste-money-for-multiple-shots cost:HP50 ";
                result = result + "stat:Never-Die!,buf,guts-fire-lifesteal,5-100-20 desc:Strain-your-body-to-it's-max cost:HP100 ";
                result = result + "stat:A10,dmg,almighty,500 desc:BRRRRRRTT cost:Powerbar";
            }
            else if (pclass == "Cursed")
            {
                result = result + "stat:Curse,dbf,dizzy-frozen,20-20 desc:Curse-the-enemy cost:MP11 ";
                result = result + "stat:Sacrifice,buf,lifesteal-guts-charge,20-1-1 desc:Sacrifice-your-soul-for-power cost:HP40 ";
                result = result + "stat:Fear-induce,dbf,poison-frozen,30-30 desc:Glare-at-your-foe,-causing-fear cost:MP23 ";
                result = result + "stat:Grap,dmg,almighty,5 desc:Grap-your-foe-and-shred-em cost:MP25 ";
                result = result + "stat:Extend-Influence,dbf,dizzy-frozen-fire,60-60-60 desc:Minituarized-Ultimate cost:MP100 ";
                result = result + "stat:Disfigure,dmg,poison,30 desc:Disfigure-your-foe,-causing-pain cost:MP32 ";
                result = result + "stat:Domain-Expansion,dbf,poisoned-burned-dizzy-frozen,999-999-999-999 desc:Make-your-foe-Suffer cost:Powerbar";
            }
            else if (pclass == "Miko")
            {
                result = result + "stat:D.Sign:-Spark,dmg,elec,15 desc:Deal's-Electri-damage cost:MP15 ";
                result = result + "stat:S.sign:-Pray,hel,normal,30 desc:Healing-Spellcard cost:MP12 ";
                result = result + "stat:S.Sign:-Elemental,buf,fire-ice-elec-poison,30-30-30-30 desc:Fortifies-Spelluser-with-elementals cost:MP20 ";
                result = result + "stat:V.Sign:-Delay,dbf,frozen,120 desc:Slowdowns-foes-time cost:MP25 ";
                result = result + "stat:D.Sign:-Triple,dmg,almighty,3 desc:Low-cost-spellcard,-spammable cost:MP3 ";
                result = result + "stat:S.sign:-Holy,buf,haste-guts-lifesteal,100-1-100 desc:Gift-from-the-miko-god-herself cost:MP15 ";
                result = result + "stat:Holy-Shrine,buf,guts-haste-fire-lifesteal,6-999-999-999 desc:6-Blessings-from-the-maiden-god cost:Powerbar";
            }
            return result;
        }
        public string GetUlti(string pclass)
        {
            string result = "";
            if (pclass == "stickboi")
            {
                result = result + "Fallen-Star,dmg,almighty,200";
            }
            else if (pclass == "slayer")
            {

            }
            else if (pclass == "cursed")
            {

            }
            else if (pclass == "cultured")
            {

            }
            return result;
        }
    }
}
