using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _09.OnlineMarket
{
    class Program
    {
        public class Product : IComparable<Product>
        {
            public string Name { get; private set; }

            public decimal Price { get; set; }

            public string Type { get; private set; }

            public static Product Parse(IList<string> productData)
            {
                return new Product
                {
                    Name = productData[0],
                    Price = decimal.Parse(productData[1]),
                    Type = productData[2]
                };
            }

            public int CompareTo(Product other)
            {
                var priceCompareResult = this.Price.CompareTo(other.Price);
                if (priceCompareResult == 0)
                {
                    var namesCompareResult = this.Name.CompareTo(other.Name);
                    if (namesCompareResult == 0)
                    {
                        return this.Type.CompareTo(other.Type);
                    }
                    else
                    {
                        return namesCompareResult;
                    }
                }
                else
                {
                    return priceCompareResult;
                }


            }

            public override string ToString()
            {
                return string.Format("{0}({1:G29})", this.Name, this.Price);
            }
        }

        public class Command
        {
            public string Name { get; set; }
            public IList<string> Parameters { get; set; }
            public static Command Parse(string commandLine)
            {
                string[] commandItems = commandLine.Split(' ');

                string commandName = commandItems[0];

                var parameters = new List<string>();
                for (int i = 1; i < commandItems.Length; i++)
                {
                    parameters.Add(commandItems[i]);
                }

                return new Command { Name = commandName, Parameters = parameters };
            }

        }

        public class Filter
        {
            private readonly IDictionary<string, Product> productByName;
            private readonly IDictionary<string, SortedSet<Product>> productByType;
            private readonly SortedSet<Product> productByPrice;

            public Filter()
            {
                this.productByName = new Dictionary<string, Product>();
                this.productByType = new Dictionary<string, SortedSet<Product>>();
                this.productByPrice = new SortedSet<Product>();
            }

            public bool Add(Product product)
            {
                if (productByName.ContainsKey(product.Name))
                {
                    return false;
                }

                this.productByName[product.Name] = product;

                if (!this.productByType.ContainsKey(product.Type))
                {
                    this.productByType[product.Type] = new SortedSet<Product>();
                }

                this.productByType[product.Type].Add(product);
                this.productByPrice.Add(product);

                return true;
            }

            public IEnumerable<Product> FilterByType(string type)
            {
                if (!this.productByType.ContainsKey(type))
                {
                    return Enumerable.Empty<Product>();
                }
                return this.productByType[type].Take(10);
            }

            public IEnumerable<Product> FilterFromMinPrice(decimal minPrice)
            {
                return this.productByPrice.Where(x => x.Price >= minPrice).Take(10);
            }

            public IEnumerable<Product> FilterToMaxPrice(decimal maxPrice)
            {
                return this.productByPrice.Where(x => x.Price <= maxPrice).Take(10);
            }

            public IEnumerable<Product> FilterFromMinToMaxPrice(decimal minPrice, decimal maxPrice)
            {
                return this.productByPrice.Where(x => x.Price >= minPrice && x.Price <= maxPrice).Take(10);
            }
        }

        static void Main(string[] args)
        {
            Filter filter = new Filter();
            StringBuilder builder = new StringBuilder();

            string line = Console.ReadLine();

            while (line != "end")
            {
                Command command = Command.Parse(line);

                switch (command.Name)
                {
                    case "add":
                        Product product = Product.Parse(command.Parameters);
                        if (filter.Add(product))
                        {
                            builder.AppendLine(string.Format("Ok: Product {0} added successfully", product.Name));
                        }
                        else
                        {
                            builder.AppendLine(string.Format("Error: Product {0} already exists", product.Name));
                        }
                        break;
                    case "filter":

                        switch (command.Parameters[1])
                        {
                            case "type":

                                string type = command.Parameters[2];
                                IEnumerable<Product> products = filter.FilterByType(type);
                                if (products.Count() == 0)
                                {
                                    builder.AppendLine(string.Format("Error: Type {0} does not exists", type));
                                }
                                else
                                {
                                    builder.AppendLine(string.Format(
                                        "Ok: {0}", string.Join(", ", products)).Normalize());
                                }

                                break;
                            case "price":
                                switch(command.Parameters[2])
                                {
                                    case "to":
                                        decimal price = decimal.Parse(command.Parameters[3]);
                                        IEnumerable<Product> productsAfterFilter = filter.FilterToMaxPrice(price);
                                        builder.AppendLine(string.Format(
                                            "Ok: {0}", string.Join(", ", productsAfterFilter)));
                                        break;
                                    case "from":
                                        if(command.Parameters.Count == 6)
                                        {
                                            decimal minPrice = decimal.Parse(command.Parameters[3]);
                                            decimal maxPrice = decimal.Parse(command.Parameters[5]);
                                            IEnumerable<Product> productsAfterFilter2 = filter.FilterFromMinToMaxPrice(minPrice, maxPrice);
                                            builder.AppendLine(string.Format(
                                                "Ok: {0}", string.Join(", ", productsAfterFilter2)));
                                        }
                                        else
                                        {
                                            decimal price2 = decimal.Parse(command.Parameters[3]);
                                            IEnumerable<Product> productsAfterFilter3 = filter.FilterFromMinPrice(price2);

                                            builder.AppendLine(string.Format(
                                                "Ok: {0}", string.Join(", ", productsAfterFilter3)));
                                        }
                                        break;
                                    default:
                                        break;
                                        
                                }
                                
                                break;
                            default:
                                break;
                        }                        


                        break;
                    default:
                        break;
                };
                line = Console.ReadLine();
            }
            Console.WriteLine(builder.ToString().Trim());
        }
    }
}
