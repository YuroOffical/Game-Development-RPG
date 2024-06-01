using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    public class Enemies
    {
        //dmg = damage
        //buf = buff
        //hel = heal
        //dbf = debuff
        public string Getinfo(int id)
        {
            string data = "";
            switch (id)
            {
                case 0:
                    data = "Ename:Slime Ehp:50 Eatk:10 Edef:1 Earm:1 Espe:2.1 Eskill1:Slime_Ball,dmg,normal,15 Eskill2:Heal,hel,normal,20 Eskill3:Power_up,buf,charge-frenzy,1-20 idI:Slime idA:SlimeA idC:SlimeCast";
                    break;
                case 1:
                    data = "Ename:Angry-Slime Ehp:100 Eatk:15 Edef:1 Earm:0 Espe:2.5 Eskill1:Gun,dmg,normal,14 Eskill2:Critical-Shot,dmg,normal,21 Eskill3:Brutal-Shot,dmg,almighty,50 idI:ASlime idA:ASlimeA idC:ASlimeC";
                    break;
                case 2:
                    data = "Ename:Sheet-of-paper Ehp:40 Eatk:10 Edef:1 Earm:0 Espe:3 Eskill1:Terms-Service,buf,haste-guts,15-1 Eskill2:Heal,hel,normal,20 Eskill3:Power_up,buf,charge-frenzy,1-30 idI:Paper idA:PaperA idC:PaperC";
                    break;
                case 4:
                    data = "Ename:Weird-Creature Ehp:115 Eatk:7 Edef:2 Earm:2 Espe:1.8 Eskill1:Screech,dmg,elec,15 Eskill2:Heal,hel,normal,15 Eskill3:Power_up,buf,charge-frenzy,1-20 idI:ATAT idA:ATATA idC:ATATC";
                    break;
                case 3:
                    data = "Ename:Tree Ehp:150 Eatk:3 Edef:3 Earm:2 Espe:1.5 Eskill1:Earthquake,dmg,normal,11 Eskill2:Harden,hel,normal,20 Eskill3:Power_up,buf,charge-frenzy,1-20 idI:Tree idA:TreeA idC:TreeC";
                    break;
                case 5:
                    data = "Ename:Pebble Ehp:15 Eatk:1 Edef:20 Earm:10 Espe:1.5 Eskill1:Charge,charge-frenzy,2-1 Eskill2:Harden,hel,normal,15 Eskill3:Maddenning,buf,charge-frenzy,1-20 idI:Rock idA:RockA idC:RockC";
                    break;
                case 6:
                    data = "Ename:Snowman Ehp:125 Eatk:5 Edef:5 Earm:3 Espe:2.5 Eskill1:Snow_Ball,dmg,ice,15 Eskill2:Harden,hel,normal,15 Eskill3:Maddenning,buf,charge-frenzy,1-20 idI:Snowboi idA:SnowboiA idC:SnowboiC";
                    break;
                case 7:
                    data = "Ename:Sun-Knight Ehp:150 Eatk:1 Edef:15 Earm:3 Espe:2.1 Eskill1:Sun,dmg,fire,15 Eskill2:Pray,hel,normal,25 Eskill3:Praise-the-Sun,buf,guts-charge-frenzy,1-2-20 idI:Knight idA:KnightA idC:KnightC";
                    break;
                case 8:
                    data = "Ename:Eye Ehp:100 Eatk:15 Edef:15 Earm:3 Espe:3.1 Eskill1:Stare,dmg,fire,15 Eskill2:Curse,hel,normal,25 Eskill3:Power-Boost,buf,guts-charge,1-2 idI:Eye idA:EyeA idC:EyeC";
                    break;
                case 9:
                    data = "Ename:Rift-in-space Ehp:250 Eatk:5 Edef:25 Earm:4 Espe:2.1 Eskill1:Corrupt,dmg,almighty,15 Eskill2:Corruption,buf,lifesteal-guts,60-1 Eskill3:Praise-the-Void,buf,guts-charge-frenzy,1-2-20 idI:Rift idA:RiftA idC:RiftC";
                    break;
                case 10:
                    data = "Ename:Abyssal-God Ehp:500 Eatk:50 Edef:20 Earm:4 Espe:5 Eskill1:Curse-the-Land,dbf,poisoned-frozen,30-30 Eskill2:Curse-the-Soul,buf,normal,25 Eskill3:Praise-the-Void,buf,charge-frenzy-lifesteal,1-40-40 idI:Abyss idA:AbyssA idC:AbyssC";
                    break;
                case 11:
                    data = "Ename:Voidlings Ehp:120 Eatk:40 Edef:11 Earm:3 Espe:4 Eskill1:Curse-the-Area,dbf,poisoned-frozen,15-15 Eskill2:Curse-the-Soul,hel,normal,25 Eskill3:Praise-the-rift,buf,guts-charge-frenzy-lifesteal,1-1-20-20 idI:Abyssal idA:AbyssalA idC:AbyssalC";
                    break;
                case 12:
                    data = "Ename:Queen-of-the-Void Ehp:1000 Eatk:75 Edef:21 Earm:10 Espe:7 Eskill1:Void-Sign:-Rise,buf,lifesteal-haste-charge,100-20-1 Eskill2:Void-Sign:-Fall,dbf,poisoned-burned-dizzy-frozen,30-30-30-30 Eskill3:All-things-must-end,dmg,almighty,999 idI:AbyssQueen idA:AbyssQueenA idC:AbyssQueenC";
                    break;
                default:
                    data = "Ename:slime Ehp:50 Eatk:10 Edef:1 Earm:1 Espe:3.1 Eskill1:Slime_Ball,dmg,normal,15 Eskill2:Heal,hel,normal,20 Eskill3:Power_up,buf,charge-frenzy,1-20 idI:Slime idA:SlimeA idC:SlimeCast";
                    break;
            }
            return data;
        }
    }
}
