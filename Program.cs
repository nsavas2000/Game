using MinoGame.Concrete;
using MinoGame.Entities;
using MinoGame.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game1 = new Game();
            game1.Id = 36;
            game1.GameName = "Mino";
            game1.GamePrice = 854;

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Aliş";
            customer1.LastName = "Soy";
            customer1.NationalityId = 12345;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "FırsatGünü";
            campaign1.DiscountRate = 25;



            CustomerManager customerManager = new CustomerManager(new VerificationManager());
            customerManager.Add(customer1);

            

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);


            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.GameSale(customer1, game1, campaign1);
           

            Console.ReadLine();


        }
    }
}
