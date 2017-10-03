using Academy.Models.Academy.Abstractions;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Academy.Participants
{
    public class Trainer : AcademyPerson, ITrainer
    {
        //private List<string> technologies;

        //public Trainer(string username, params string[] technologyList)
        //    : base(username)
        //{

        //    Technologies = new List<string>(technologyList);
        //}
       

        
        public Trainer(string username, string technologyList)
           : base(username)
        {
            char[] Separators =
               new char[] { ',' };
            
            string[] words = technologyList.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            Technologies = new List<string>(words);
        }


        public IList<string> Technologies { get; set; }
        

        //public IList<string> Technologies   //INTERFACE
        //{
        //    get
        //    {
        //        return this.technologies;
        //    }

        //    set
        //    {
        //        this.technologies = new List<string>();
        //    }
        //}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();            
            var lastItem = Technologies.LastOrDefault();
            foreach (var technology in Technologies)
            {
                if (technology != lastItem)                
                {
                    builder.AppendFormat(string.Format($"{technology}; "));
                }


                else
                {
                    builder.AppendFormat(string.Format($"{technology}"));
                }
            }
            return $"* Trainer:\n - Username: {this.Username}\n - Technologies: " + builder.ToString();
        }
    }
}
