namespace VideoStore
{
    public class Cassette
    {
        public string MovieTitle { get; set; }
        public bool isTaken = false;
        public string PersonWhoTookTheCassette = null;

        public Cassette(string movieTitle)
        {
            MovieTitle = movieTitle;
        }

    }
}