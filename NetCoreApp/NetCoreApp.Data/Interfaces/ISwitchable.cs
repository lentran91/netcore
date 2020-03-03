using NetCoreApp.Infrastructure.Enums;

namespace NetCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
         Status Status { get; set; }
    }
}
