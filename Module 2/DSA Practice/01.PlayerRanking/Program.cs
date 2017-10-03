using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _01.PlayerRanking
{
    public class Player: IComparable<Player>
    {
        private string name;
        private string type;
        private int age;
        private int position;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public static Player Parse(IList<string> playerData)
        {
            return new Player
            {
                Name = playerData[0],
                Type = playerData[1],
                Age = int.Parse(playerData[2]),
                Position = int.Parse(playerData[3])
            };
        }

        public int CompareTo(Player other)
        {
            //first ordered by name in ascending order
            var result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                //and then by age in descending order 
                result = this.Age.CompareTo(other.Age) * -1;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
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

            return new Command{ Name = commandName, Parameters = parameters };
        }

    }

    public class Ranklist
    {
        private readonly IDictionary<string, SortedSet<Player>> playerByType;
        private readonly BigList<Player> ranklist;

        public Ranklist()
        {
            this.playerByType = new Dictionary<string, SortedSet<Player>>();
            this.ranklist = new BigList<Player>();
        }

        public void Add(Player player)
        {
            if (!this.playerByType.ContainsKey(player.Type))
            {
                this.playerByType[player.Type] = new SortedSet<Player>();
            }
            this.playerByType[player.Type].Add(player);
            this.ranklist.Insert(player.Position - 1, player);
        }

        public IEnumerable<Player> FindByType(string type)
        {
            if (!this.playerByType.ContainsKey(type))
            {
                return Enumerable.Empty<Player>();

            }
            return this.playerByType[type].Take(5);
        }

        public IEnumerable<Player> GetRanklist(int startPosition, int endPosition)
        {
            return this.ranklist.Range(startPosition, endPosition - startPosition + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ranklist ranklist = new Ranklist();
            StringBuilder builder = new StringBuilder();

            string line = Console.ReadLine();
            while(line != "end")
            {
                Command command = Command.Parse(line);
                
                switch(command.Name)
                {
                    case "add":
                        Player player = Player.Parse(command.Parameters);
                        ranklist.Add(player);
                        builder.AppendLine(
                            string.Format("Added player {0} to position {1}", command.Parameters[0], command.Parameters[3]));
                    break;

                    case "find":
                        string type = command.Parameters[0];
                        IEnumerable<Player> players = ranklist.FindByType(type);
                        builder.AppendLine(string.Format(
                            "Type {0}: {1}", type, string.Join("; ", players)));
                        break;

                    case "ranklist":
                        int startPosition = int.Parse(command.Parameters[0]) - 1;
                        int endPosition = int.Parse(command.Parameters[1]) - 1;
                        var playersRanklist = ranklist.GetRanklist(startPosition, endPosition).Select(p => new { Position = ++startPosition, Player = p }).ToList();
                        builder.AppendLine(string.Join("; ", playersRanklist.Select(r => string.Format("{0}. {1}", r.Position, r.Player))));



                        break;
                    default:
                    break;

                }

                line = Console.ReadLine();
            }
            Console.WriteLine(builder.ToString().Trim());
        }
    }
}

//Player player1 = new Player("Ivan", "Aggressive", 20, 3);
//Player player2 = new Player("Gosho", "Aggressive", 22, 1);
//Player player3 = new Player("Tosho", "Defensive", 21, 4);
//Player player4 = new Player("Rasho", "Offensive", 20, 2);
//playerList.Add(player1);
//            playerList.Add(player2);
//            playerList.Add(player3);
//            playerList.Add(player4);
//            foreach (var player in playerList)
//            {
//                Console.WriteLine(player.Position);
//            }