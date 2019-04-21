using Edelstein.Core.Distributed.Peers.Info;

namespace Edelstein.Core.Distributed.Peers
{
    [MessagePack.Union(0, typeof(LoginServiceInfo))]
    [MessagePack.Union(1, typeof(GameServiceInfo))]
    public abstract class PeerServiceInfo
    {
        public byte ID { get; set; }
        public string Name { get; set; }
    }
}