using CodeFirstLiveDemo.Data;
using System.Linq;
using System;

namespace CodeFirstLiveDemo.StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new StudentSystemContext();//app is launched and DB is created. That is the first approach.
            //ctx is short for context
            //the second approach is ctx.Database.CreateIfNotExist();
            //the DB is created according to the ctx
            //db.Students.Add();

            Console.WriteLine(ctx.Students.Count());
        }
    }
}
