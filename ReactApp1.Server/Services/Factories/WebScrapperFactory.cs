using ReactApp1.Server.Interfaces;
using ReactApp1.Server.Services.Factories.WebScrapper;

namespace ReactApp1.Server.Services.Factories
{/// <summary>
/// Factory for all WebScrappers
/// </summary>
    public class WebScrapperFactory : IWebScrapperFactory
    {

        public Task MakeScrapper(string scrapperType, string uriSuffix)
        {
            Task scarpper = scrapperType switch
            {
                "ArtistsList" => new ArtistsListScrapper().ScrapAsync(uriSuffix),
                "ArtistsDetails" => new ArtistDetailScrapper().ScrapAsync(uriSuffix),
                "ArtistsImages" => new ArtistsImageScrapper().ScrapAsync(uriSuffix),
                _ => throw new NotSupportedException()
            };
            return scarpper;
        }
    }
}
