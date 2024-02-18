
using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UzMovie.Controllers;

public class UzMovieController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult MainPage()
    {
        return View();
    }
    public IActionResult Hollywood()
    {
        UzMovie movie = new UzMovie()
        {
            Id=1,
            Name="Madakaskar",
            Year=1990,
            Country="USA"
        };

        return View(movie);
    }
    public IActionResult AddFilm()
    {
       
        return View();
    }
} 