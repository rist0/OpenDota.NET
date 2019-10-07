using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Players;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, int? limit = null, int? offset = null,
                                                                   int? win = null, int? patch = null,
                                                                   int? gameMode = null, int? lobbyType = null,
                                                                   int? region = null, int? date = null,
                                                                   int? laneRole = null, int? heroId = null,
                                                                   int? isRadiant = null,
                                                                   List<int> includedAccountIds = null,
                                                                   List<int> excludedAccountIds = null,
                                                                   List<int> withHeroIds = null,
                                                                   List<int> againstHeroIds = null,
                                                                   int? significant = null, int? having = null,
                                                                   string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

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
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <param name="project">Fields to project (array)</param>
        /// <returns></returns>
        public async Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, int? limit = null, int? offset = null,
                                                             int? win = null, int? patch = null, int? gameMode = null,
                                                             int? lobbyType = null, int? region = null, int? date = null,
                                                             int? laneRole = null, int? heroId = null,
                                                             int? isRadiant = null, List<int> includedAccountIds = null,
                                                             List<int> excludedAccountIds = null,
                                                             List<int> withHeroIds = null,
                                                             List<int> againstHeroIds = null, int? significant = null,
                                                             int? having = null, string sort = null,
                                                             string project = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort, project);
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
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerHeroes, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHeroes = JsonConvert.DeserializeObject<List<PlayerHero>>(await response.Content.ReadAsStringAsync());

            return playerHeroes;
        }

        /// <summary>
        /// Players played with
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerPeers, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPeers = JsonConvert.DeserializeObject<List<PlayerPeer>>(await response.Content.ReadAsStringAsync());

            return playerPeers;
        }

        /// <summary>
        /// Pro players played with
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerPros, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerPros = JsonConvert.DeserializeObject<List<PlayerPro>>(await response.Content.ReadAsStringAsync());

            return playerPros;
        }

        /// <summary>
        /// Totals in stats
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerTotals, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerTotals = JsonConvert.DeserializeObject<List<PlayerTotal>>(await response.Content.ReadAsStringAsync());

            return playerTotals;
        }

        /// <summary>
        /// Counts in categories
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<PlayerCount> GetPlayerCountsAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerCounts, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerCounts = JsonConvert.DeserializeObject<PlayerCount>(await response.Content.ReadAsStringAsync());

            return playerCounts;
        }

        /// <summary>
        /// Distribution of matches in a single stat
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="field">Field to aggregate on (Available fields: kills, actions_per_min, assists, comeback, courier_kills, deaths, denies, duration, lane_efficiency_pct, purchase_gem, gold_per_min, hero_damage, hero_healing, kda, last_hits, level, loss, pings, neutral_kills, purchase_ward_observer, purchase_rapier, purchase_ward_sentry, stomp, stuns, throw, tower_damage, tower_kills, purchase_tpscroll, xp_per_min and others</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerHistograms, playerId, field), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerHistograms = JsonConvert.DeserializeObject<List<PlayerHistogram>>(await response.Content.ReadAsStringAsync());

            return playerHistograms;
        }

        /// <summary>
        /// Wards placed in matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<PlayerWardmap> GetPlayerWardmapAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

            var response = await _request.GetRequestResponseMessageAsync(string.Format(PlayerWardmap, playerId), addedArguments);

            response.EnsureSuccessStatusCode();

            var playerWardmap = JsonConvert.DeserializeObject<PlayerWardmap>(await response.Content.ReadAsStringAsync());

            return playerWardmap;
        }

        /// <summary>
        /// Words said/read in matches played
        /// </summary>
        /// <param name="playerId">Steam32 account ID</param>
        /// <param name="limit">Number of matches to limit to</param>
        /// <param name="offset">Number of matches to offset start by</param>
        /// <param name="win">Whether the player won</param>
        /// <param name="patch">Patch ID</param>
        /// <param name="gameMode">Game Mode ID</param>
        /// <param name="lobbyType">Lobby type ID</param>
        /// <param name="region">Region ID</param>
        /// <param name="date">Days previous</param>
        /// <param name="laneRole">Lane Role ID</param>
        /// <param name="heroId">Hero ID</param>
        /// <param name="isRadiant">Whether the player was radiant</param>
        /// <param name="includedAccountIds">Account IDs in the match (array)</param>
        /// <param name="excludedAccountIds">Account IDs not in the match (array)</param>
        /// <param name="withHeroIds">Hero IDs on the player's team (array)</param>
        /// <param name="againstHeroIds">Hero IDs against the player's team (array)</param>
        /// <param name="significant">Whether the match was significant for aggregation purposes. Defaults to 1 (true), set this to 0 to return data for non-standard modes/matches.</param>
        /// <param name="having">The minimum number of games played, for filtering hero stats</param>
        /// <param name="sort">The field to return matches sorted by in descending order</param>
        /// <returns></returns>
        public async Task<PlayerWordcloud> GetPlayerWordcloudAsync(long playerId, int? limit = null, int? offset = null, int? win = null, int? patch = null, int? gameMode = null, int? lobbyType = null, int? region = null, int? date = null, int? laneRole = null, int? heroId = null, int? isRadiant = null, List<int> includedAccountIds = null, List<int> excludedAccountIds = null, List<int> withHeroIds = null, List<int> againstHeroIds = null, int? significant = null, int? having = null, string sort = null)
        {
            var addedArguments = CreateArgumentListForPlayerWinLossRequest(limit, offset, win, patch, gameMode, lobbyType, region, date, laneRole, heroId, isRadiant, includedAccountIds, excludedAccountIds, withHeroIds, againstHeroIds, significant, having, sort);

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
        private List<string> CreateArgumentListForPlayerWinLossRequest(
            int? limit = null,
            int? offset = null, 
            int? win = null, 
            int? patch = null, 
            int? gameMode = null, 
            int? lobbyType = null, 
            int? region = null, 
            int? date = null, 
            int? laneRole = null, 
            int? heroId = null, 
            int? isRadiant = null, 
            List<int> includedAccountIds = null, 
            List<int> excludedAccountIds = null,
            List<int> withHeroIds = null, 
            List<int> againstHeroIds = null, 
            int? significant = null, 
            int? having = null, 
            string sort = null,
            string project = null)
        {
            var addedArguments = new List<string>();

            if (limit != null)
            {
                addedArguments.Add($@"limit={limit}");
            }

            if (offset != null)
            {
                addedArguments.Add($@"offset={offset}");
            }

            if (win != null)
            {
                addedArguments.Add($@"win={win}");
            }

            if (patch != null)
            {
                addedArguments.Add($@"patch={patch}");
            }

            if (gameMode != null)
            {
                addedArguments.Add($@"game_mode={gameMode}");
            }

            if (lobbyType != null)
            {
                addedArguments.Add($@"lobby_type={lobbyType}");
            }

            if (region != null)
            {
                addedArguments.Add($@"region={region}");
            }

            if (date != null)
            {
                addedArguments.Add($@"date={date}");
            }

            if (laneRole != null)
            {
                addedArguments.Add($@"lane_role={laneRole}");
            }

            if (heroId != null)
            {
                addedArguments.Add($@"hero_id={heroId}");
            }

            if (isRadiant != null)
            {
                addedArguments.Add($@"is_radiant={isRadiant}");
            }

            if (includedAccountIds != null)
            {
                foreach(var includedAccountId in includedAccountIds)
                {
                    addedArguments.Add($@"included_account_id={includedAccountId}");
                }
            }

            if (excludedAccountIds != null)
            {
                foreach (var excludedAccountId in excludedAccountIds)
                {
                    addedArguments.Add($@"excluded_account_id={excludedAccountId}");
                }
            }

            if (withHeroIds != null)
            {
                foreach (var withHeroId in withHeroIds)
                {
                    addedArguments.Add($@"with_hero_id={withHeroId}");
                }
            }

            if (againstHeroIds != null)
            {
                foreach (var againstHeroId in againstHeroIds)
                {
                    addedArguments.Add($@"against_hero_id={againstHeroId}");
                }
            }

            if (significant != null)
            {
                addedArguments.Add($@"significant={significant}");
            }

            if (having != null)
            {
                addedArguments.Add($@"having={having}");
            }

            if (sort != null)
            {
                addedArguments.Add($@"sort={sort}");
            }

            if (project != null)
            {
                addedArguments.Add($@"project={project}");
            }

            return addedArguments;
        }
        #endregion
    }
}
