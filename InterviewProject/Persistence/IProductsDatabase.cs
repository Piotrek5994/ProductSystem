using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewProject.Model;

namespace InterviewProject.Persistence;

internal interface IProductsDatabase
{
    Product Get(Guid id);
    Product? GetByName(string name);
    IEnumerable<Product> GetAll();
    void Add(Product product);
    void Update(Guid id, Product product);

    //We don't need delete method but leave it just in case
    void Delete(Guid id);
}
