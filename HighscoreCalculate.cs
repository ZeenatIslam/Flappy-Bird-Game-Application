using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
namespace Flappy_Bird_Windows_Game_Application
{
    internal class HighscoreCalculate
    {

        public static int HS(int score)
        {
            int[] highscore = { 100, 20, 30, 40, 50, 60 };
            string filepath = "E:\\Windows_Application\\Files\\Apple.txt";
            using (StreamWriter writer = new StreamWriter(filepath,true))
            {
               
                    writer.WriteLine(score);
                
            }
            
            //read the numbers from the file and store them in an array
            int[] Numbers = File.ReadLines(filepath).Select(int.Parse).ToArray();
            //finding the maximum number
            int maxNumber = Numbers.Max();
            //the maximum number from the file is 
            return maxNumber;
        }


        
    }
}

