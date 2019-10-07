using OpenDotaDotNet.Models.Schema;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface ISchemaEndpoint
    {
        /// <summary>
        /// Get database schema
        /// </summary>
        /// <returns></returns>
        Task<List<DatabaseSchema>> GetDatabaseSchemaAsync();
    }
}
