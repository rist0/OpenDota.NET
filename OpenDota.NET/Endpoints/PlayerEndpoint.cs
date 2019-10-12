using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Players;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaDotNet.Dtos;

namespace OpenDotaDotNet.Endpoints
{
    class PlayerEndpoint : IPlayerEndpoint
    {
        private const string PlayerByIdUrl = "players/{0}";
        private const string PlayerWinLossByIdUrl = "players/{0}/wl";
        private const string PlayerRecentMatches = "players/{0}/recentMatches";
        private const string PlayerMatches = "players/{0}/matches";
        private const string PlayerHeroes = "players/{0}/heroes";
        private const string PlayerPeers = "players/{0}/peers";
        private const string PlayerPros = "players/{0}/pros";
        private const string PlayerTotals = "players/{0}/totals";
        private const string PlayerCounts = "players/{0}/counts";
        private const string PlayerHistograms = "players/{0}/histograms/{1}";
        private const string PlayerWardmap = "players/{0}/wardmap";
        private const string PlayerWordcloud = "players/{0}/wordcloud";
        private const string PlayerRatings = "players/{0}/ratings";
        private const string PlayerHeroRankings = "players/{0}/rankings";
        private const string RefreshPlayerMatchHistory = "players/{0}/refresh";

        private readonly Request _request;

        public PlayerEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Player data
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <returns></returns>
        public async Task<Player> GetPlayerByIdAsync(long playerId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerByIdUrl, playerId));

            response.EnsureSuccessStatusCode();

            var playerInfo = JsonConvert.DeserializeObject<Player>(await response.Content.ReadAsStringAsync());

