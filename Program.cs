﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_Endproject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        cricket:
            Console.WriteLine("MENU :\n1.Add Player 2.Remove Player by ID 3.Get Player by ID 4.Get Player by Name 5.Get All Player Details");
            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                team:
                    One_Day_Team t1 = new One_Day_Team();
                    if (One_Day_Team.teamlist.Count != One_Day_Team.teamlist.Capacity)
                    {
                        Console.Write("Enter Player Id:");
                        t1.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name:");
                        t1.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age:");
                        t1.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        t1.Add(t1);
                    }
                    else
                    {
                        Console.WriteLine("CAN'T ADD MORE THAN 11 PLAYERS");
                        goto cricket;
                    }



                    Console.WriteLine("Enter yes to continue adding players");
                    string ch = Console.ReadLine();
                    if (ch == "yes")
                    {
                        goto team;
                    }
                    break;
                case 2:
                    One_Day_Team t2 = new One_Day_Team();
                    Console.Write("Enter Player Id to remove:");
                    int p = Convert.ToInt32(Console.ReadLine());
                    t2.Remove(p);
                    break;
                case 3:
                    One_Day_Team t3 = new One_Day_Team();
                    Console.Write("Enter Player Id to search:");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    Player P1 = t3.GetPlayerById(pid);
                    Console.WriteLine($"{P1.PlayerId} {P1.PlayerName} {P1.PlayerAge}");
                    break;
                case 4:
                    One_Day_Team t4 = new One_Day_Team();
                    Console.Write("Enter Player Name to search:");
                    string pname = Console.ReadLine();
                    Player P2 = t4.GetPlayerByName(pname);
                    Console.WriteLine($"{P2.PlayerId} {P2.PlayerName} {P2.PlayerAge}");
                    break;
                case 5:
                    Console.WriteLine("Print All players");
                    List<Player> list = new List<Player>();
                    One_Day_Team t5 = new One_Day_Team();
                    list = t5.GetAllPlayers();
                    foreach (var item in list)
                    {
                        Console.WriteLine($"{item.PlayerId} {item.PlayerName} {item.PlayerAge}");
                    }
                    break;


            }
            Console.WriteLine("Enter yes to go to MENU ");
            string menu = Console.ReadLine();
            if (menu == "yes")
            {
                goto cricket;
            }
            Console.ReadLine();
        }
    }
}
