using OpenDotaDotNet.Models.Players;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaDotNet.Interfaces
{
    public interface IPlayerEndpoint
    {
        Task<Player> GetPlayerByIdAsync(long playerId);

        Task<PlayerWinLoss> GetPlayerWinLossByIdAsync(long playerId, int? limit = null, int? offset = null,
                                                      int? win = null, int? patch = null, int? gameMode = null,
                                                      int? lobbyType = null, int? region = null, int? date = null,
                                                      int? laneRole = null, int? heroId = null, int? isRadiant = null,
                                                      List<int> includedAccountIds = null,
                                                      List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                      List<int> againstHeroIds = null, int? significant = null,
                                                      int? having = null, string sort = null);

        Task<List<PlayerRecentMatch>> GetPlayerRecentMatchesAsync(long playerId);

        Task<List<PlayerMatch>> GetPlayerMatchesAsync(long playerId, int? limit = null, int? offset = null,
                                                      int? win = null, int? patch = null, int? gameMode = null,
                                                      int? lobbyType = null, int? region = null, int? date = null,
                                                      int? laneRole = null, int? heroId = null, int? isRadiant = null,
                                                      List<int> includedAccountIds = null,
                                                      List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                      List<int> againstHeroIds = null, int? significant = null,
                                                      int? having = null, string sort = null, string project = null);

        Task<List<PlayerHero>> GetPlayerHeroesAsync(long playerId, int? limit = null, int? offset = null,
                                                    int? win = null, int? patch = null, int? gameMode = null,
                                                    int? lobbyType = null, int? region = null, int? date = null,
                                                    int? laneRole = null, int? heroId = null, int? isRadiant = null,
                                                    List<int> includedAccountIds = null,
                                                    List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                    List<int> againstHeroIds = null, int? significant = null,
                                                    int? having = null, string sort = null);

        Task<List<PlayerPeer>> GetPlayerPeersAsync(long playerId, int? limit = null, int? offset = null, int? win = null,
                                                   int? patch = null, int? gameMode = null, int? lobbyType = null,
                                                   int? region = null, int? date = null, int? laneRole = null,
                                                   int? heroId = null, int? isRadiant = null,
                                                   List<int> includedAccountIds = null,
                                                   List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                   List<int> againstHeroIds = null, int? significant = null,
                                                   int? having = null, string sort = null);

        Task<List<PlayerPro>> GetPlayerProsAsync(long playerId, int? limit = null, int? offset = null, int? win = null,
                                                 int? patch = null, int? gameMode = null, int? lobbyType = null,
                                                 int? region = null, int? date = null, int? laneRole = null,
                                                 int? heroId = null, int? isRadiant = null,
                                                 List<int> includedAccountIds = null,
                                                 List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                 List<int> againstHeroIds = null, int? significant = null,
                                                 int? having = null, string sort = null);

        Task<List<PlayerTotal>> GetPlayerTotalsAsync(long playerId, int? limit = null, int? offset = null,
                                                     int? win = null, int? patch = null, int? gameMode = null,
                                                     int? lobbyType = null, int? region = null, int? date = null,
                                                     int? laneRole = null, int? heroId = null, int? isRadiant = null,
                                                     List<int> includedAccountIds = null,
                                                     List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                     List<int> againstHeroIds = null, int? significant = null,
                                                     int? having = null, string sort = null);

        Task<PlayerCount> GetPlayerCountsAsync(long playerId, int? limit = null, int? offset = null, int? win = null,
                                               int? patch = null, int? gameMode = null, int? lobbyType = null,
                                               int? region = null, int? date = null, int? laneRole = null,
                                               int? heroId = null, int? isRadiant = null,
                                               List<int> includedAccountIds = null, List<int> excludedAccountIds = null,
                                               List<int> withHeroIds = null, List<int> againstHeroIds = null,
                                               int? significant = null, int? having = null, string sort = null);

        Task<List<PlayerHistogram>> GetPlayerHistogramsAsync(long playerId, string field, int? limit = null,
                                                             int? offset = null, int? win = null, int? patch = null,
                                                             int? gameMode = null, int? lobbyType = null,
                                                             int? region = null, int? date = null, int? laneRole = null,
                                                             int? heroId = null, int? isRadiant = null,
                                                             List<int> includedAccountIds = null,
                                                             List<int> excludedAccountIds = null,
                                                             List<int> withHeroIds = null,
                                                             List<int> againstHeroIds = null, int? significant = null,
                                                             int? having = null, string sort = null);

        Task<PlayerWardmap> GetPlayerWardmapAsync(long playerId, int? limit = null, int? offset = null, int? win = null,
                                                  int? patch = null, int? gameMode = null, int? lobbyType = null,
                                                  int? region = null, int? date = null, int? laneRole = null,
                                                  int? heroId = null, int? isRadiant = null,
                                                  List<int> includedAccountIds = null,
                                                  List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                  List<int> againstHeroIds = null, int? significant = null,
                                                  int? having = null, string sort = null);

        Task<PlayerWordcloud> GetPlayerWordcloudAsync(long playerId, int? limit = null, int? offset = null,
                                                      int? win = null, int? patch = null, int? gameMode = null,
                                                      int? lobbyType = null, int? region = null, int? date = null,
                                                      int? laneRole = null, int? heroId = null, int? isRadiant = null,
                                                      List<int> includedAccountIds = null,
                                                      List<int> excludedAccountIds = null, List<int> withHeroIds = null,
                                                      List<int> againstHeroIds = null, int? significant = null,
                                                      int? having = null, string sort = null);
    }
}
