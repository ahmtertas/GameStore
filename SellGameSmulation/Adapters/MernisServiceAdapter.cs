using SellGameSmulation.Adapter;
using SellGameSmulation.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            //Gerçek bağlantı kurmak istediğimde hata alıyorum o sebeple bilgiler doğru kabul edilerek hareket edildi.
            return true; 
        }
    }
}
