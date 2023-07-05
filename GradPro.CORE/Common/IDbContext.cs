using System.Data.Common;

namespace GradPro.CORE.Common
{
    public interface IDbContext
    {
        public DbConnection Connection { get; }
        
    }
}