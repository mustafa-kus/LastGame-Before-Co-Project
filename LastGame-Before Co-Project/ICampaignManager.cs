using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    interface ICampaignManager
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        
        void Define(GameStore game);
        void Update(GameStore game);
        void Delete(GameStore game);
    }
}
