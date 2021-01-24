using System;

namespace LastGame_Before_Co_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oyunlar Magaza stoguna giriyor");
            Console.WriteLine("------------------------------");
            // Oyunlar Magaza stoguna giriyor
            GameStore game1 = new GameStore();
            game1.Id = 1;
            game1.GameName = "Space Empires Starfury";
            game1.Price = 20;
            game1.Stock = 10;
            GameStore game2 = new GameStore();
            game2.Id = 2;
            game2.GameName = "Minecraft";
            game2.Price = 10;
            game2.Stock = 20;
            GameStoreManager gameStoreManager = new GameStoreManager();
            gameStoreManager.Add(game1);
            gameStoreManager.Add(game2);
            gameStoreManager.Update(game1);
            gameStoreManager.Delete(game2);

            Console.WriteLine();
            Console.WriteLine("Oyuncular Sisteme sahil ediliyor");
            Console.WriteLine("------------------------------");
            //Oyuncular Sisteme sahil ediliyor
            Player player1 = new Player();
            player1.Id = 1;
            player1.PersonalID = "123456789012";
            player1.Name = "Ali";
            player1.Surname = "var";
            player1.BirthYear = 1990;
            Player player2 = new Player();
            player2.Id = 2;
            player2.PersonalID = "121234567890";
            player2.Name = "Ayşe";
            player2.Surname = "var";
            player2.BirthYear = 1993;
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Update(player1);
            playerManager.Delete(player1);

            Console.WriteLine();
            Console.WriteLine("Kampanyalar tanımlanıyor");
            Console.WriteLine("------------------------------");
            // Kampanyalar tanımlanıyor
            ICampaignManager campaign1 = new Campaign1();
            campaign1.Id = 1;
            campaign1.CampaignName = "Aralık Kampanyası";
            campaign1.Define(game1);
            campaign1.Update(game1);

            ICampaignManager campaign2 = new Campaign2();
            campaign2.Id = 2;
            campaign2.CampaignName = "Dünya Oyun Günü Kampanyası";
            campaign2.Define(game2);
            campaign2.Delete(game2);

            Console.WriteLine();
            Console.WriteLine("Tüm işlemler tamamlandı.");
        }
    }
}
