using MinoGame.Abstrack;
using MinoGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinoGame.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Güncellendi");
        }
    }
}
