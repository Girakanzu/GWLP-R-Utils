using System;
using ServerEngine.ProcessorQueues;
using ServerEngine.PacketManagement.CustomAttributes;
using ServerEngine.PacketManagement.Definitions;

namespace GameServer.Packets.ToClient
{
        [PacketAttributes(IsIncoming = false, Header = 442)]
        public class Packet442 : IPacket
        {
                public class PacketSt442 : IPacketTemplate
                {
                        public UInt16 Header { get { return 442; } }
                        public UInt16 Data1;
                }

                public void InitPacket(object parser)
                {
                        pParser = (PacketParser<PacketSt442>)parser;
                        IsInitialized = true;
                        IsInUse = false;
                }

                public bool Handler(ref NetworkMessage message)
                {
                        pParser((PacketSt442)message.PacketTemplate, message.PacketData);
                        QueuingService.NetOutQueue.Enqueue(message);
                        return true;
                }

                public bool IsInitialized { get; set; }

                public bool IsInUse { get; set; }

                private PacketParser<PacketSt442> pParser;

        }
}
