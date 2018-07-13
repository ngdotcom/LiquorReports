using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using LiquorLibrary.Models;

namespace LiquorLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $@"{ ConfigurationManager.AppSettings["filePath"] }\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<LiquorModel> ConvertToLiquorModel(this List<string> lines)
        {
            List<LiquorModel> output = new List<LiquorModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                LiquorModel l = new LiquorModel();

                l.ItemName = cols[0];
                l.Quantity = cols[1];

                output.Add(l);
            }
            return output;
        }
        public static void SaveToLiquorReport(this List<LiquorModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (LiquorModel lm in models)
            {
                lines.Add($"{ lm.ItemName },{ lm.Quantity }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
