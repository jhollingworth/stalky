using System;
using Stalky.Model;

namespace Stalky
{
    public class CelebFinderContext
    {
        public string Name { get; set; }
        public string WikipediaUrl { get; set; }
        public Celebrity Celebrity { get; set; }
    }
}