namespace WithLithum.Polite.Entities;

using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class VehicleUtil
{
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
