using System;
namespace workshopweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nk = Console.ReadLine();
            string[] parts = nk.Split();
            int n = int.Parse(parts[0]);
            int k = int.Parse(parts[1]);

            int man = k;
            int woman = k;
            int i;

            for (i = 1; i <= n; i++)
            {
                string genscore = Console.ReadLine();
                parts = genscore.Split();
                int gender = int.Parse(parts[0]);
                int score1 = int.Parse(parts[1]);
                int score2 = int.Parse(parts[2]);

                if (man != 0 || woman != 0)
                {
                    if (score2 >= 9 && score1 >= 9)
                    {
                        if (gender == 1 && man != 0)
                        {
                            man--;
                            Console.WriteLine("{0} 1", i);
                        }
                        else if (gender == 2 && woman != 0)
                        {
                            woman--;
                            Console.WriteLine("{0} 2", i);
                        }
                        else if (gender == 1 && man == 0)
                        {
                            woman--;
                            Console.WriteLine("{0} 2", i);
                        }
                        else if (gender == 2 && woman == 0)
                        {
                            man--;
                            Console.WriteLine("{0} 1", i);
                        }
                    }
                    else if (score1 >= 9)
                    {
                        man--;
                        Console.WriteLine("{0} 1", i);
                    }
                    else if (score2 >= 9)
                    {
                        woman--;
                        Console.WriteLine("{0} 2", i);
                    }
                }
                else
                {
                    break;
                }

            }
        }

    }
}


