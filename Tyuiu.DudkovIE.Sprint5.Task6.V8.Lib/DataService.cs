﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DudkovIE.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int c = 0;
            int z = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            z += 1;
                        }
                        else
                        {
                            z = 0;
                        }

                        if (z == 2 && line[i + 1] == ' ')
                        {
                            count += 1;
                        }
                    }
                }
                return count;
            }
        }
    }
}
