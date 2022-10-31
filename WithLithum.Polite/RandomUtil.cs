namespace WithLithum.Polite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class RandomUtil
{
    public static Random Random { get; } = new Random();

    public static char NextUpperChar(this Random random)
    {
        return (char)random.Next('A', 'Z');
    }

    public static int NextSingleDigit(this Random random)
    {
        return random.Next(0, 10);
    }

    public static char NextLowerChar(this Random random)
    {
        return (char)random.Next('a', 'z');
    }
}
