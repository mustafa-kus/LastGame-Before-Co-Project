using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    class GameStoreManager
    {
        public void Add(GameStore game)
        {
            Console.WriteLine("Game Added:" + game.GameName);
        }
        public void Update(GameStore game)
        {
            Console.WriteLine("Game Info Updated:" + game.GameName);
        }
        public void Delete(GameStore game)
        {
            Console.WriteLine("Game Deleted:" + game.GameName);
        }
    }
}
