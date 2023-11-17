using System.Linq;

namespace ShopApp.Models {
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }
    }
}
