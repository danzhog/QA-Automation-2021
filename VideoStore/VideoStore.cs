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
            //Console.WriteLine("List of our Cassettes".PadLeft(49));
            Console.WriteLine($"№\t {"Movie Title",-15}\t {"Is available?",-15}\tWho took?");
            for (int i = 0; i < CassettesList.Count; i++)
            {
                Console.WriteLine($"{i}\t {CassettesList[i].MovieTitle, -15}\t {CassettesList[i].isAvalaible, -15}" +
                    $"\t{CassettesList[i].PersonWhoTookTheCassette}");
            }
            Console.Write("\n");
        }
    }
}
