using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearClient
{
    public class GearBUS
    {
        private GearDAO dao = new GearDAO();
        List<Gear> gears = new List<Gear>();
        public List<Gear> GetAll()
        {
            List<Gear> gears = new GearDAO().SelectAll();
            return gears;
        }
        public Gear GetDetails(int GearID)
        {
            Gear gear = new GearDAO().SelectByCode(GearID);
            return gear;
        }
        public List<Gear> Search(string keyword)
        {
            List<Gear> gears = new GearDAO().SelectByKeyword(keyword);
            return gears;
        }
        public bool AddNew(Gear newGear)
        {
            bool result = new GearDAO().Insert(newGear);
            return result;
        }
        public bool Update(Gear newGear)
        {
            bool result = new GearDAO().Update(newGear);
            return result;
        }
        public bool Delete(int GearID)
        {
            bool result = new GearDAO().Delete(GearID);
            return result;
        }

        public DataSet getallGear()
        {
            return dao.getAllData();
        }
       
    }
}
