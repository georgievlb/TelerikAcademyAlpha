using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _03.UnitsOfWork
{
    public class Unit : IComparable<Unit>
    {
        public string Name { get; private set; }

        public string Type { get; private set; }

        public int Attack { get; private set; }

        public static Unit Parse(IList<string> unitCharacteristics)
        {
            return new Unit {
                Name = unitCharacteristics[0],
                Type = unitCharacteristics[1],
                Attack = int.Parse(unitCharacteristics[2])};
        }

        public override string ToString()
        {
            //UNIT should be printed in the format "UNIT_NAME[UNIT_TYPE](UNIT_ATTACK)". 
            return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);            
        }

        public int CompareTo(Unit other)
        {
            //ordered by attack in descending order 
            var result = this.Attack.CompareTo(other.Attack) * -1;
            if (result == 0)
            {
                //and then by their name in ascending order
                result = this.Name.CompareTo(other.Name);
            }

            return result;
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

    public class Power
    {
        private readonly IDictionary<string, Unit> unitByName;
        private readonly IDictionary<string, SortedSet<Unit>> unitByType;
        private readonly SortedSet<Unit> power;

        public Power()
        {
            this.unitByName = new Dictionary<string, Unit>();
            this.unitByType = new Dictionary<string, SortedSet<Unit>>();
            this.power = new SortedSet<Unit>();
        }

        public bool Add(Unit unit)
        {
            if (this.unitByName.ContainsKey(unit.Name))
            {
                return false;
            }
            this.unitByName[unit.Name] = unit;
            //this.power.Insert(unit.Attack, unit);

            if (!this.unitByType.ContainsKey(unit.Type))

            {
                this.unitByType[unit.Type] = new SortedSet<Unit>();
            }
            
            this.unitByType[unit.Type].Add(unit);

            this.power.Add(unit);

            return true;
        }

        public bool Remove(string name)
        {
            if (!unitByName.ContainsKey(name))
            {
                return false;
            }
            var tempUnitByName = this.unitByName[name];

            this.unitByName.Remove(name);

            var tempUnitByType = this.unitByType[tempUnitByName.Type];

            tempUnitByType.Remove(tempUnitByName);

            this.power.Remove(tempUnitByName);

            return true;
        }

        public IEnumerable<Unit> FindByType(string type)
        {
            if (!this.unitByType.ContainsKey(type))
            {
                return Enumerable.Empty<Unit>();

            }
            return this.unitByType[type].Take(10);
        }

        public IEnumerable<Unit> GetPowerfulUnits(int numberOfUnits)
        {
            return this.power.Take(numberOfUnits);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            StringBuilder builder = new StringBuilder();

            string line = Console.ReadLine();

            while(line != "end")
            {
                Command command = Command.Parse(line);
                switch(command.Name)
                {
                    case "add":
                        Unit unit = Unit.Parse(command.Parameters);
                        if(power.Add(unit))
                        {
                            builder.AppendLine(string.Format("SUCCESS: {0} added!", unit.Name));
                        }
                        else
                        {
                            builder.AppendLine(string.Format("FAIL: {0} already exists!", unit.Name));
                        }                        
                        break;
                    case "remove":
                        if(!power.Remove(command.Parameters[0]))
                        {
                            builder.AppendLine(string.Format("FAIL: {0} could not be found!", command.Parameters[0]));
                        }
                        else
                        {
                            builder.AppendLine(string.Format("SUCCESS: {0} removed!", command.Parameters[0]));
                        }
                        break;

                    case "find":
                        var result = power.FindByType(command.Parameters[0]);
                        builder.AppendLine(string.Format("RESULT: {0}", string.Join(", ", result)));

                        break;
                    case "power":
                        var result2 = power.GetPowerfulUnits(int.Parse(command.Parameters[0]));
                        builder.AppendLine(string.Format("RESULT: {0}", string.Join(", ", result2)));
                        break;
                    default:
                        break;
                };
                line = Console.ReadLine();
            }
            Console.WriteLine(builder.ToString().Trim(' '));
        }
    }
}
