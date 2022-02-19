using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VideoStore
{
    public class Helper
    {
        public static List<string> ParseFromFile(string pathToFile,ref List<string> filmsList)
        {
            filmsList = File.ReadAllLines(pathToFile).ToList();
            return filmsList;
        }
        public static List<Cassette> ConvertStringToCassette(List<string> filmsList, ref List<Cassette> cassetesList)
        {
            for (int i = 0; i < filmsList.Count; i++)
            {
                cassetesList.Add(new Cassette(filmsList[i]));
            }
            return cassetesList;
        }
    }
}
