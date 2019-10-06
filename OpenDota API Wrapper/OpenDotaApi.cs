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

        public static OpenDotaApi GetInstance(string apiKey = null, WebProxy proxy = null)
        {
            if (_instance == null)
            {
                _instance = new OpenDotaApi(apiKey, proxy);
            }

            return _instance;
        }

        private OpenDotaApi(string apiKey, WebProxy proxy)
        {
            _request = new Request(apiKey, proxy);

            Matches = new MatchEndpoint(_request);
            Player = new PlayerEndpoint(_request);
            ProPlayers = new ProPlayerEndpoint(_request);
            ProMatches = new ProMatchesEndpoint(_request);
            PublicMatches = new PublicMatchEndpoint(_request);
        }
    }
}
