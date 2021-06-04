using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Abstrack
{
    public interface IGameSaleService
    {
        void GameSale(Customer customer, Game game, Campaign campaign);
    }
}
