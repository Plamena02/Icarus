using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int damage = 1;
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "Supernova")
            {
                int timesToMove = int.Parse(input[1]);
                if (input[0] == "left") {
                    for (int i = 0; i < timesToMove; i++)
                    {
                        index--;
                        
                        if (index < 0) 
                        {
                            index = list.Count - 1;
                            damage++;
                        }
                        list[index] -= damage;
                    }  
                }
                if (input[0] == "right") {

                    for (int i = 0; i < timesToMove; i++)
                    {

                        index++;

                        if (index == list.Count)
                        {

                            index = 0;
                            damage++;

                        }

                        list[index] -= damage;

                    }


                }

                input = Console.ReadLine().Split(' ');

            }

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

        }
    }
}

