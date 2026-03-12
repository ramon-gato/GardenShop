using GardenShop.ProductApi.Models;

namespace GardenShop.ProductApi.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<IEnumerable<Category>> GetCategoriesProduct();
    Task<Category> GetById(int id);
    Task<Category> Create(Category category);
    Task<Category> Update(int id, Category category);
    Task<Category> Delete(int id);
}
