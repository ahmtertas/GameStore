using SellGameSmulation.Adapter;
using SellGameSmulation.Concrete;
using SellGameSmulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation
{
    internal class SimulationClass
    {
        static void Main(string[] args)
        {
            //Gamerlar
            Gamer gamer1 = new Gamer 
            {
                Id = 1,
                NationalId = "124545656",
                FirstName = "Dele",
                LastName = "Alle",
                YearOfBirth = "1997"

            };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                NationalId = "524987861",
                FirstName = "Sergio",
                LastName = "Ramos",
                YearOfBirth = "1989"

            };

            Gamer gamer3 = new Gamer
            {
                Id = 3,
                NationalId = "434987861",
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                YearOfBirth = "1988"

            };
            //Gamer ekleme işlemi
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);

            Console.WriteLine("---------------------------------");

            //Satılacak oyunlarımızın stocklanma işlemi
            Game game1 = new Game 
            {
                GameId=1,
                CategoryId=1,
                GameName="CounterStrike-GlobalOffensive",
                UnitPrice=150,
                UnitInStock=30

            };

            Game game2 = new Game
            {
                GameId = 2,
                CategoryId = 3,
                GameName = "LeageuOfLegends",
                UnitPrice = 270,
                UnitInStock = 15

            };

            Game game3 = new Game
            {
                GameId = 3,
                CategoryId = 7,
                GameName = "CallOfDutyBlackOps",
                UnitPrice = 120,
                UnitInStock = 10
            };
            Console.WriteLine("{0} oynu satışa sunuldu.",game1.GameName);
            Console.WriteLine("{0} oynu satışa sunuldu.", game2.GameName);
            Console.WriteLine("{0} oynu satışa sunuldu.", game3.GameName);

            Console.WriteLine("---------------------------------");
            Campaign campaign1 = new Campaign 
            {               
                CampaignName="BaharKampanyası",
                CampaignRate=0.10m
            };
            Campaign campaign2 = new Campaign
            {
                CampaignName = "YazTatiliKampanyasi",
                CampaignRate = 0.25m
            };

            GameCampaignManager gameCampaignManager = new GameCampaignManager();
            gameCampaignManager.Add(campaign1);
            gameCampaignManager.Add(campaign2);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("{0} oynuna {1} uygulandı, oyun fiyatı = {2}TL indirimli fiyatı= {3}TL"
                ,game1.GameName, campaign1.CampaignName,game1.UnitPrice, 
                CampaignTool.CampaignApp(campaign1, game1));

            Console.WriteLine("{0} oynuna {1} uygulandı, oyun fiyatı = {2}TL indirimli fiyatı= {3}TL"
                , game2.GameName, campaign2.CampaignName, game2.UnitPrice,
                CampaignTool.CampaignApp(campaign2, game2));
            Console.WriteLine("--------------------------------");
            GameManager gameManager = new GameManager();
            gameManager.Sell(game1,gamer1);
            gameManager.Sell(game3, gamer2);
            gameManager.Sell(game2, gamer3);

            Console.ReadLine();
        }
    }
}
