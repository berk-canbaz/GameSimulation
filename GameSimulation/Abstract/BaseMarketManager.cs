using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public class BaseMarketManager : IMarketService
    {
        public void Buy(GameProducts product, User user)
        {
            Console.WriteLine("Ürün başarıyla satın alındı: " + product.Name + "\nÜrün Tutarı: " + product.Price);
        }

        public void Return(GameProducts product, User user)
        {
            Console.WriteLine("Ürün başarıyla iade edildi: " + product.Name + "\nİade Tutarı: " + product.Price);
        }
    }
}
