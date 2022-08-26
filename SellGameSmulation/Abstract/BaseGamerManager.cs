using SellGameSmulation.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to gamer : " + gamer.FirstName+" "+gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} deleted." + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated : " + gamer.FirstName+" "+gamer.LastName);
        }
    }
}
