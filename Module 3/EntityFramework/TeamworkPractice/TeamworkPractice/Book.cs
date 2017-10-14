using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkPractice
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Language> Languages{ get; set; }

        public DateTime DatePublished { get; set; }

        public Genre Genres { get; set; }

    }
}
