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
            List<string> allLinesText = File.ReadAllLines("films.txt").ToList();
            List<Cassette> spisok1 = new List<Cassette>();

            for (int i = 0; i < allLinesText.Count; i++)
            {
                spisok1.Add(new Cassette() {MovieTitle = allLinesText[i]});
            }

            Person VasyaPupkin = new Person("Vasya Pupkin");
            Person VanyaGrach = new Person("Vanya Grach");
            Person KostyaKal = new Person("Kostya Kalinin");

            VideoStore ProkatMinsk = new VideoStore(spisok1);

            ProkatMinsk.GetFullInfo();

            KostyaKal.TakeСassette(0, ProkatMinsk);
            VanyaGrach.TakeСassette(4, ProkatMinsk);
            VasyaPupkin.TakeСassette(3, ProkatMinsk);
            KostyaKal.TakeСassette(3, ProkatMinsk);

            ProkatMinsk.GetFullInfo();

            VasyaPupkin.HandOverСassette(2, ProkatMinsk);
            KostyaKal.HandOverСassette(0, ProkatMinsk);

            ProkatMinsk.GetFullInfo();
        }
    }
}
