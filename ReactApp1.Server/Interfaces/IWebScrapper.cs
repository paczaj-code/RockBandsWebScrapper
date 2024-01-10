namespace ReactApp1.Server.Interfaces
{
    /// <summary>
    /// Interface defines neccessary methods for each WebScrapper
    /// </summary>
    public interface IWebScrapper
     
    
    {/// <summary>
    /// Method scrapping for Wikipedia
    /// </summary>
    /// <param name="uriSuffix"> Url suffix dynamically changed by fronend</param>
    /// <returns>
    /// Task
    /// </returns>
        public Task ScrapAsync(string uriSuffix);
    }
}
