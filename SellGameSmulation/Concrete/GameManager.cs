using SellGameSmulation.Abstract;
using SellGameSmulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation.Concrete
{
    public class GameManager : ISaleService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("{0} oynu, {1} tarafından satın alınmıştır.",game.GameName,gamer.FirstName+" "+gamer.LastName);
        }
    }
}
