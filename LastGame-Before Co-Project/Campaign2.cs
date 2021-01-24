using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    class Campaign2 : ICampaignManager
    {
        public int Id { get; set ; }
        public string CampaignName { get; set ; }
        
  
        public void Define(GameStore game)
        {
            Console.WriteLine("{0} {1}  oyunu için tanımlandı.", this.CampaignName, game.GameName);
        }
        public void Delete(GameStore game)
        {
            Console.WriteLine("{0} {1} oyunu için kaldırıldı.", this.CampaignName, game.GameName);
        }

        public void Update(GameStore game)
        {
            Console.WriteLine("{0} {1} oyunu için güncelleştirildi.", this.CampaignName, game.GameName);
        }
    }
}
