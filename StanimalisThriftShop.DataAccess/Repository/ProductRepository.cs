using StanimalisThriftShop.DataAccess.Data;
using StanimalisThriftShop.DataAccess.Repository.IRepository;
using StanimalisThriftShop.Models;

namespace StanimalisThriftShop.DataAccess.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
	private ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



	public void Update(Product obj)
	{
		_db.Products.Update(obj);
	}
}
