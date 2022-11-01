namespace WithLithum.Polite.Util;

using Rage;
using Rage.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides methods for native access.
/// </summary>
public static class NativePaths
{
    /// <summary>
    /// Attempts to get a safe coordinate to spawn a ped at.
    /// </summary>
    /// <param name="position">The position to look for a point.</param>
    /// <param name="pavement">Whether to look for pavement.</param>
    /// <param name="result">The result. If not successful, outputs <see cref="Vector3.Zero"/>.</param>
    /// <returns><see langword="true"/> if success; otherwise, <see langword="false"/>.</returns>
    public static bool TryGetSafeCoordForPed(Vector3 position, bool pavement, out Vector3 result)
    {
        var pointer = new NativePointer();

        var success = NativeFunction.Natives.xB61C8E878A4199CA<bool>(position.X, position.Y, position.Z, pavement,
            pointer, 1);

        if (!success)
        {
            result = Vector3.Zero;
        }
        else
        {
            result = pointer.GetValue<Vector3>();
        }

        return success;
    }
}
