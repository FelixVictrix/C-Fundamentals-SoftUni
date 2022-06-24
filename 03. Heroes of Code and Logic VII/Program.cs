using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> listOfHeroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {

                string[] heroInfo = Console.ReadLine().Split();
                string name = heroInfo[0];
                int hitPoint = int.Parse(heroInfo[1]);
                int manaPoint = int.Parse(heroInfo[2]);

                if (!listOfHeroes.ContainsKey(name))
                {
                    listOfHeroes.Add(name, new List<int>());
                }
                listOfHeroes[name].Add(hitPoint);
                listOfHeroes[name].Add(manaPoint);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                string name = commands[1];

                if (action == "CastSpell")
                {
                    int manaNeeded = int.Parse(commands[2]);
                    string spell = commands[3];

                    string isCast = listOfHeroes[name][1] >= manaNeeded
                        ? $"{name} has successfully cast {spell} and now has {listOfHeroes[name][1] -= manaNeeded} MP!"
                        : $"{name} does not have enough MP to cast {spell}!";

                    Console.WriteLine(isCast);
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(commands[2]);
                    string attacker = commands[3];

                    var isDamage = listOfHeroes[name][0] >= damage
                        ? $"{name} was hit for {damage} HP by {attacker} and now has {listOfHeroes[name][0] -= damage} HP left!"
                        : $"{name} has been killed by {attacker}!";
                    

                    Console.WriteLine(isDamage);
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(commands[2]);
                    int recharged = 200 - listOfHeroes[name][1];

                    var isRecharged = listOfHeroes[name][1] + amount <= 200
                        ? $"{name} recharged for {amount} MP!"
                        : $"{name} recharged for {recharged} MP!";

                    Console.WriteLine(isRecharged);
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(commands[2]);
                    int healed = 100 - listOfHeroes[name][0];

                    var isHealed = listOfHeroes[name][0] + amount <= 100
                        ? $"{name} healed for {amount} HP!"
                        : $"{name} healed for {healed} HP!";

                    Console.WriteLine(isHealed);
                }
                input = Console.ReadLine();
            }
            if (listOfHeroes.Any())
            {
                foreach (var hero in listOfHeroes)
                {
                    Console.WriteLine($"{hero.Key}\nHP: {hero.Value[0]}\nMP: {hero.Value[1]}");
                }
            }
        }
    }
}
