using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstLiveDemo.Models
{
    public class Mark//po skoro e many to one
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Score { get; set; }

        public int StudentId { get; set; }//foreign key. this helps for MARKS WHERE STUDENTID = ...
                                          //we don't have to make Joins

        //convention navigational property name = foreignkey + Id e.g.

        //below is a navigational property - we navigate to the collection of students for a given course
        public virtual Student Student { get; set; }//every item that points to another table in our model should be virtual
        //the above property is virtual so that EF can change it during runtime
        //the collection is changed. Runtime, когато се стигне до базата, то ще
        //се напълни с данните от базата. Затова е виртуално, за да може EF да го 
        //подмения. Иначе няма да може да го напълни.

    }
}
