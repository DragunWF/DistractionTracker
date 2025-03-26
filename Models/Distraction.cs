using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Models
{
    internal class Distraction
    {
        public string DistractionName { get; set; }
        public int DistractionCount { get; set; }  

        public Distraction() { }

        public Distraction(string distractionName,  int distractionCount)
        {
            DistractionName = distractionName;
            DistractionCount = distractionCount;
        }
    }
}
