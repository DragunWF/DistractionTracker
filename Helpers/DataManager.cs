using DistractionsTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Helpers
{
    internal class DataManager
    {
        private static readonly string _dataFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            @"AppData\data.json"
        );

        public static List<Session> GetSessions()
        {
            return FileManager.ReadListFromJsonFile<Session>(_dataFilePath);
        }

        public static void AddSession(Session session)
        {
            List<Session> currentSessions = FileManager.ReadListFromJsonFile<Session>(_dataFilePath);
            currentSessions.Add(session);
            FileManager.WriteListToJsonFile<Session>(currentSessions, _dataFilePath);
        }
    }
}
