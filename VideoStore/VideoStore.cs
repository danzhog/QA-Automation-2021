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
    }
}
