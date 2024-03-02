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
		var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
		if(objFromDb != null)
		{
			objFromDb.Name = obj.Name;
			objFromDb.ListPrice = obj.ListPrice;
			objFromDb.Description = obj.Description;
			objFromDb.CategoryId = obj.CategoryId;
			if (obj.ImageUrl != null)
			{
				objFromDb.ImageUrl = obj.ImageUrl;
			}
		}
	}
}
