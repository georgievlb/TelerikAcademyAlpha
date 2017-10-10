using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIrstLiveDemo
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            :base("name=StudentSystem")
        {

        }
    }
}
