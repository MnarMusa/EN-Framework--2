using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Entities
{
    #region Data_Annotation
    [Table("Student", Schema = "dbo")]

    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? FName { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? LName { get; set; }

        [Range(16, 20)]
        public int? Age { get; set; }

        public string? Address { get; set; }
        public int D_Id { get; set; }
    }
    #endregion

    #region By_convention
    //internal class Student
    //{

    //    public int Id { get; set; }

    //    public string? FName { get; set; }

    //    public string? LName { get; set; }


    //    public int? Age { get; set; }

    //    public string? Address { get; set; }
    //    public int D_Id { get; set; }
    //} 
    #endregion
}
