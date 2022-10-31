namespace WithLithum.Polite.Entities;

using Rage;
using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Polite.Util;

public static class BlipExtensions
{
    public static void SetBlipColour(this Blip blip, BlipColour colour)
    {
        NativeFunction.Natives.x03D7FB09E75D6B7E(blip, (int)colour);
    }
}
