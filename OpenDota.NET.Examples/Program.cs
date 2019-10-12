using System;
using System.Linq;
using System.Threading.Tasks;
using OpenDotaDotNet;
using OpenDotaDotNet.Dtos;

namespace OpenDota.NET.Examples
{
    class Program
    {
        private static readonly OpenDotaApi OpenDota = OpenDotaApi.GetInstance();

        static async Task Main(string[] args)
        {
            const long playerId = 375507918;
            const long matchId = 5063190379;

            var playerInfo = await OpenDota.Player.GetPlayerByIdAsync(playerId);

            Console.WriteLine($@"Basic details of player with id {playerId}.");
            Console.WriteLine($@"Steam name: {playerInfo.Profile.Personaname}");
            Console.WriteLine($@"Steam ID: {playerInfo.Profile.Steamid}");
            Console.WriteLine($@"Steam profile direct link: {playerInfo.Profile.Profileurl}");

            if (playerInfo.MmrEstimate.Estimate.HasValue)
            {
                Console.WriteLine($@"Estimated MMR: {playerInfo.MmrEstimate.Estimate}");
            }

            Console.WriteLine();

            Console.WriteLine("Win loss ratio");
            var playerWinLoss = await OpenDota.Player.GetPlayerWinLossByIdAsync(playerId);
            Console.WriteLine($@"Total games played: {playerWinLoss.Wins + playerWinLoss.Losses}.");
            Console.WriteLine($@"Total wins: {playerWinLoss.Wins}.");
            Console.WriteLine($@"Total losses: {playerWinLoss.Losses}.");

            Console.WriteLine();

            Console.WriteLine("Player heroes");
            var playerQueryParameters = new PlayerEndpointParameters
            {
                Limit = 20
            };
            var playerHeroes = await OpenDota.Player.GetPlayerHeroesAsync(playerId, playerQueryParameters);

            var playerMostPlayedHeroLast20 = playerHeroes.FirstOrDefault();

            if (playerMostPlayedHeroLast20 != null)
            {
                Console.WriteLine(
                    $@"Most played hero in the last 20 matches is hero ID: {playerMostPlayedHeroLast20.HeroId} with {playerMostPlayedHeroLast20.Win} wins.");
            }

            Console.WriteLine();

            Console.WriteLine("Player heroes");
            var matchDetails = await OpenDota.Matches.GetMatchByIdAsync(matchId);

            Console.WriteLine($@"Details about match id {matchId}.");
            Console.WriteLine($@"Duration of game: {TimeSpan.FromSeconds(matchDetails.Duration):mm\:ss}.");
            Console.WriteLine($@"Radiant Score: {matchDetails.RadiantScore}. Dire Score: {matchDetails.DireScore}.");

            Console.WriteLine($@"Nickname of players in the game:");
            foreach (var player in matchDetails.Players)
            {
                Console.WriteLine(string.IsNullOrEmpty(player.Personaname) ? "Anonymous" : $@"{player.Personaname}");
            }

            Console.WriteLine("Example finished. Press esc key to exit...");

            Console.ReadKey();
        }
    }
}
