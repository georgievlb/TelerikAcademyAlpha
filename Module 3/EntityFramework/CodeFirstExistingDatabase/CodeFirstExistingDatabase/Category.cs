using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDatabase
{
    public class Category
    {
        //property that uniquely represents a category object
        //EF understands the conventions: Id and Category_Id
        //if you want to use a property that does not follow the conventions, you can override the conventions
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
