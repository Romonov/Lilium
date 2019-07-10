﻿using Lilium.Protocol.Message;
using Lilium.Protocol.PacketLib;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lilium.Net
{
    interface Session
    {
        string getHost();
        int getPort();
        PacketType getPacketType();
        int ProtocolVersion { get; set; }
        int CompressionTreshold { get; set; }
        Task Send(Packet pcket);
        Task Connect();
        void Disconnect(DisconnectReason reason, string message);
        void AddListener(ISessionListener paramListener);
        void RemoveListener(ISessionListener paramListener);
        void CallEvent(ISessionEvent paramEvent);
    }
}
