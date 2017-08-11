using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartOne
{
    class Program
    {
        static void Main(string[] args)
        {      
            Student Nick = new Student("Nick", 920);
            Console.WriteLine($"This student's name is {Nick.GetName}, their GroupNumber is {Nick.GetGroupNo}.");

            Student Lili = new Student("Lili", 920);
            Console.WriteLine($"This student's name is {Lili.GetName}, their GroupNumber is {Lili.GetGroupNo}.");

            Console.WriteLine("--------------------------------------------------------------------");

            Teacher Maria = new Teacher("Maria", 19);
            Console.WriteLine($"This teacher's name is {Maria.GetName}, they have {Maria.GetNumberOfLectures} lectures.");

            Console.WriteLine("--------------------------------------------------------------------");
            //this is also possible:
            //Group group1 = new Group(new Student("Mark", 900));
            //Console.WriteLine(group1.GetStudent.GetName + " " + group1.GetStudent.GetGroupNo);

            Group group1 = new Group(Nick);
            group1.GetGroupId = "Class of 2016";
            Console.WriteLine
                ($"{group1.GetStudent.GetName} is from group {group1.GetStudent.GetGroupNo}. The Id of his group is {group1.GetGroupId}.");
            Console.WriteLine();            

            Group group3 = new Group("Class of 2017", Lili);
            Console.WriteLine(group3.GetGroupId + " " + group3.GetStudent.GetName);
        }
    }
}
