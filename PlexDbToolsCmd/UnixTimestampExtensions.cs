namespace PlexDbToolsCmd
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
    }
 

   
}