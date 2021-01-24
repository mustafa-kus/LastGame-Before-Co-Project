using System;
using System.Collections.Generic;
using System.Text;

namespace LastGame_Before_Co_Project
{
    class GameSaleManager
    {
        public void OrderBuy(GameSale gameSale)
        {
            Console.WriteLine("Sale Completed. Order ID:"+gameSale.Id);
        }
        public void OrderUpdate(GameSale gameSale)
        {
            Console.WriteLine("Order Updated. Order ID:" + gameSale.Id);
        }
        public void OrderDelete(GameSale gameSale)
        {
            Console.WriteLine("Order Deleted. Order ID:" + gameSale.Id);
        }
    }
}
