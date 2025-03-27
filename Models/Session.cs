using DistractionsTracker.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Models
{
    internal class Session
    {
        public int Id { get; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int DistractionTypes { get; set; }
        public int TotalDistractionCount { get; set; }
        public List<Distraction> Distractions { get; set; }

        public Session() { }

        public Session(string startDate, string endDate, int distractionTypes, int totalDistractionCount, List<Distraction> distractions)
        {
            Id = DataManager.GenerateSessionId();
            StartDate = startDate;
            EndDate = endDate;
            DistractionTypes = distractionTypes;
            TotalDistractionCount = totalDistractionCount;
            Distractions = distractions;
        }
    }
}