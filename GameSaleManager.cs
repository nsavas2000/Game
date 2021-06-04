using MinoGame.Abstrack;
using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Concrete
{
    public class GameSaleManager : IGameSaleService

    {
        public void GameSale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satın Alındı");
        }
    }
}
