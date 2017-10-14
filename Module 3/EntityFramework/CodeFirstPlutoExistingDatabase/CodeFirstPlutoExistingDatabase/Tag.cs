namespace CodeFirstPlutoExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tag()
        {
            Courses = new HashSet<Courses>();//we also skipped that step in the green field project, 
            //but it's needed or otherwise we get a null reference exception because the connection is
            //not initialized
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }//we did not use virtual in the other project
        
        //originally we used IList
        //IList derives from ICollection which gives you the ability to add or remove an object
        //from a collection but it also provides an indexer - you can access an element by index
    }
}
