using Newtonsoft.Json;
using Domain.Classes;
using System;
using System.IO;


namespace Domain.DataBase
{
    public class DataBase
    {
        private string _dogAppPath;
        private string _dogFilePath;

        public DataBase()
        {
            _dogAppPath = @"..\..\..\JsonFile";
            _dogFilePath = _dogAppPath + @"\Dogs.json";

            if (!Directory.Exists(_dogAppPath))
            {
                Directory.CreateDirectory(_dogAppPath);
            }

            if (!File.Exists(_dogFilePath))
            {
                File.Create(_dogFilePath).Close();
            }
            Dog[] data = Read();
            if (data == null)
            {
                Dog[] dogs = new Dog[0] { };
                Write(dogs);
            }
        }
        public void Insert(Dog entity)
        {
            Dog[] data = Read();
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = entity;
            Write(data);
        }
        public void GetAll()
        {
            foreach (Dog dog in Read())
            {
                Console.WriteLine(dog.GetInfo());
            }
        }
        private Dog[] Read()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(_dogFilePath))
                {
                    string data = streamReader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Dog[]>(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void Write(Dog[] dogs)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(_dogFilePath))
                {
                    string data = JsonConvert.SerializeObject(dogs);
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

        }
    }
}
