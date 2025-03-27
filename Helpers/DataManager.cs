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

        public static Session GetSession(int targetId)
        {
            List<Session> sessions = FileManager.ReadListFromJsonFile<Session>(_dataFilePath);
            foreach (Session session in sessions)
            {
                if (session.Id == targetId)
                {
                    return session;
                }
            }
            return null;
        }

        public static void AddSession(Session session)
        {
            List<Session> currentSessions = FileManager.ReadListFromJsonFile<Session>(_dataFilePath);
            currentSessions.Add(session);
            FileManager.WriteListToJsonFile<Session>(currentSessions, _dataFilePath);
        }

        public static void ResetData()
        {
            FileManager.WriteListToJsonFile<Session>(new List<Session>(), _dataFilePath);
        }

        public static int GenerateSessionId()
        {
            List<Session> currentSessions = FileManager.ReadListFromJsonFile<Session>(_dataFilePath);
            int maxId = 0;
            foreach (Session session in currentSessions)
            {
                if (session.Id > maxId)
                {
                    maxId = session.Id;
                }
            }
            return maxId + 1;
        }
    }
}
