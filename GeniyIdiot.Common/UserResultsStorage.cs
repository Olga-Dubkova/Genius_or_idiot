using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class UserResultsStorage
    {
        public static string FileName = "userResults.json";
        public static void Save(User user)
        {
            var userResults = Get();
            userResults.Add(user);
            Save(userResults);
        }

        public static List<User> Get()
        {
            if(!FileProvider.Exists(FileName))
            {
                return new List<User>();
            }
            var value = FileProvider.GetValue(FileName);
            var userResults = JsonConvert.DeserializeObject<List<User>>(value);    
            return userResults;
        }
        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(FileName, jsonData);
        }
    }
}