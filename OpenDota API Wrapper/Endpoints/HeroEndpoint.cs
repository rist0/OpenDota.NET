using Newtonsoft.Json;
using OpenDotaDotNet.Interfaces;
using OpenDotaDotNet.Models.Heroes;
using OpenDotaDotNet.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Endpoints
{
    public class HeroEndpoint : IHeroEndpoint
    {
        private const string Heroes = "heroes";
        private const string HeroMatches = "heroes/{0}/matches";
        private const string HeroMatchups = "heroes/{0}/matchups";
        private const string HeroDurations = "heroes/{0}/durations";
        private const string HeroPlayers = "heroes/{0}/players";

        private readonly Request _request;

        public HeroEndpoint(Request request)
        {
            _request = request;
        }

        /// <summary>
        /// Get hero data
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hero>> GetHeroesAsync()
        {
            var response = await _request.GetRequestResponseMessageAsync(Heroes);

            response.EnsureSuccessStatusCode();

            var heroes = JsonConvert.DeserializeObject<List<Hero>>(await response.Content.ReadAsStringAsync());

            return heroes;
        }

        /// <summary>
        /// Get recent matches with a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<List<HeroMatch>> GetHeroMatchesAsync(int heroId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(HeroMatches, heroId));

            response.EnsureSuccessStatusCode();

            var heroMatches = JsonConvert.DeserializeObject<List<HeroMatch>>(await response.Content.ReadAsStringAsync());

            return heroMatches;
        }

        /// <summary>
        /// Get results against other heroes for a hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<List<HeroMatchup>> GetHeroMatchupsAsync(int heroId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(HeroMatchups, heroId));

            response.EnsureSuccessStatusCode();

            var heroMatchups = JsonConvert.DeserializeObject<List<HeroMatchup>>(await response.Content.ReadAsStringAsync());

            return heroMatchups;
        }

        /// <summary>
        /// Get hero performance over a range of match durations
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<List<HeroDuration>> GetHeroDurationsAsync(int heroId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(HeroDurations, heroId));

            response.EnsureSuccessStatusCode();

            var heroDurations = JsonConvert.DeserializeObject<List<HeroDuration>>(await response.Content.ReadAsStringAsync());

            return heroDurations;
        }

        /// <summary>
        /// Get players who have played this hero
        /// </summary>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<List<HeroPlayer>> GetHeroPlayersAsync(int heroId)
        {
            var response = await _request.GetRequestResponseMessageAsync(string.Format(HeroPlayers, heroId));

            response.EnsureSuccessStatusCode();

            var heroPlayers = JsonConvert.DeserializeObject<List<HeroPlayer>>(await response.Content.ReadAsStringAsync());

            return heroPlayers;
        }
    }
}
