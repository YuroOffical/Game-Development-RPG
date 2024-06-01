using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    
    internal class Mapgenerator
    {
        Random RNG = new Random();
        int[,] perlinmap = new int[9, 22];
        int plains, forest, mount, dungeon;
        int mountlimit;
        int dungeonlimit;
        int spread;
        string result = "44";
        public string Mapgen()
        {
            String rawdata = File.ReadAllText("Temp2.txt");
            String[]data = rawdata.Split(' ');
            this.mountlimit = Convert.ToInt32(data[0]);
            this.dungeonlimit = Convert.ToInt32(data[1]);
            this.spread = Convert.ToInt32(data[2]);
            do
            {
                Random r = new Random();
                plains = 0;
                forest = 0;
                mount = 0;
                result = "44";
                for (int j = 1; j <= 20; j++)
                {
                    perlinmap[0, j] = 1;
                    perlinmap[8, j] = 1;
                }
                for (int i = 1; i <= 7; i++)
                {
                    perlinmap[i, 0] = 1;
                    perlinmap[i, 21] = 1;
                }
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 20; j++)
                    {
                        dungeon = r.Next(0, 100);
                        if (perlinmap[i, j - 1] == 0 || perlinmap[i, j + 1] == 0 || perlinmap[i - 1, j] == 0 || perlinmap[i + 1, j] == 0)
                        {
                            perlinmap[i, j] = r.Next(0, 2);
                        }
                        else if (perlinmap[i, j - 1] == 1 || perlinmap[i, j + 1] == 1 || perlinmap[i - 1, j] == 1 || perlinmap[i + 1, j] == 1)
                        {
                            perlinmap[i, j] = r.Next(0, 3);
                        }
                        if (dungeon > 97)
                        {
                            perlinmap[i, j] = 3;
                        }
                    }
                }
                dungeon = 0;
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 20; j++)
                    {
                        if (perlinmap[i, j - 1] != 0 && perlinmap[i, j + 1] != 0 && perlinmap[i - 1, j] != 0 && perlinmap[i + 1, j] != 0)
                        {
                            perlinmap[i, j] = 2;
                        }
                        if (perlinmap[i, j] == 0)
                        {
                            plains++;
                            result = result + Convert.ToString(perlinmap[i, j]);
                        }
                        if (perlinmap[i, j] == 1)
                        {
                            forest++;
                            result = result + Convert.ToString(perlinmap[i, j]);
                        }
                        if (perlinmap[i, j] == 2)
                        {
                            mount++;
                            result = result + Convert.ToString(perlinmap[i, j]);
                        }
                        if (perlinmap[i, j] == 3)
                        {
                            dungeon++;
                            result = result + Convert.ToString(perlinmap[i, j]);
                        }
                    }
                }
            }
            while (mount < (mountlimit - spread) || mount > (mountlimit + spread) || dungeon < (dungeonlimit - spread) || dungeon > (dungeonlimit + spread));
            return result;
        }
    }
}
