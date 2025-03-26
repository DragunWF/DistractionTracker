using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DistractionsTracker.Helpers
{
    internal class FileManager
    {
        public static void WriteListToJsonFile<T>(List<T> list, string filePath)
        {
            try
            {
                // Ensure the directory exists
                string directory = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Configure JSON serialization options
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true, // Makes the JSON more readable
                    PropertyNameCaseInsensitive = true
                };

                // Serialize the list to a JSON string
                string jsonString = JsonSerializer.Serialize(list, options);

                // Write the JSON string to a file
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                // Handle any potential errors
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public static List<T> ReadListFromJsonFile<T>(string filePath)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    return new List<T>(); // Return an empty list if file doesn't exist
                }

                // Read the JSON string from the file
                string jsonString = File.ReadAllText(filePath);

                // Configure JSON deserialization options
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Deserialize the JSON string back to a list of objects
                List<T> list = JsonSerializer.Deserialize<List<T>>(jsonString, options);

                return list;
            }
            catch (Exception ex)
            {
                // Handle any potential errors
                Console.WriteLine($"Error reading from file: {ex.Message}");
                return new List<T>();
            }
        }   
    }
}