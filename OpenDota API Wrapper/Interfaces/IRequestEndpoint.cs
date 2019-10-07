using OpenDotaDotNet.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IRequestEndpoint
    {
        /// <summary>
        /// Get parse request state
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        Task<ParseRequestState> GetParseRequestStateAsync(long jobId);

        /// <summary>
        /// Submit a new parse request
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        Task<ParseRequest> SubmitNewParseRequestAsync(long matchId);
    }
}
