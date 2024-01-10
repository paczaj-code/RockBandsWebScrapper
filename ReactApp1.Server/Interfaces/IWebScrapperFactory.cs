namespace ReactApp1.Server.Interfaces
{
    /// <summary>
    /// Interface defines neccessary methods for each WebScrapper factory
    /// </summary>
    public interface IWebScrapperFactory
    {
     
        public Task MakeScrapper(string scrapperType, string uriSuffix);
    }
}
