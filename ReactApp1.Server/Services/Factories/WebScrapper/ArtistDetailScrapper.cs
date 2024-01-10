using HtmlAgilityPack;
using ReactApp1.Server.Interfaces;
using ReactApp1.Server.Models;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace ReactApp1.Server.Services.Factories.WebScrapper
{
    public class ArtistDetailScrapper : BaseScrapper, IWebScrapper
    {/// <summary>
    /// Scrapping artist details by given slug
    /// </summary>
    /// <param name="uriSuffix"></param>
    /// <returns></returns>
        public Task ScrapAsync(string uriSuffix)
        {
            Artist artist = new();
            WebPage PageResult = GetPageContent(uriSuffix);
            List<HtmlNode> description = PageResult.Html.CssSelect("div#mw-content-text  p").Take(20).ToList();

            //TODO: zmienić linki na span
            artist.name = PageResult.Html.CssSelect("#firstHeading").ToList().FirstOrDefault().OuterHtml;

            artist.infoTable = PageResult.Html.CssSelect("table.infobox").ToList().FirstOrDefault().OuterHtml;

            foreach (HtmlNode paragraph in description)
            {
                artist.description += paragraph.OuterHtml;

            }

            return Task.FromResult(artist);
        }
    }
}
