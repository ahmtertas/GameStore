using SellGameSmulation.Concrete;
using SellGameSmulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation.Abstract
{
    public interface ISaleService
    {
        void Sell(Game game, Gamer gamer);
    }
}
