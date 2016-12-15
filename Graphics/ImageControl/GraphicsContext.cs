﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Direct3D10;

namespace ParticleEditor.Graphics.ImageControl
{
    public class GraphicsContext
    {
        public DX10RenderCanvas RenderControl { get; set; }
        public Device1 Device { get; set; }
        public ICamera Camera { get; set; }
        public RenderTargetView RenderTargetView { get; set; }
    }
}