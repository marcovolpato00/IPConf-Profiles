using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IP_Configuration_Profiles
{
    static class ProfilesCollection
    {
        public static List<NetworkProfile> Profiles { get; set; }

        private static string FileName = "profiles.bin";

        static ProfilesCollection()
        {
            Profiles = new List<NetworkProfile>();
            LoadProfiles();
        }

        #region Metodi pubblici

        public static void AddProfile(NetworkProfile profile)
        {
            Profiles.Add(profile);
            SaveProfiles();
        }

        public static void RemoveProfile(NetworkProfile profile)
        {
            Profiles.Remove(profile);
            SaveProfiles();
        }

        public static void SaveProfiles()
        {
            try
            {
                Stream file = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(file, Profiles);
                file.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public static void LoadProfiles()
        {
            try
            {
                if (File.Exists(FileName))
                {
                    Stream file = File.OpenRead(FileName);
                    BinaryFormatter serializer = new BinaryFormatter();
                    Profiles = (List<NetworkProfile>)serializer.Deserialize(file);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public static bool IsEmpty()
        {
            if (Profiles.Count == 0)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
