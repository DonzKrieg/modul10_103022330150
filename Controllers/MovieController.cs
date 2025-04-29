using Microsoft.AspNetCore.Mvc;

namespace modul10_103022330150.Controllers
{
    [Route("api/Movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<string> star1 = new List<string>
        {
            new string("Tim Robbins"),
            new string("Morgan Freeman"),
            new string("Bob Gunton")
        };

        private static List<string> star2 = new List<string>
        {
            new string("Marlon Brando"),
            new string("Al Pacino"),
            new string("James Caan")
        };

        private static List<string> star3 = new List<string>
        {
            new string("Christian Bale"),
            new string("Heath Ledger"),
            new string("Aaron Eckhart")
        };

        private static List<Movie> moviesList = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", star1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", star2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", star3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return moviesList;
        }

        [HttpGet("{index}")]
        public Movie Get(int index)
        {
            return moviesList[index];
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            moviesList.Add(movie);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            moviesList.RemoveAt(index);
        }
    }
}
