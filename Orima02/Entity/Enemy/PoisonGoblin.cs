﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Orima02
{
    public class PoisonGoblin: Enemy
    {
       

        public override void Attack(Character player, Enemy enemy)
        {
            Console.WriteLine("AttackPassive: PoisonAttack");
            Console.WriteLine($"{player.Name} is now Poisoned!");
            Thread.Sleep(3000);
            player.IsPoison = true;
            player.ModifyPoisonToken(1);
            player.ModifyHp(-Atk);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} Deal {enemy.Atk} Damage to {player.Name}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player.Name} now have {player.Hp} Hp left");
            Console.ResetColor();
        }


        public PoisonGoblin(string name, int hp, int maxHp, int atk, int ultPoint, int maxUltPoint, bool isAlive, bool isStun, bool isPoison, int baseAtk, int stunToken, int poisonToken, List<int> trapCombatIndex, List<int> trapUltimateIndex) : base(name, hp, maxHp, atk, ultPoint, maxUltPoint, isAlive, isStun, isPoison, baseAtk, stunToken, poisonToken, trapCombatIndex, trapUltimateIndex)
        {
        }
    }
}