            return playerInfo;
        }

        /// <summary>
        /// Win/Loss count
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query parameters</param>
        /// <returns></returns>
        public async Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerWinLossByIdUrl, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWinLoss = JsonConvert.DeserializeObject<PlayerWinLoss>(await response.Content.ReadAsStringAsync());

            return playerWinLoss;
        }

        /// <summary>
        /// Recent matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <returns></returns>
        public async Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerRecentMatches, playerId));

            response.EnsureSuccessStatusCode();

            var playerRecentMatches = JsonConvert.DeserializeObject<List<PlayerRecentMatch>>(await response.Content.ReadAsStringAsync());

            return playerRecentMatches;
        }

        /// <summary>
        /// Matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);
            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerMatches, playerId), addedArguments);
            response.EnsureSuccessStatusCode();
            // test
            var playerMatches = JsonConvert.DeserializeObject<List<PlayerMatch>>(await response.Content.ReadAsStringAsync());

            return playerMatches;
        }

        /// <summary>
        /// Heroes played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, PlayerEndpointParameters parameters = null)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerHeroes, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHeroes = JsonConvert.DeserializeObject<List<PlayerHero>>(await response.Content.ReadAsStringAsync());

            return playerHeroes;
        }

        /// <summary>
        /// Players played with
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerPeers, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPeers = JsonConvert.DeserializeObject<List<PlayerPeer>>(await response.Content.ReadAsStringAsync());

            return playerPeers;
        }

        /// <summary>
        /// Pro players played with
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerPros, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPros = JsonConvert.DeserializeObject<List<PlayerPro>>(await response.Content.ReadAsStringAsync());

            return playerPros;
        }

        /// <summary>
        /// Totals in stats
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerTotals, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerTotals = JsonConvert.DeserializeObject<List<PlayerTotal>>(await response.Content.ReadAsStringAsync());

            return playerTotals;
        }

        /// <summary>
        /// Counts in categories
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<PlayerCount> GetPlayerCountsAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerCounts, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerCounts = JsonConvert.DeserializeObject<PlayerCount>(await response.Content.ReadAsStringAsync());

            return playerCounts;
        }

        /// <summary>
        /// Distribution of matches in a single stat
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="field">Field to aggregate on</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerHistograms, playerId, field), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHistograms = JsonConvert.DeserializeObject<List<PlayerHistogram>>(await response.Content.ReadAsStringAsync());

            return playerHistograms;
        }

        /// <summary>
        /// Wards placed in matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<PlayerWardmap> GetPlayerWardmapAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerWardmap, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWardmap = JsonConvert.DeserializeObject<PlayerWardmap>(await response.Content.ReadAsStringAsync());

            return playerWardmap;
        }

        /// <summary>
        /// Words said/read in matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="parameters">Query Parameters</param>
        /// <returns></returns>
        public async Task<PlayerWordcloud> GetPlayerWordcloudAsync(long playerId, PlayerEndpointParameters parameters)
        {
            var addedArguments = CreateArgumentListForPlayerEndpointRequest(parameters);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerWordcloud, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWordcloud = JsonConvert.DeserializeObject<PlayerWordcloud>(await response.Content.ReadAsStringAsync());

            return playerWordcloud;
        }

        /// <summary>
        /// Player rating history
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <returns></returns>
        public async Task<List<PlayerRating>> GetPlayerRatingsAsync(long playerId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerRatings, playerId));

            response.EnsureSuccessStatusCode();

            var playerRatings = JsonConvert.DeserializeObject<List<PlayerRating>>(await response.Content.ReadAsStringAsync());

            return playerRatings;
        }

        /// <summary>
        /// Player hero rankings
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <returns></returns>
        public async Task<List<PlayerHeroRanking>> GetPlayerHeroRankingsAsync(long playerId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerHeroRankings, playerId));

            response.EnsureSuccessStatusCode();

            var playerHeroRankings = JsonConvert.DeserializeObject<List<PlayerHeroRanking>>(await response.Content.ReadAsStringAsync());

            return playerHeroRankings;
        }

        /// <summary>
        /// Refresh player match history
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public async Task<bool> RefreshPlayerMatchHistoryAsync(long playerId)
        {
            var response = await _request.PostRequest(string.Format(RefreshPlayerMatchHistory, playerId));

            response.EnsureSuccessStatusCode();

            return true;
        }

        #region Helper
        private List<string> CreateArgumentListForPlayerEndpointRequest(PlayerEndpointParameters parameters)
        {
            var addedArguments = new List<string>();

            if (parameters == null) return addedArguments;

            if (parameters.Limit != null)
            {
                addedArguments.Add($@"limit={parameters.Limit}");
            }

            if (parameters.Offset != null)
            {
                addedArguments.Add($@"offset={parameters.Offset}");
            }

            if (parameters.Win != null)
            {
                addedArguments.Add($@"win={parameters.Win}");
            }

            if (parameters.Patch != null)
            {
                addedArguments.Add($@"patch={parameters.Patch}");
            }

            if (parameters.GameMode != null)
            {
                addedArguments.Add($@"game_mode={parameters.GameMode}");
            }

            if (parameters.LobbyType != null)
            {
                addedArguments.Add($@"lobby_type={parameters.LobbyType}");
            }

            if (parameters.Region != null)
            {
                addedArguments.Add($@"region={parameters.Region}");
            }

            if (parameters.Date != null)
            {
                addedArguments.Add($@"date={parameters.Date}");
            }

            if (parameters.LaneRole != null)
            {
                addedArguments.Add($@"lane_role={parameters.LaneRole}");
            }

            if (parameters.HeroId != null)
            {
                addedArguments.Add($@"hero_id={parameters.HeroId}");
            }

            if (parameters.IsRadiant != null)
            {
                addedArguments.Add($@"is_radiant={parameters.IsRadiant}");
            }

            if (parameters.IncludedAccountIds != null)
            {
                foreach (var includedAccountId in parameters.IncludedAccountIds)
                {
                    addedArguments.Add($@"included_account_id={includedAccountId}");
                }
            }

            if (parameters.ExcludedAccountIds != null)
            {
                foreach (var excludedAccountId in parameters.ExcludedAccountIds)
                {
                    addedArguments.Add($@"excluded_account_id={excludedAccountId}");
                }
            }

            if (parameters.WithHeroIds != null)
            {
                foreach (var withHeroId in parameters.WithHeroIds)
                {
                    addedArguments.Add($@"with_hero_id={withHeroId}");
                }
            }

            if (parameters.AgainstHeroIds != null)
            {
                foreach (var againstHeroId in parameters.AgainstHeroIds)
                {
                    addedArguments.Add($@"against_hero_id={againstHeroId}");
                }
            }

            if (parameters.Significant != null)
            {
                addedArguments.Add($@"significant={parameters.Significant}");
            }

            if (parameters.Having != null)
            {
                addedArguments.Add($@"having={parameters.Having}");
            }

            if (parameters.Sort != null)
            {
                addedArguments.Add($@"sort={parameters.Sort}");
            }

            if (parameters.Project != null)
            {
                foreach (var project in parameters.Project)
                {
                    addedArguments.Add($@"project={project}");
                }
            }

            return addedArguments;
        }
        #endregion
    }
}
