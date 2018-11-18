using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.API.Model;

namespace MyWebApp.API
{
    public class SimpleData
    {
        public static List<Band> GetBonds()
        {
            return new List<Band>()
            {
                new Band { Id = 1, Name="Alice in Chains", Genre= "Heavy Metal"},
                new Band { Id = 2, Name="Sound garden", Genre= "Grunge"},
                new Band { Id = 3, Name="Pearl Jam", Genre= "Grunge"},
                new Band { Id = 4, Name="Audio slave", Genre= "Alternative Metal"},
                new Band { Id = 5, Name="Stone Temple Pilots", Genre= "Hard Rock"},
                new Band { Id = 6, Name="Nirvana", Genre= "Grunge"},
                new Band { Id = 7, Name="Third Eye Blind", Genre= "Alternative Rock"},
                new Band { Id = 8, Name="Led Zeppelin", Genre= "Blues Rock"},
                new Band { Id = 9, Name="The Beatles", Genre= "Rock and Roll"},
                new Band { Id = 10, Name="The Rolling Stones", Genre= "Blues Rock"}
            };
        }
    }
}
