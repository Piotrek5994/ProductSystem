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

    public Guid Id { get; }

    public double PlnPrice { get; }

    public double EurPrice { get; }

    public double UsdPrice { get; }

    public DateTime DateAdded { get; }
    public string? Name { get; }
    public string? Description { get; }
    public double Price { get; }
}
