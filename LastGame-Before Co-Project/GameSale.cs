using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    class GameSale
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int CampaignId { get; set; }
    }
}
