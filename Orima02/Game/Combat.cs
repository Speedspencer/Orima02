﻿using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Security;
using System.Threading;

namespace Orima02
{
    public class Combat
    {
        

        public void CharPassive(Character player)
        {
            //TODO
            //player.Passive();
            player.ModifyMp(1);
            Console.WriteLine($"{player.Mp}/{player.MaxMp}");
        }

        public object ItemPhase(ArrayList inventory)
        {
            while (true)
            {
                int i = 1;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Item Phase");
                Console.ResetColor();
                Console.WriteLine("(Please Select Your Item)\n" +
                                  "Or Press Enter to Pass...");
                foreach (UseableItem item in inventory)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i}.{item.Name}");
                    Console.ResetColor();
                    item.Stats();
                    i++;
                }

                try
                {
                    var userInput = Console.ReadKey(true).Key;
                    switch (userInput)
                    {
                        case ConsoleKey.D1:
                        {
                            return inventory[0];
                        }
                        case ConsoleKey.D2:
                        {
                            return inventory[1];
                        }
                        case ConsoleKey.D3:
                        {
                            return inventory[2];
                        }
                        case ConsoleKey.D4:
                        {
                            return inventory[3];
                        }
                        case ConsoleKey.Enter:
                        {
                            return null;
                        }
                        default:
                        {
                            continue;
                        }
                            
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
            }
        }

        public void CheckItem(object item, ArrayList allItem, ArrayList inventory, Character player)
        {
            //TODO
            if (item == allItem[0])
            {
                UseableItem fullRegen = new UseableItem(ItemName.FullRegen, "blaBla");
                fullRegen.FullRegen(player);
                Console.Clear();
                player.Stats();
                Console.WriteLine("You Choose FullRegen\n" +
                                  $"You now have {player.Hp}");
                Thread.Sleep(3000);
                inventory.Remove(item);
            } else if (item == allItem[1])
            {
                UseableItem doubleDamage = new UseableItem(ItemName.DoubleDamage, "Bla Bla");
                doubleDamage.DoubleDamage(player);
                inventory.Remove(item);
            }else if (item == allItem[2])
            {
                
            }

        }



        public void SkillPhase(Character player)
        {
            while (true)
            {
                //TODO
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Skill Phase");
                Console.ResetColor();
                Console.WriteLine("(Please Select Your Skill)\n" +
                                  "Or Press Enter to Pass...");
                
                

                var userInput = Console.ReadKey(true).Key;
                
                if (userInput == ConsoleKey.D1)
                {
                    
                }
                else if (userInput == ConsoleKey.D2)
                {
                    
                }
                else if (userInput == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }

        public void CharAutoAttack(Character player, Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{player.Name} AutoAttack Phase");
            Console.ResetColor();
            enemy.ModifyHp(-player.Atk);
            Console.WriteLine($"{player.Name} Deal {player.Atk} Damage to {enemy.Name}");
            Console.WriteLine($"{enemy.Name} now have {enemy.Hp} Hp left");
            Thread.Sleep(5000);
        }

        public void EnemyPassive(Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Passive Phase");
            Console.ResetColor();
            enemy.ModifyUlt(1);
            Console.WriteLine($"Enemy got {enemy.UltPoint}/{enemy.MaxUltPoint} (+1) Ultpoint");
            Thread.Sleep(5000);
        }

        public void EnemyUltimate(Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} Ultimate Phase");
            Console.ResetColor();
            if (enemy.UltPoint == 3)
            {
                Console.WriteLine($"{enemy.Name} Casts Ultimate!");
                enemy.UltPoint = 0;
                enemy.Ultimate();
            }
            else
            {
                Console.WriteLine("Not Enough UltPoint\n" +
                                  "Passing...");
            }
            Thread.Sleep(3000);
        }


        public void EnemyAutoAttack(Character player, Enemy enemy)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{enemy.Name} AutoAttack Phase");
            Console.ResetColor();
            player.ModifyHp(-enemy.Atk);
            Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
            Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
            Thread.Sleep(3000);
        }
        
        public void Debug(Character player, Enemy enemy)
        {
            Console.WriteLine($"Player HP: {player.Hp}");
            Console.WriteLine($"Enemy HP: {enemy.Hp}");
        }
    }
}