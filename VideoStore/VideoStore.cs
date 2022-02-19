using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore
{
    public class VideoStore
    {
        public List<Cassette> CassettesList { get; set; }
        public VideoStore(List<Cassette> cassettesList)
        {
            CassettesList = cassettesList;
        }

        public void AddCassetteToList(Cassette cassette)
        {
            CassettesList.Add(cassette);
        }

        public void GetFullInfo()
        {
            Console.WriteLine("Number\t Movie Title\t is taken?\t who took?");
            for (int i = 0; i < CassettesList.Count; i++)
            {
                Console.WriteLine($"{i+1}\t {CassettesList[i].MovieTitle}\t {CassettesList[i].isTaken}\t {CassettesList[i].PersonWhoTookTheCassette}");
            }
        }
    }
}
