﻿using System;
using System.Collections.Generic;
using System.Text;
using Lilium.Net.IO;

namespace Lilium.Protocol.PacketLib.Packets.Server
{
    class UnknownPacket : Packet
    {
        public byte[] Data;

        public bool IsPriority { get
            {
                return false;
            } }

        public void Read(InputBuffer input)
        {
            this.Data = input.ReadData(input.ReadableBytes);
        }

        public void Write(OutputBuffer output)
        {
            //throw new NotImplementedException();
        }
    }
}