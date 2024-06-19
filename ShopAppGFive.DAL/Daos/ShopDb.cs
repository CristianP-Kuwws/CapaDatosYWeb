using System.Collections.Generic;
using System.Linq;
using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models;
using ShopAppGFive.DAL.Entities;

namespace Shop.DAL.Daos
{
    public class ShopDb : IShopDb
    {
        private readonly ShopContext _context;

        public ShopDb(ShopContext context)
        {
            _context = context;
        }

        public List<CategoryModel> GetCategories()
        {
            return _context.Categories
                .Select(c => new CategoryModel
                {
                    categoryid = c.categoryid,
                    categoryname = c.categoryname,
                    description = c.description
                }).ToList();
        }

        public CategoryModel GetCategory(int categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            if (category == null)
            {
                return null;
            }

            return new CategoryModel
            {
                categoryid = category.categoryid,
                categoryname = category.categoryname,
                description = category.description
            };
        }

        public void SaveCategory(CategoryAddModel categoryAdd)
        {
            var category = new ConcreteCategory
            {
                categoryname = categoryAdd.categoryname,
                description = categoryAdd.description
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(CategoryUpdateModel categoryUpdate)
        {
            var category = _context.Categories.Find(categoryUpdate.categoryid);
            if (category != null)
            {
                category.categoryname = categoryUpdate.categoryname;
                category.description = categoryUpdate.description;

                _context.Categories.Update(category);
                _context.SaveChanges();
            }
        }

        public void RemoveCategory(CategoryRemoveModel categoryRemove)
        {
            var category = _context.Categories.Find(categoryRemove.categoryid);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
