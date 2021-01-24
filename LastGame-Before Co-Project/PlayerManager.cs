using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            if (CheckPersonalId(player))
            {
                Console.WriteLine("Player Registered:" + player.Name);
            }
            else
            {
                Console.WriteLine("Player not Registered:" + player.Name);
            }
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player Updated:" + player.Name);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player Deleted:" + player.Name);
        }
        private bool CheckPersonalId(Player player)
        {
            List<string> Persons = new List<string> { "123456789012", "111234567890" };
            bool check = false;
            foreach (var person in Persons)
            {
                if (person == player.PersonalID)
                {
                    check = true;
                }

            }
            return check;
        }

    }
}
