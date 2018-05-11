using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MobileBuild
{
    public static class SaveLoad
    {
        public static void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/userData.dat");
            User data = new User()
            {
                Name = MainController.userName,
                Weight = MainController.userWeight,
                IsMale = MainController.userIsMale
            };
                        
            bf.Serialize(file, data);
            
            file.Close();
        }
        public static void Load()
        {
            if (File.Exists(Application.persistentDataPath + "/userData.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/userData.dat", FileMode.Open);
                User data = (User)bf.Deserialize(file);
                file.Close();

                MainController.userName = data.Name;
                MainController.userWeight = data.Weight;
                MainController.userIsMale = data.IsMale;
            }
        }
    }
}