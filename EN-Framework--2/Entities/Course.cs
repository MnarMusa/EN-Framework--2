using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Entities
{
    #region ByConvention
    //internal class Course
    //{

    //    public int Id { get; set; }
    //    public string? Name { get; set; }



    //    public double? Duration { get; set; }
    //    public string? Description { get; set; }
    //    public int Top_Id { get; set; }
    //} 
    #endregion

    #region Data_Annotation
    [Table("Course",Schema ="dbo") ]
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int C_Id { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        [StringLength(50,MinimumLength =10)]
        public string? Name { get; set; }



        public double? Duration { get; set; }
        public string? Description { get; set; }
        public int Top_Id { get; set; }
    } 
    #endregion
}
