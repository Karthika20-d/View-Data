using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineRealEstateEntity;
namespace OnlineRealEstateRepositary
{
    public class LandRepositary
    {
        public static List<Land> land=new List<Land>();
        static LandRepositary()
        {
            land.Add(new Land { landId = 1, area = 3000, propertyType = "Flat", location = "Chennai" });
            land.Add(new Land { landId = 2, area = 4000, propertyType = "Vila", location = "Bangalore" });
            land.Add(new Land { landId = 3, area = 5000, propertyType = "Office Space" , location = "Erode" });
        }
        public static IEnumerable<Land> GetLandDetails()
        {
            return land;
        }
    }
}
