using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Services.Factories;


namespace ReactApp1.Server.Controllers;


[ApiController]
[Route("[controller]")]
public class WikiScrapperController : Controller
{

    private readonly WebScrapperFactory? _webScrapper;
    private readonly ILogger<WikiScrapperController> _logger;

    public WikiScrapperController(WebScrapperFactory? webScrapper, ILogger<WikiScrapperController> logger)
    {
        _webScrapper = webScrapper;
        _logger = logger;
    }
    /// <summary>
    /// Controller for artists list taken by given slug
    /// </summary>
    /// <param name="slug"></param>
    /// <returns>
    /// </returns>
    [HttpGet("/artistlist/{slug}")]
    public IActionResult ScrapArtistsList(string slug)
    {

        return Ok(_webScrapper.MakeScrapper("ArtistsList", slug));

    }
    /// <summary>
    /// Controller for artists details taken by given slug
    /// </summary>
    /// <param name="slug"></param>
    /// <returns></returns>
    [HttpGet("/artist/{slug}")]
    public IActionResult ScrapArtistDetails(string slug)
    {

        return Ok(_webScrapper.MakeScrapper("ArtistsDetails", slug));

    }
    /// <summary>
    /// Controller for artists images taken by given slug
    /// </summary>
    /// <param name="slug"></param>
    /// <returns></returns>
    [HttpGet("/artistimage/{slug}")]
    public IActionResult ScrapArtistImages(string slug)
    {

        return Ok(_webScrapper.MakeScrapper("ArtistsImages", slug));

    }



}




