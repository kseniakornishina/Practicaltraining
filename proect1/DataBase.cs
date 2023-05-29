using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace proect1
{
    public class User 
    {
        public int ID { get; }
        public string I { get; }
        public string F { get; }
        public string O { get; }

        public User(int id, string i, string f, string o)
        {
            I = i;
            F = f;
            O = o;
        }

    }
    static class DataBase
    {
        private const string path = "Data/dataG.txt";

        public static List<User> Users
        {
            get 
            { 
                List<User> users = new List<User>();
                using(StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('~');
                        users.Add(new User(int.Parse(parts[1]), parts[3], parts[5], parts[7]));
                    }
                }
                return users; 
            }
            set
            {
                File.WriteAllText("Data/dataG.txt", string.Empty);
                foreach (User user in value)
                {
                    File.AppendAllText("data/dataG.txt","~" + user.ID + "~~" + user.I + "~~" + user.F + "~~" + user.O + "~\n");
                }
            }
        }
    }
}
