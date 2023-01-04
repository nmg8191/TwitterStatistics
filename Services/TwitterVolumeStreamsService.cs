using System.Text.Json;

namespace TwitterStatistics.Services
{
    public class TwitterVolumeStreamsService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TwitterVolumeStreamsService(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task OnGet()
        {
            var httpClient = _httpClientFactory.CreateClient("TwitterVolumeStreams");
            
            var httpResponseMessage = await httpClient.GetAsync(
                "2/tweets/sample/stream");

            // wikk throw an exception, that will be caught by /error.
            httpResponseMessage.EnsureSuccessStatusCode();

            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            // capture data into correct model.


            // Load into an In Memory Database.


        }
    }
}
