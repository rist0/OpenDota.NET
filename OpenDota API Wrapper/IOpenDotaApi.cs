using OpenDotaDotNet.Interfaces;

namespace OpenDotaDotNet
{
    interface IOpenDotaApi
    {
        IMatchEndpoint Matches { get; }

        IPlayerEndpoint Player { get; }
    }
}
