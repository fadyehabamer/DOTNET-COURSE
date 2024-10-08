﻿using Library.Data;
using Library.Models;
using Library.Repository.IRepository;

namespace Library.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategories()
        {

                return _context.Categories.ToList();

        }

        public Category GetCategoryById(int id)
        {

                return _context.Categories.Find(id);

        }

        public void CreateCategory(Category category)
        {

                _context.Categories.Add(category);
                _context.SaveChanges();

        }

        public void UpdateCategory(Category category)
        {

                _context.Categories.Update(category);
                _context.SaveChanges();

        }

        public void DeleteCategory(int id)
        {

                var category = _context.Categories.Find(id);
                _context.Categories.Remove(category);
                _context.SaveChanges();


        }






    }
}

