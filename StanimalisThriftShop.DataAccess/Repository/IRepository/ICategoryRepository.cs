using StanimalisThriftShop.Models;

namespace StanimalisThriftShop.DataAccess.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
	void Update(Category obj);
	void Save();
}
