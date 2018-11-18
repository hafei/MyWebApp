using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.API.Model
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }

    public class CreateBandDto
    {
        public string Name { get; set; }
        public string Genre { get; set; }
    }

    public class UpdateBandDto
    {
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
