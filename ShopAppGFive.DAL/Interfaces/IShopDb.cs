using System.Collections.Generic;
using Shop.DAL.Models;

namespace Shop.DAL.Interfaces
{
    public interface IShopDb
    {
        List<CategoryModel> GetCategories();
        CategoryModel GetCategory(int categoryId);
        void SaveCategory(CategoryAddModel categoryAdd);
        void UpdateCategory(CategoryUpdateModel categoryUpdate);
        void RemoveCategory(CategoryRemoveModel categoryRemove);
    }
}
