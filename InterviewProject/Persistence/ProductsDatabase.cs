using InterviewProject.Model;

namespace InterviewProject.Persistence;

internal class ProductsDatabase : IProductsDatabase
{
    private Dictionary<Guid, Product> _products = new();

    public void Add(Product product)
    {
        Guid id = Guid.NewGuid();
        _products.Add(id, product);
    }

    public void Delete(Guid id) => _products.Remove(id);

    public Product Get(Guid id) => _products[id];

    public IEnumerable<Product> GetAll() => _products.Values;

    public Product? GetByName(string name) =>
        _products.Values.FirstOrDefault(p => p.Name == name);

    public void Update(Guid id, Product product) => _products[id] = product;

    

}
