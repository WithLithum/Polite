namespace WithLithum.Polite.Entities;

using Rage;
using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Polite.Util;

/// <summary>
/// Provides extensions methods to the <see cref="Blip"/> class.
/// </summary>
public static class BlipExtensions
{
    /// <summary>
    /// Sets the colour of this instance to the specified native blip colour.
    /// </summary>
    /// <param name="blip">The blip to set colour.</param>
    /// <param name="colour">The colour to set blip to.</param>
    public static void SetBlipColour(this Blip blip, BlipColour colour)
    {
        NativeFunction.Natives.x03D7FB09E75D6B7E(blip, (int)colour);
    }
}
