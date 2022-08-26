using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitInStock { get; set; }
    }
}
