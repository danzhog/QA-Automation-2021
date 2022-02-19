using System;
using System.Collections.Generic;

namespace VideoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Cassette HarryPotter = new Cassette("Harry Potter");
            Cassette FastAndFurious = new Cassette("Fast and Furious");
            Cassette Transformers = new Cassette("Transformers");
            Cassette Avatar = new Cassette("Avatar");
            Cassette DeadIsland = new Cassette("Dead Island");
            Cassette SpiderMan = new Cassette("Spider Man");

            Person VasyaPupkin = new Person("Vasya Pupkin");
            Person VanyaGrach = new Person("Vanya Grach");
            Person KostyaKal = new Person("Kostya Kalinin");

            List<Cassette> spisok1 = new List<Cassette>();
            VideoStore magazin = new VideoStore(spisok1);
            magazin.AddCassetteToList(SpiderMan);
            magazin.AddCassetteToList(DeadIsland);
            magazin.AddCassetteToList(Avatar);
            magazin.AddCassetteToList(Transformers);
            magazin.AddCassetteToList(HarryPotter);
            magazin.AddCassetteToList(FastAndFurious);

            magazin.GetFullInfo();

            KostyaKal.TakeСassette(SpiderMan);
            VanyaGrach.TakeСassette(Avatar);
            VasyaPupkin.TakeСassette(Avatar);
            KostyaKal.TakeСassette(SpiderMan);

            magazin.GetFullInfo();

            VasyaPupkin.HandOverСassette(SpiderMan);
            KostyaKal.HandOverСassette(SpiderMan);

            magazin.GetFullInfo();
        }
    }
}
