using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Models
{
    internal class Session
    {
        public string Date { get; set; }
        public int DistractionTypes { get; set; }
        public int TotalDistractionCount { get; set; }
        public List<Distraction> Distractions { get; set; }

        public Session() { }

        public Session(string date, int distractionTypes, int totalDistractionCount, List<Distraction> distractions)
        {
            Date = date;
            DistractionTypes = distractionTypes;
            TotalDistractionCount = totalDistractionCount;
            Distractions = distractions;
        }
    }
}