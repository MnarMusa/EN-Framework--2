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
    [Table("Course_Inst", Schema = "dbo")]
    internal class Course_Inst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }
        public int Evaluate { get; set; }
    }
    #endregion

    #region By_Convention
    //internal class Course_Inst
    //{
        

    //    public int Course_Id { get; set; }
    //    public int Inst_Id { get; set; }
    //    public int Evaluate { get; set; }
    //}
    #endregion
}
