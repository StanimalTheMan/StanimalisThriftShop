using StanimalisThriftShop.Models;

namespace StanimalisThriftShop.DataAccess.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
	void Update(Product obj);
}
