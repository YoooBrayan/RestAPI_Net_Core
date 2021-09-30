using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.BL.Models
{
    [Table("CIIU")]
    public class CIIU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_CODIGO { get; set; }

        public string C_DESCRIPCION { get; set; }

    }
}

