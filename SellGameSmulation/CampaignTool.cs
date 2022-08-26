using SellGameSmulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellGameSmulation
{
    public class CampaignTool
    {       
        public static decimal CampaignApp(Campaign campaign,Game game)
        {
            var rate = campaign.CampaignRate;
            var price = game.UnitPrice;
            var result = price - price * rate;
            return result;
        }
    }
}
