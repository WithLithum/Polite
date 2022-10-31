namespace WithLithum.Polite.Entities;

using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides extensions methods for vehicles.
/// </summary>
public static class VehicleUtil
{
    /// <summary>
    /// Randomises the <see cref="Vehicle.LicensePlate"/> property of this instance.
    /// </summary>
    /// <param name="vehicle">The vehicle to randomise.</param>
    public static void RandomiseNumberPlate(this Vehicle vehicle)
    {
        // San andreas number plate is formatted like 
        // NNXXXNNN

        var sb = new StringBuilder();
        var x = RandomUtil.Random;

        sb.Append(x.NextSingleDigit())
            .Append(x.NextSingleDigit())
            .Append(x.NextUpperChar())
            .Append(x.NextUpperChar())
            .Append(x.NextUpperChar())
            .Append(x.NextSingleDigit())
            .Append(x.NextSingleDigit())
            .Append(x.NextSingleDigit());

        vehicle.LicensePlate = sb.ToString();
    }
}
