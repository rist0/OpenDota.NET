using OpenDotaDotNet.Models.Records;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IRecordEndpoint
    {
        /// <summary>
        /// Get top performances in a stat
        /// </summary>
        /// <param name="field">Field name to query</param>
        /// <returns></returns>
        Task<List<Record>> GetRecordsByFieldAsync(RecordField field);
    }
}
