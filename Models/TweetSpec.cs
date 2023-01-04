namespace TwitterStatistics.Models
{
    public record TweetSpec(DateTime sampleDateTime, int totalTweets, List<string> hashTags);
}
