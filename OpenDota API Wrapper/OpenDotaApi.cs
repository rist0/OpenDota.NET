using OpenDotaDotNet.Endpoints;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Requests;
using System.Net;

namespace OpenDotaDotNet
{
    public class OpenDotaApi : IOpenDotaApi
    {
        private static OpenDotaApi _instance;

        private readonly Request _request;

        public IMatchEndpoint Matches { get; }
        public IPlayerEndpoint Player { get; }
        public IProPlayerEndpoint ProPlayers { get; }
        public IProMatchEndpoint ProMatches { get; }
        public IPublicMatchEndpoint PublicMatches { get; }
        public IMetadataEndpoint Metadata { get; }
        public IMmrDistributionEndpoint MmrDistribution { get; }
        public ISearchEndpoint Search { get; }
        public IRankingEndpoint Ranking { get; }
        public IBenchmarkEndpoint Benchmarks { get; }
        public IStatusEndpoint Status { get; }
        public IHealthEndpoint Health { get; }
        public IRequestEndpoint Request { get; }
        public IFindMatchEndpoint FindMatch { get; }
        public IHeroEndpoint Hero { get; }
        public IHeroStatsEndpoint HeroStats { get; }
        public ILeagueEndpoint League { get; }
        public ITeamEndpoint Team { get; }
        public IReplayEndpoint Replay { get; }
        public IRecordEndpoint Record { get; }
        public ILiveEndpoint Live { get; }
        public IScenariosEndpoint Scenarios { get; }
        public ISchemaEndpoint Schema { get; }

        public static OpenDotaApi GetInstance(string apiKey = null, WebProxy proxy = null)
        {
            return _instance ?? (_instance = new OpenDotaApi(apiKey, proxy));
        }

        private OpenDotaApi(string apiKey, WebProxy proxy)
        {
            _request = new Request(apiKey, proxy);

            Matches = new MatchEndpoint(_request);
            Player = new PlayerEndpoint(_request);
            ProPlayers = new ProPlayerEndpoint(_request);
            ProMatches = new ProMatchesEndpoint(_request);
            PublicMatches = new PublicMatchEndpoint(_request);
            Metadata = new MetadataEndpoint(_request);
            MmrDistribution = new MmrDistributionEndpoint(_request);
            Search = new SearchEndpoint(_request);
            Ranking = new RankingEndpoint(_request);
            Benchmarks = new BenchmarksEndpoint(_request);
            Status = new StatusEndpoint(_request);
            Health = new HealthEndpoint(_request);
            Request = new RequestEndpoint(_request);
            FindMatch = new FindMatchEndpoint(_request);
            Hero = new HeroEndpoint(_request);
            HeroStats = new HeroStatsEndpoint(_request);
            League = new LeagueEndpoint(_request);
            Team = new TeamEndpoint(_request);
            Replay = new ReplayEndpoint(_request);
            Record = new RecordEndpoint(_request);
            Live = new LiveEndpoint(_request);
            Scenarios = new ScenariosEndpoint(_request);
            Schema = new SchemaEndpoint(_request);
        }
    }
}
