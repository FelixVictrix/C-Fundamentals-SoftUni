using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Heroes_of_Code_and_Logic_VII_Objects
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());

            Action action1 = new Action();

            for (int i = 0; i < lenght; i++)
            {
                var heroeInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = heroeInfo[0];
                var hp = int.Parse(heroeInfo[1]);
                var mp = int.Parse(heroeInfo[2]);

                action1.Add(new Heroe(name, hp, mp));

            }

            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];
                var name = command[1];

                switch (action)
                {
                    case "CastSpell":
                        var mpNeeded = int.Parse(command[2]);
                        var spellName = command[3];
                        action1.CastSpell(name, mpNeeded, spellName);
                        break;
                    case "TakeDamage":
                        var damage = int.Parse(command[2]);
                        var attacker = command[3];
                        action1.TakeDamage(name, damage, attacker);
                        break;
                    case "Recharge":
                        var amount = int.Parse(command[2]);
                        action1.Recharge(name, amount);
                        break;
                    case "Heal":
                        amount = int.Parse(command[2]);
                        action1.Heal(name, amount);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(action1.ToString());
        }
    }
    public class Heroe
    {

        public Heroe(string name, int hP, int mP)
        {
            Name = name;
            HP = hP;
            MP = mP;

        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

    }
    public class Action
    {
        private List<Heroe> heroes = new List<Heroe>();

        public void Add(Heroe heroe)
        {
            heroes.Add(heroe);
        }
        public void CastSpell(string name, int mpNeeded, string spellName)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.MP >= mpNeeded)
            {
                currHeroe.MP -= mpNeeded;
                Console.WriteLine($"{currHeroe.Name} has successfully cast {spellName} and now has {currHeroe.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{currHeroe.Name} does not have enough MP to cast {spellName}!");
            }

        }
        public void TakeDamage(string name, int damage, string attacker)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.HP - damage > 0)
            {
                currHeroe.HP -= damage;
                Console.WriteLine($"{currHeroe.Name} was hit for {damage} HP by {attacker} and now has {currHeroe.HP} HP left!");
            }
            else
            {
                Console.WriteLine($"{currHeroe.Name} has been killed by {attacker}!");
                heroes.Remove(currHeroe);
            }
        }
        public void Recharge(string name, int amount)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.MP + amount <= 200)
            {
                currHeroe.MP += amount;
                Console.WriteLine($"{currHeroe.Name} recharged for {amount} MP!");
            }
            else
            {
                amount = 200 - currHeroe.MP;
                currHeroe.MP = 200;
                Console.WriteLine($"{currHeroe.Name} recharged for {amount} MP!");
            }
        }
        public void Heal(string name, int amount)
        {
            var currHeroe = heroes.FirstOrDefault(n => n.Name == name);
            if (currHeroe.HP + amount <= 100)
            {
                currHeroe.HP += amount;
                Console.WriteLine($"{currHeroe.Name} healed for {amount} HP!");
            }
            else
            {
                amount = 100 - currHeroe.HP;
                currHeroe.HP = 100;
                Console.WriteLine($"{currHeroe.Name} healed for {amount} HP!");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in heroes)
            {
                sb.AppendLine(item.Name);
                sb.AppendLine($" HP: {item.HP}");
                sb.AppendLine($" MP: {item.MP}");
            }
            return sb.ToString().TrimEnd();
        }
    }

}
