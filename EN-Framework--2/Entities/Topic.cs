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
    [Table("Topic", Schema = "dbo")]

    internal class Topic
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

    }
    #endregion

    #region By_convention
    //internal class Topic
    //{

    //public int Id { get; set; }

    //public string Name { get; set; }
    //}
    #endregion
}





