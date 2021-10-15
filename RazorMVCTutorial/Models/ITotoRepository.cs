using RazorMVCTutorial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMVCTutorial.Models
{
    public interface ITotoRepository
    {
    }

    public class TotoRepository : ITotoRepository

    {
        public TotoRepository(DateTime date, MvcMovieContext movieContext)
        {

        }
    }
}
