using System;
using System.IO;
using System.Threading.Tasks;

namespace Geekbrains.Lesson5.ScannerEmulator
{
    public class GenerateScannerFile : IGenerateScannerFile
    {
        Random rnd = new Random();
        public void GenerateScannerData()
        {
            int MaterialId = 0;
            string[] lines = new string[10];

            for (int i=0; i<10; i++)
            {
                MaterialId=rnd.Next(1000000, 9999999);      //I Generate New random Id
                lines [i]= Convert.ToString(MaterialId);    //Convert it to string 
            }

            if (File.Exists("Scanner.txt"))
            {
                File.Delete("Scanner.txt"); //Delete file that Ids would be always new
            }            
            File.WriteAllLines("Scanner.txt", lines); //Write Id to the file
        }
    }
}
