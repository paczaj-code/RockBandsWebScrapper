using HtmlAgilityPack;
using ReactApp1.Server.Interfaces;
using ReactApp1.Server.Models;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System.Text.RegularExpressions;

namespace ReactApp1.Server.Services.Factories.WebScrapper
{
    public class ArtistsImageScrapper : BaseScrapper, IWebScrapper
    {
        /// <summary>
        /// Scrapping artist images by given slug
        /// </summary>
        /// <param name="uriSuffix"></param>
        /// <returns></returns>
        public Task ScrapAsync(string uriSuffix)
        {

            WebPage PageResult = GetPageContent(uriSuffix);
            List<HtmlNode> ScrappedImages = PageResult.Html.CssSelect("img").ToList();
            List<ArtistImage> jpgImages = new();

            var r = new Regex(@".jpg");
            foreach (var node in ScrappedImages)
            {
                if (r.IsMatch(node.OuterHtml.ToString()))
                {
                    ArtistImage image = new();
                    image.Image = node.OuterHtml;
                    jpgImages.Add(image);
                }
            }
            return Task.FromResult(jpgImages);
        }
    }
}
