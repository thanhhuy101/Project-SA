using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GearClient
{
    public class BrandBUS
    {
        public List<Brand> GetAll()
        {
            List<Brand> brands = new BrandDAO().SelectAll();
            return brands;
        }
        public Brand GetDetails(int BrandGearID)
        {
            Brand brand = new BrandDAO().SelectByCode(BrandGearID);
            return brand;
        }
        public List<Brand> Search(string keyword)
        {
            List<Brand> brands = new BrandDAO().SelectByKeyword(keyword);
            return brands;
        }
        public bool AddNew(Brand newBrand)
        {
            bool result = new BrandDAO().Insert(newBrand);
            return result;
        }
        public bool Update(Brand newBrand)
        {
            bool result = new BrandDAO().Update(newBrand);
            return result;
        }
        public bool Delete(int BrandGearID)
        {
            bool result = new BrandDAO().Delete(BrandGearID);
            return result;
        }

        private BrandDAO sdao = new BrandDAO();
        public DataSet GetAllBrand()
        {
            return sdao.GetAllBrand();
        }
    }
}
