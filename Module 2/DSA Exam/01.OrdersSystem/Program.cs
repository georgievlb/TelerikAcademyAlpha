using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;


namespace OrdersSystem
{
    class Program
    {
        public class Order : IComparable<Order>
        {
            public string Name { get; private set; }

            public decimal Price { get; set; }

            public string Consumer { get; private set; }

            public static Order Parse(IList<string> orderData)
            {
                return new Order
                {
                    Name = orderData[0],
                    Price = decimal.Parse(orderData[1]),
                    Consumer = orderData[2]
                };
            }

            public int CompareTo(Order other)
            {

                //first ordered by name in ascending order
                var result = this.ToString().CompareTo(other.ToString());
                return result;


                //var orderCompareResult = this.Name.CompareTo(other.Name);
                //if (orderCompareResult == 0)
                //{
                //    var namesCompareResult = this.Consumer.CompareTo(other.Consumer);
                //    if (namesCompareResult == 0)
                //    {
                //        return this.Price.CompareTo(other.Price);
                //    }
                //    else
                //    {
                //        return namesCompareResult;
                //    }
                //}
                //else
                //{
                //    return orderCompareResult;
                //}
            }

            public override string ToString()
            {
                return string.Format("{{{0};{1};{2:0.00}}}", Name, Consumer, Price);
            }
        }

        public class Command
        {
            public string Name { get; set; }
            public IList<string> Parameters { get; set; }
            public static Command Parse(string commandLine)
            {
                int whereIsTheFirstWhiteSpace = commandLine.IndexOf(' ');
                string commandName = commandLine.Substring(0, whereIsTheFirstWhiteSpace);
                string newCommandLine = commandLine.Substring(whereIsTheFirstWhiteSpace + 1);
                string[] commandItems = newCommandLine.Trim().Split(';');

                var parameters = new List<string>();
                for (int i = 0; i < commandItems.Length; i++)
                {
                    parameters.Add(commandItems[i]);
                }

                return new Command { Name = commandName, Parameters = parameters };

            }

        }

        public class Find
        {
            private readonly IDictionary<string, SortedSet<Order>> orderByUser;
            private readonly SortedSet<Order> orderByPrice;
            //SortedSet - само по едно нещо; все едно хешсет и лист

            public Find()
            {
                this.orderByUser = new Dictionary<string, SortedSet<Order>>();
                this.orderByPrice = new SortedSet<Order>();
            }

            public void Add(Order order)
            {
                if (!orderByUser.ContainsKey(order.Consumer))
                {
                    orderByUser.Add(order.Consumer, new SortedSet<Order>());
                }
                orderByUser[order.Consumer].Add(order);
                orderByPrice.Add(order);
                Console.WriteLine("Order added");
            }

            public void ViewOrders(string consumer)
            {
                StringBuilder keysAndValues = new StringBuilder();
                if (orderByUser.ContainsKey(consumer))
                {
                    foreach (var key in orderByUser[consumer])
                    {
                        keysAndValues.AppendLine(key.ToString());
                    }
                }
                else
                {//var values3 = orderByUser.Where(x => x.Key.Equals(consumer)).Select(x => x.Value).ToArray();
                    keysAndValues.AppendLine("No orders found");
                }
                Console.Write(keysAndValues.ToString());
            }

            public void DeleteOrders(string consumer)
            {
                if (orderByUser.ContainsKey(consumer))
                {   
                    Console.WriteLine("{0} orders deleted", orderByUser[consumer].Count());
                    orderByUser.Remove(consumer);
                }
                else
                {
                    Console.WriteLine("No orders found");
                }
            }

            public void FilterFromMinToMaxPrice(decimal minPrice, decimal maxPrice)
            {
                var priceRange = this.orderByPrice.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
                if (priceRange.Count != 0)
                Console.WriteLine(string.Join("\n", priceRange));

                else
                    Console.WriteLine("No orders found");
            }

        }

        static void Main(string[] args)
        {
            Find find = new Find();
            int numberOfCommands = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int counterOfCommands = 0;

            while (counterOfCommands < numberOfCommands)
            {
                Command command = Command.Parse(line);

                switch (command.Name)
                {
                    case "AddOrder":
                        Order order = Order.Parse(command.Parameters);
                        find.Add(order);
                        break;
                    case "FindOrdersByConsumer":
                        find.ViewOrders(command.Parameters[0]);
                        break;
                    case "DeleteOrders":
                        find.DeleteOrders(command.Parameters[0]);
                        break;
                    case "FindOrdersByPriceRange":
                        decimal minPrice = decimal.Parse(command.Parameters[0]);
                        decimal maxPrice = decimal.Parse(command.Parameters[1]);
                        find.FilterFromMinToMaxPrice(minPrice, maxPrice);
                        break;
                    default:
                        break;
                };

                line = Console.ReadLine();
                counterOfCommands++;
            }
        }
    }
}
