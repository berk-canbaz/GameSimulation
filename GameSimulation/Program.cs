using System;
using GameSimulation.Abstract;
using GameSimulation.Adapters;
using GameSimulation.Concrete;
using GameSimulation.Entities;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Kayıt, Güncelleme, Silme
            BaseUserManager basketballGameUserManager = new BasketballGameUserManager();
            BaseUserManager soccerGameUserManager = new SoccerGameUserManager(new MernisServiceAdapter());

            User user1 = new User
            {
                Id = 1,
                FirstName = "Berk",
                LastName = "Canbaz",
                DateOfBirth = new DateTime(1998, 3,26),
                NationalityId = "35395733738"
            };

            User user2 = new User
            {
                Id = 2,
                FirstName = "Mehmet",
                LastName = "Boyraz",
                DateOfBirth = new DateTime(1998, 5, 18),
                NationalityId = "19889228740"
            };

            basketballGameUserManager.Save(user2);
            basketballGameUserManager.Update(user2);
            basketballGameUserManager.Delete(user2);

            soccerGameUserManager.Save(user1);
            soccerGameUserManager.Update(user1);
            soccerGameUserManager.Delete(user1);

            //Satın Alma, İade Etme
            BaseMarketManager marketManager = new BaseMarketManager();

            GameProducts product1 = new GameProducts
            {
                Name = "Kırmızı Futbol Topu",
                Price = 250
            };

            marketManager.Buy(product1, user1);
            marketManager.Return(product1, user1);

            //Kampanya Ekleme, Güncelleme, Silme, Ürün ile Entegrasyon
            BaseCampaignManager campaignManager = new BaseCampaignManager();

            Campaigns campaign1 = new Campaigns
            {
                Campaign = "İki kırmızı top alımında ikincisi yarı fiyatına."
            };

            campaignManager.Add(campaign1, product1);
            campaignManager.Update(campaign1, product1);
            campaignManager.Delete(campaign1, product1);
        }
    }
}
