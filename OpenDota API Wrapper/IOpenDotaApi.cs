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

        IHealthEndpoint Health { get; }

        IRequestEndpoint Request { get; }

        IFindMatchEndpoint FindMatch { get; }

        IHeroEndpoint Hero { get; }

        IHeroStatsEndpoint HeroStats { get; }

        ILeagueEndpoint League { get; }

        ITeamEndpoint Team { get; }
        
        IReplayEndpoint Replay { get; }

        IRecordEndpoint Record { get; }

        ILiveEndpoint Live { get; }

        IScenariosEndpoint Scenarios { get; }

        ISchemaEndpoint Schema { get; }
    }
}
