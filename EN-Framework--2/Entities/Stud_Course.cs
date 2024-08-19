using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Entities
{
    #region Data_Annotation
    [Table("Stud_Course", Schema = "dbo")]

    internal class Stud_Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade { get; set; }
    }
    #endregion

    #region By_Convention
    //internal class Stud_Course
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }

    //    public int Stud_Id { get; set; }
    //    public int Course_Id { get; set; }
    //    public double Grade { get; set; }
    //}
    #endregion
}
