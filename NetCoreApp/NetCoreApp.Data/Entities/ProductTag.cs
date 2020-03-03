using NetCoreApp.Infrastructure.ShareKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreApp.Data.Entities
{
    public class ProductTag : BaseEntity<int>
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        [Column(TypeName ="varchar(50)")]
        public string TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
