namespace VideoStore
{
    public class Cassette
    {
        public string MovieTitle { get; set; }
        public bool isAvalaible = true;
        public string PersonWhoTookTheCassette = null;

        public Cassette(string movieTitle)
        {
            MovieTitle = movieTitle;
        }
    }
}