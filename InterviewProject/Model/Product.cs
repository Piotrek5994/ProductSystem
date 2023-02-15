namespace InterviewProject.Model;

internal class Product
{
    public Product(string? name, string? description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
        DateAdded = DateTime.Now;
    }

    public Guid Id { get; set; }

    public double PlnPrice { get; set;  }

    public double EurPrice { get; set;  }

    public double UsdPrice { get; set; }

    public DateTime DateAdded { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set;  }
    public double Price { get; set; }
}
