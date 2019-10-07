using OpenDotaDotNet.Interfaces;

namespace OpenDotaDotNet
{
    interface IOpenDotaApi
    {
        IMatchEndpoint Matches { get; }

        IPlayerEndpoint Player { get; }

        IProPlayerEndpoint ProPlayers { get; }
        
        IProMatchEndpoint ProMatches { get; }

        IPublicMatchEndpoint PublicMatches { get; }

        IMetadataEndpoint Metadata { get; }

        IMmrDistributionEndpoint MmrDistribution { get; }

        ISearchEndpoint Search { get; }

        IRankingEndpoint Ranking { get; }

        IBenchmarkEndpoint Benchmarks { get; }

        IStatusEndpoint Status { get; }
    }
}
