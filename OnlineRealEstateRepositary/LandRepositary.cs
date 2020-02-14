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
        public static List<Land> lands=new List<Land>();
        static LandRepositary()
        {
            lands.Add(new Land { landId = 1, area = 3000, propertyType = "Flat", location = "Chennai" });
            lands.Add(new Land { landId = 2, area = 4000, propertyType = "Vila", location = "Bangalore" });
            lands.Add(new Land { landId = 3, area = 5000, propertyType = "Office Space" , location = "Erode" });
        }
        public static IEnumerable<Land> GetLandDetails()
        {
            return lands;
        }
        public static void Add(Land land)
        {
            lands.Add(land);
        }
        public static void Delete(int landId)
        {
            Land land = GetLandById(landId);
            if (land != null)
                lands.Remove(land);
        }
        public static void Update(Land land)
        {
            Land landValue= lands.Find(id => id.landId == land.landId);
            landValue.landId = land.landId;
            landValue.area = land.area;
            landValue.propertyType = land.propertyType;
            landValue.location = land.location;
        }

        public static Land GetLandById(int landId)
        {
            return lands.Find(id => id.landId == landId);
        }
    }
}
