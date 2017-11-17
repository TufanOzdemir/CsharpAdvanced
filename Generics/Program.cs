using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonModel jsonModel = new JsonModel();

            jsonModel.From = "Turkey";
            jsonModel.Name = "Tufan";
            jsonModel.Surname = "Özdemir";
            JSONHelper.WriteJson(jsonModel);

            jsonModel = JSONHelper.ReadJson<JsonModel>();
            Console.WriteLine($"Name: {jsonModel.Name} \nSurname: {jsonModel.Surname} \nFrom: {jsonModel.From}");

            Console.Read();
        }
    }
}
