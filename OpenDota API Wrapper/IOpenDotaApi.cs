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
    }
}
