using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class JSONHelper
    {
        public static bool WriteJson<T>(T model)
        {
            try
            {
                if (!System.IO.File.Exists("config.json"))
                {
                    return false;
                }
                System.IO.File.WriteAllText("config.json", JsonConvert.SerializeObject(model, Formatting.Indented));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static T ReadJson<T>()
        {
            T result;
            try
            {
                if (System.IO.File.Exists("config.json"))
                {
                    string configText = System.IO.File.ReadAllText("config.json");
                    T jsonObject = JsonConvert.DeserializeObject<T>(configText);
                    result = jsonObject;
                }
                else
                {
                    result = default(T);
                }
            }
            catch
            {
                result = default(T);
            }
            return result;
        }
    }
}
