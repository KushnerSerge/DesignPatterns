// See https://aka.ms/new-console-template for more information


public interface IProductOptions
{
    IProductOptions WithDescrption(Func<string> desciptionDelegate);
    string GetDescription();
}

public class ProductFactory
{
    public static Product CreateNewProduct(string name, long price, IList<long> categoryIds,
                                           Action<IProductOptions> optionalParams)
    {
        var options = new ProductOptions();
        if (optionalParams != null)
            optionalParams(options);
        string description = options.GetDescription();
        if (string.IsNullOrWhiteSpace(description))
            description = "No Description available";

        var product = new Product(name, description, price, 0, categoryIds);
        OnProductCreation(product);
        return product;
    }
    public static Product CreateExportedProduct(string name, long price, long ranking, IList<long> categoryIds,
                                                    Action<IProductOptions> optionalParams)
    {
        var options = new ProductOptions();
        if (optionalParams != null)
            optionalParams(options);
        string description = options.GetDescription();
        if (string.IsNullOrWhiteSpace(description))
            description = "No Description available";

        var product = new Product(name, description, price, ranking, categoryIds);
        OnProductCreation(product);
        return product;
    }

    public static void OnProductCreation(Product product)
    {
        //send newsletter
    }
    public class ProductOptions : IProductOptions
    {
        private string _description;

        public IProductOptions WithDescrption(Func<string> desciptionDelegate)
        {
            _description = desciptionDelegate();
            return this;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}

public class Client
{
    public IList<Product> GetNewProducts(int number)
    {
        for (long i = 0; i < number; i++)
        {
            var product = ProductFactory.CreateNewProduct(string.Format("Product {0}", i), i, i,
                                                          opt => opt.WithDescrption(() => "Description"));
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
    public long Ranking { get; set; }
    public IList<long> CategoryIds { get; set }
}



