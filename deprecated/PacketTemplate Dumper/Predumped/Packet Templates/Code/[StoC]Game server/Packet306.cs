using System;
using ServerEngine.ProcessorQueues;
using ServerEngine.PacketManagement.CustomAttributes;
using ServerEngine.PacketManagement.Definitions;

namespace GameServer.Packets.ToClient
{
        [PacketAttributes(IsIncoming = false, Header = 306)]
        public class Packet306 : IPacket
        {
                public class PacketSt306 : IPacketTemplate
                {
                        public UInt16 Header { get { return 306; } }
                        public byte Data1;
                        public UInt32 Data2;
                }

                public void InitPacket(object parser)
                {
                        pParser = (PacketParser<PacketSt306>)parser;
                        IsInitialized = true;
                        IsInUse = false;
                }

                public bool Handler(ref NetworkMessage message)
                {
                        pParser((PacketSt306)message.PacketTemplate, message.PacketData);
                        QueuingService.NetOutQueue.Enqueue(message);
                        return true;
                }

                public bool IsInitialized { get; set; }

                public bool IsInUse { get; set; }

                private PacketParser<PacketSt306> pParser;

        }
}
