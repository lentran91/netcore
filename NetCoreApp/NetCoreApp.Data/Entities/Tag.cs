using NetCoreApp.Infrastructure.ShareKernel;
using System.ComponentModel.DataAnnotations;

namespace NetCoreApp.Data.Entities
{
    public class Tag : BaseEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}

