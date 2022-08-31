using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GearClient
{
    public class CategoryBUS
    {
        public List<Category> GetAll()
        {
            List<Category> categories = new CategoryDAO().SelectAll();
            return categories;
        }
        public Category GetDetails(int CategoryID)
        {
            Category category = new CategoryDAO().SelectByCode(CategoryID);
            return category;
        }
        public List<Category> Search(string keyword)
        {
            List<Category> categories = new CategoryDAO().SelectByKeyword(keyword);
            return categories;
        }
        public bool AddNew(Category newCategory)
        {
            bool result = new CategoryDAO().Insert(newCategory);
            return result;
        }
        public bool Update(Category newCategory)
        {
            bool result = new CategoryDAO().Update(newCategory);
            return result;
        }
        public bool Delete(int CategoryID)
        {
            bool result = new CategoryDAO().Delete(CategoryID);
            return result;
        }

        private CategoryDAO cdao = new CategoryDAO();
        public DataSet getAllCategory()
        {
            return cdao.GetAllCategory();
        }
    }
}
