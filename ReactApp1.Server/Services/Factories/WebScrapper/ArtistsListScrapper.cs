using HtmlAgilityPack;
using ReactApp1.Server.Interfaces;
using ReactApp1.Server.Models;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System.Text.RegularExpressions;

namespace ReactApp1.Server.Services.Factories.WebScrapper
{
    public class ArtistsListScrapper : BaseScrapper, IWebScrapper
    {
        /// <summary>
        /// Scrapping artists list by given slug
        /// </summary>
        /// <param name="uriSuffix"></param>
        /// <returns></returns>
        public Task ScrapAsync(string uriSuffix)
        {
            ArtistsList artistsList = new();
            WebPage PageResult = GetPageContent(uriSuffix);
            IEnumerable<HtmlNode> divs = PageResult.Html.CssSelect("div.div-col ul li a");
            var title = PageResult.Html.CssSelect("#firstHeading > span").ToList().FirstOrDefault();

            artistsList.ListTitle = title.InnerHtml;

            List<ArtistListItem> allLinks = new();

            var r = new Regex(@"^&#");
            foreach (HtmlNode div in divs)
                if (!r.IsMatch(div.InnerHtml.ToString()))
                {
                    {
                        ArtistListItem artistsListItem = new();
                        artistsListItem.ArtistsName = div.InnerHtml;
                        artistsListItem.UrlSuffix = div.GetAttributeValue("href").Replace("/wiki/", "");
                        allLinks.Add(artistsListItem);
                    }
                }
            artistsList.ArtistListItems = allLinks;
            return Task.FromResult(artistsList);
        }
    }
}
