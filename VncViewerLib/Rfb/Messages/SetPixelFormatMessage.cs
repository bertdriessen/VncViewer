﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VncViewerLib
{
    public class SetPixelFormatMessage : MessageBase
    {
        [MessageMember(1, 3)]
        public byte[] Padding { get; private set; }

        [MessageMember(2)]
        public PixelFormat PixelFormat { get; set; }

        public SetPixelFormatMessage(PixelFormat pixelFormat) : base(0)
        {
            Padding = new byte[3];
            PixelFormat = pixelFormat;
        }
    }
}