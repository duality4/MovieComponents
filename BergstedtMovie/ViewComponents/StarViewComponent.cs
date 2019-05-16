using BergstedtMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BergstedtMovie.ViewComponents
{
    public class StarViewComponent : ViewComponent
    {
        private readonly BergstedtMovieContext _context;

        public StarViewComponent(BergstedtMovieContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            var movie = await _context.Movie.FindAsync(movieId);
            var doubleRating = (int)Math.Round(movie.Rating * 2);
            var model = new StarsViewModel
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };
            return View(model);
        }
    }
}
