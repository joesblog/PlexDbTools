namespace PlexDBLib
{

  public static class UnixTimestampExtensions
  {
    /// <summary>
    /// Converts a Unix timestamp (seconds since epoch) to a UTC DateTime.
    /// </summary>
    public static DateTime ToDateTimeUtc(this long unixTimestamp)
    {
      return DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).UtcDateTime;
    }

    /// <summary>
    /// Converts a Unix timestamp (seconds since epoch) to a local DateTime.
    /// </summary>
    public static DateTime ToDateTimeLocal(this long unixTimestamp)
    {
      return DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).LocalDateTime;
    }

    /// <summary>
    /// Converts a UTC DateTime to a Unix timestamp (seconds since epoch).
    /// </summary>
    public static long ToUnixTimestamp(this DateTime utcDateTime)
    {
      if (utcDateTime.Kind != DateTimeKind.Utc)
      {
        utcDateTime = utcDateTime.ToUniversalTime();
      }
      return ((DateTimeOffset)utcDateTime).ToUnixTimeSeconds();
    }

    /// <summary>
    /// Converts a local DateTime to a Unix timestamp (seconds since epoch).
    /// </summary>
    public static long ToUnixTimestampFromLocal(this DateTime localDateTime)
    {
      return ((DateTimeOffset)localDateTime.ToLocalTime()).ToUnixTimeSeconds();
    }
  }



}