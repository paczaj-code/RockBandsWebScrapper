using ScrapySharp.Network;

namespace ReactApp1.Server.Services.Factories.WebScrapper
{
    public class BaseScrapper
    {
        /// <summary>
        /// Common properties for all WebScrappers in WebScrapperFactory
        /// </summary>
        protected static readonly ScrapingBrowser Browser = new();
        protected const string baseUrl = "https://en.wikipedia.org/wiki/";

        /// <summary>
        /// Common method for all WebScrappers in WebScrapperFactory
        /// </summary>
        /// <param name="url_suffix"></param>
        /// <returns>
        /// Scrapped web page content
        /// </returns>
        protected WebPage GetPageContent(string url_suffix)
        {
            return Browser.NavigateToPage(new Uri(baseUrl + url_suffix));
        }
    }
}
