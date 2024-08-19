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
    [Table("Department", Schema = "dbo")]

    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        public int Hiring_Date { get; set; }
        public int Ins_Id { get; set; }
    }
    #endregion

    #region By_Convention
    //internal class Department
    //{
       
    //    public int Id { get; set; }
        
    //    public string Name { get; set; }

    //    public int Hiring_Date { get; set; }
    //    public int Ins_Id { get; set; }
    //}
    #endregion
}
