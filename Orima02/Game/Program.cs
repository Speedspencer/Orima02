﻿using System;
using System.ComponentModel;

namespace Orima02
{
    internal class Program
    {
        public static void Main(string[] args)
        {




            //Enemy Declaration
            GoblinGuard goblinGuard = new GoblinGuard("Goblin Guard", 1, 1, 1, 1, 1, true, false, true);
            GoblinWarrior goblinWarrior = new GoblinWarrior("Goblin Warrior", 1, 1, 1, 1, 1, true, true, true);

            
            
            //Combat Class Declaration
            Combat combat = new Combat();


            //Character Declaration
            Character player = new EmptyCharacter();


            //Item Declaration
            EquipableItem atkset = new EquipableItem(ItemName.AtkSet, 3, 1, 1, "Equip Atk Set");
            EquipableItem mpset = new EquipableItem(ItemName.MpSet, 1, 3, 1, "Equip MP Set");
            EquipableItem hpset = new EquipableItem(ItemName.HpSet, 1, 3, 1, "Equip HP Set");
            EquipableItem balanceset = new EquipableItem(ItemName.BalanceSet, 2, 2, 2, "Equip Balance Set");
            UseableItem fullRegen =
                new UseableItem(ItemName.FullRegen, $"Instantly regenerate your hp to {player.MaxHp}");
            UseableItem doubleDamage =
                new UseableItem(ItemName.DoubleDamage, $"Double your atk to {player.Atk*2}");
            UseableItem fullMp =
                new UseableItem(ItemName.FullMp, $"Instantly regenerate your mp to {player.MaxMp}");
            UseableItem stunBomb =
                new UseableItem(ItemName.StunBomb, "Stun your enemy for 1 turn");
            UseableItem poisonBomb =
                new UseableItem(ItemName.PoisonBomb, "poisoned your enemy");
            UseableItem damageBomb =
                new UseableItem(ItemName.DamageBomb, $"deals {player.Atk/2} damage at the enemy");
            UseableItem trapDeflect =
                new UseableItem(ItemName.TrapDeflect, "Reverse all damage to the enemy (this item will be active on the enemy turn");
            UseableItem trapUltimate =
                new UseableItem(ItemName.TrapUltimate, "Steal enemy's Ultimate (this item will be active on the enemy turn)");
            UseableItem abilityTheWorld =
                new UseableItem(ItemName.AbilityTheWorld, "Stunt enemy for 1-3 turn");
            UseableItem abilityOra =
                new UseableItem(ItemName.AbilityOra, "multiply player attack by 4");
            UseableItem abilityUseLeg =
                new UseableItem(ItemName.AbilityUseLeg, "50/50 chance to skip the current stage");
            
            
            
            

            //Inventory Declaration
            Inventory inventory = new Inventory(new [] {fullRegen,doubleDamage});

            Inventory fullinventory = new Inventory(new [] {fullRegen,doubleDamage,fullMp,stunBomb,poisonBomb,damageBomb,trapDeflect,trapUltimate,abilityTheWorld,abilityOra,abilityUseLeg});


             //Scene Declaration
            Scene scene1_1 = new Scene(1.1, 10, new[]
            {
                "While you are traveling had passed through the forest in the same area as the Feri City Kingdom.\n", 
                " which is a forest inhabited by goblins Or almost called their forest. =====While walking, you meet a young woman.\n",
                "(Player) : Is that a woman? \n",
                "(Player) : A woman in a forest with herds of goblins?\n",
                "(Player) : Let's enter to greet her.\n"
            });

            Scene scene1_1C1 = new Scene(1.1, 10, new[]
            {
                "(Player) : Hey that woman over there.\n",
                "??? : Who are you?\n",
                "(Player) : My name is (Player)\n",
                "(Player) : I'm just a (player class) passing this way.\n",
                "(Player) : And you?\n",
                "Irene : My name is Irene the Felicity, I'm the princess of the Felicity Kingdom.\n"
            });

            Scene scene1_1C2 = new Scene(1.1, 10, new[]
            {
                "(Player) : I'm arrogant, better not go in\n",
                "Dev : You can't be that arrogant. If so, how will the game continue?\n",
                "Dev : Go in and say hi to that woman now.\n"
            });
            Scene scene1_2 = new Scene(1.2, 10, new[]
            {
                "Narrator : You met the princess of the Feri City Kingdom……but in the forest?\n",
            });
            Scene scene1_2C1 = new Scene(1.2, 10, new[]
            {
               "(Player) : Princess, why are you here?\n",
               "Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
               " Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
               "(Player) : Princess, you shouldn't be here.\n",
               "(Player) : This forest was inhabited by goblins. They are also very dangerous.\n",
               "(Player) : You should hurry out of here.\n",
               "(Player) : Let me protect you until you return to the palace?\n",
               "Irene : It's okay, I can remember the way back.\n",
               "Irene : Have a safe journey. (Player)\n"
            });
            Scene scene1_2C2 = new Scene(1.2, 10, new[]
            {
                "(Player) : Salute Princess of the Kingdom of \n",
                "(Player) : Sorry to spoil your manners with the princess.\n",
                "Irene : There is no need to pay great respects.\n",
                "Irene : Keep your head up\n",
                "(Player) : Princess, why are you here?\n",
                "Irene : I don't like the atmosphere in the palace. So I went out for a walk.\n",
                "Irene : Accidentally wandered into the forest So I had to stop walking Otherwise I would have been lost in the deep forest.\n",
                $"{player.Name} : Princess, you shouldn't be here.\n",
                "(Player) : This forest was inhabited by goblins. They are also very dangerous.\n",
                "(Player) : You should hurry out of here.\n",
                "(Player) : Let me protect you until you return to the palace?\n",
                "Irene : It's okay, I can remember the way back.\n",
                "Irene : Have a safe journey. (Player)\n"
            });
            Scene scene1_3 = new Scene(1.3, 10, new[]
                {
                    "Narrator : Princess Irene said goodbye to you and returned to the way she came.\n",
                    "??? : Ahhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh. Help me!!\n",
                    "Narrator : Someone is crying for help. Will you help me?\n" 
                    
                });
            Scene scene1_3C1 = new Scene(1.3, 10, new[]
            {
                "\n",
                //skip to scene2
            });
            Scene scene1_3C2 = new Scene(1.3, 10, new[]
            {
                "Ending1 - Developer Frame\n",
                "Narrator : You walked backwards from the cry for help. After that\n",
                "Narrator : a loud scream rang out in the forest following behind him.\n",
                "Narrator :  and the cry for help was silenced.\n"
            });
            Scene scene2_1 = new Scene(2.1, 10, new[]
            {
                "Narrator The goblins are besieging the princess.\n",
                "[Dialogue]\n",
                "Irene : Help me!!\n",
                "(Player) : There are too many of them. If I break in without a weapon, I'm sure I will lose.\n",
                "(Player) : (Equitable Item Set) must be prepared first.\n"
            });
            Scene scene2_2 = new Scene(2.2, 10, new[]
            {
                "(Player) : Oh hey! Where has the princess gone?\n",
                "(Player) : Where has the princess gone? I haven't shown off my coolness yet.\n",
                "(Player) : If I had to guess, they would have taken the princess to the Goblin Castle. in order to bring the princess to their king\n",
                "(Player) : Wait, which way is Goblin Castle?\n",
                "(Player) : Ah crap. After getting cool, I don't know the way anymore. If someone can guide me that would be great.\n"
            });
            Scene scene3_1 = new Scene(3.1, 10, new[]
            {
                "Narrator  You have told Annie about the previous incident.\n",
                "Annie : ok i get it.\n",
                "Annie : Goblin again? Do they think they own the forest?\n",
                "Annie : It's not just humans that are hurt by them. The goblins also attacked my friends. Everyone panicked and ran away.\n",
                "Annie : So now I have to be alone. And I don't even know where the other fairies are.\n",
                "(Player) : If so, would you like to go with me?\n",
                "Annie : Why should I go with you!\n",
                "(Player) : I don't know. Maybe during the journey to save the princess. I might even meet another fairy.\n",
                "(Player) : But as you wish, I'll leaving now\n",
                "Annie : Wait! I'll go with you.\n",
                "Annie : Where do you want to go? I'm an expert in this forest. Wherever it is, I know it all!\n",
                "(Player) : Okay, so where's the Goblin Castle?\n",
                "Annie : Just go left! Or on the right! Maybe.... I don't know, who wants to go for a walk around the Goblin Castle!\n",
                "(Player) : Be quiet! Behind you have a goblin.\n",
                "Annie : Come on!! Who's afraid?!!\n",
                "Goblin : Hokpip!?\n",
                "(Player) : Wait! The fighter is me!\n",
            });

            
                





            //game controller Declaration
            GameController gameController = new GameController();


            //Method
            gameController.Menu();
            //Select Class
            switch (gameController.SelectClass())
            {
                case 1:
                {
                    player = new Magician(gameController.GetName(), 12, 12, 0, 12, 3, true, true, true);
                    break;
                }
                case 2:
                {
                    player = new Swordsman(gameController.GetName(), 12, 12, 0, 9, 5, true, true, true);
                    break;
                }
                case 3:
                {
                
                    player = new Volunteer(gameController.GetName(), 15, 12, 0, 9, 3, true, true, true);
                    break;
                }
            }
            
            
            
            gameController.CombatPhase(player, goblinGuard, inventory.Items, fullinventory.Items, combat);
            
            
            //Debug
            player.Stats();
            //Scene1
            scene1_1.DisplayScene();
            //Scene1 Choice1
            if (gameController.ChoiceSelector(scene1_1.SceneIndex) == 1)
            {
                scene1_1C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1_1.SceneIndex) == 2)
            {
                scene1_1C2.DisplayScene();
            }
            if (gameController.ChoiceSelector(scene1_2.SceneIndex) == 1)
            {
                scene1_2C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1_2.SceneIndex) == 2)
            {
                scene1_2C2.DisplayScene();
            }
            if (gameController.ChoiceSelector(scene1_3.SceneIndex) == 1)
            {
                scene1_3C1.DisplayScene();
            }
            else if(gameController.ChoiceSelector(scene1_3.SceneIndex) == 2)
            {
                scene1_3C2.DisplayScene();
            }
            
            



            gameController.SelectSet(player, atkset, mpset, hpset, balanceset);
            
            inventory.OpenInventory();
            
            
            
            
            
        }
    }
}