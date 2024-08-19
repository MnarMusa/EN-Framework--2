using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace EN_Framework__2.Entities
{
    #region Data_Annotation
    [Table("Instructor", Schema = "dbo")]

    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        public int Bouns { get; set; }
        [Column(TypeName = "Money")]
        public int Salary { get; set; }

        public string? Address { get; set; }
        public int Hour_rate { get; set; }

        public int Dept_Id { get; set; }
    }
    #endregion

    #region By_Convention
    //internal class Instructor
    //{
        
    //    public int Id { get; set; }
       
    //    public string Name { get; set; }

    //    public int Bouns { get; set; }
        
    //    public int Salary { get; set; }

    //    public string? Address { get; set; }
    //    public int Hour_rate { get; set; }

    //    public int Dept_Id { get; set; }
    //}
    #endregion
}
