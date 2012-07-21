using System;
using ServerEngine.ProcessorQueues;
using ServerEngine.PacketManagement.CustomAttributes;
using ServerEngine.PacketManagement.Definitions;

namespace GameServer.Packets.ToClient
{
        [PacketAttributes(IsIncoming = false, Header = 260)]
        public class Packet260 : IPacket
        {
                public class PacketSt260 : IPacketTemplate
                {
                        public UInt16 Header { get { return 260; } }
                        public UInt16 Data1;
                        public byte Data2;
                        public UInt32 Data3;
                }

                public void InitPacket(object parser)
                {
                        pParser = (PacketParser<PacketSt260>)parser;
                        IsInitialized = true;
                        IsInUse = false;
                }

                public bool Handler(ref NetworkMessage message)
                {
                        pParser((PacketSt260)message.PacketTemplate, message.PacketData);
                        QueuingService.NetOutQueue.Enqueue(message);
                        return true;
                }

                public bool IsInitialized { get; set; }

                public bool IsInUse { get; set; }

                private PacketParser<PacketSt260> pParser;

        }
}
