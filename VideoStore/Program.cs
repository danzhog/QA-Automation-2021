using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VideoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filmsList = new List<string>();
            Helper.ParseFromFile("films.txt", ref filmsList);

            List<Cassette> cassetesList = new List<Cassette>();
            Helper.ConvertStringListToCassetteList(filmsList, ref cassetesList);

            VideoStore ProkatMinsk = new VideoStore(cassetesList);

            ProkatMinsk.Play();
        }
    }
}
