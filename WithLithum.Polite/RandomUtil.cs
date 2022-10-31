namespace WithLithum.Polite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Provides a shared instance of <see cref="Random"/> and extension methods for that
/// class.
/// </summary>
public static class RandomUtil
{
    /// <summary>
    /// Gets a shared random instance.
    /// </summary>
    public static Random Random { get; } = new Random();

    /// <summary>
    /// Gets a random upper-case English letter.
    /// </summary>
    /// <param name="random">The random instance.</param>
    /// <returns>A random upper-case English letter.</returns>
    public static char NextUpperChar(this Random random)
    {
        return (char)random.Next('A', 'Z');
    }

    /// <summary>
    /// Gets a random digit.
    /// </summary>
    /// <param name="random">The random instance.</param>
    /// <returns>A random digit.</returns>
    public static int NextSingleDigit(this Random random)
    {
        return random.Next(0, 10);
    }

    /// <summary>
    /// Gets a random lower-case English letter.
    /// </summary>
    /// <param name="random">The random instance.</param>
    /// <returns>A random lower-case English letter.</returns>
    public static char NextLowerChar(this Random random)
    {
        return (char)random.Next('a', 'z');
    }
}
