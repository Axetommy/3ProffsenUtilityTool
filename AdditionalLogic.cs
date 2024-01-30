using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _3Proffsen_Utility_Tool
{
    internal class AdditionalLogic : Items
    {

        internal static void CreatingNewFile()
        {

            DateTime today = DateTime.Today;
            string stringToday = Convert.ToString(today.ToString());

            string replacedToday = stringToday.Replace("/", "_");
            string replacedAgainToday = replacedToday.Replace(":", "_");
            int todayFileNumber = 1;
            string fileName = $"{replacedAgainToday}_{todayFileNumber}";
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = System.IO.Path.GetDirectoryName(strExeFilePath);
            string filePath = directory +"\\"+ fileName;

            

            bool existingFileFound = File.Exists(filePath);

            while (existingFileFound)
            {
                todayFileNumber++;
            }
            if (!existingFileFound)
            {
                File.WriteAllText(filePath, replacedAgainToday);
            }
        }
        public string canalType { get; set; }
        public int canalID { get; set; }

        List<AdditionalLogic> Rk = new List<AdditionalLogic>();


        public string writingDownDetails(int canalID, string xDimension, string yDimension, string lenght, string radie, string secondRadie, string dimx, string dimy, bool firstEndLocked, bool secondEndLocked, string qty)
        {
            string canalType;
            if (canalID == 1)
            {

                canalType = "RK";
                return $"Type {canalType} {xDimension} x {yDimension} L= {lenght} Qty:{qty} ";

            }
            else if (canalID == 2)
            {
                canalType = "90Böj";
                return $"Type {canalType} {xDimension} x {yDimension} R1= {radie} R2= {secondRadie} Qty:{qty}";

            }
            else if (canalID == 3)
            {
                canalType = "45Böj";
                return $"Type {canalType} {xDimension} x {yDimension} R1= {radie} R2= {secondRadie} Qty:{qty}";

            }
            else if (canalID == 4)
            {
                canalType = "Avstick";
                return $"Type {canalType} {xDimension} x {yDimension} L= {lenght} Qty:{qty}";
            }
            else if (canalID == 5)
            {
                canalType = "Dim";
                return $"Type {canalType} {xDimension} x {yDimension} => {dimx} x {dimy} L= {lenght} Qty:{qty}";
            }
            else return "Confusion";
        }

        public override string ToString()
        {
            return String.Format($"Id:{0}\nQuantity{14}\n {1}x{2}\n(Only if Dim)\n=>{5}x{6}\ncentered = {9}\nL/R={3}{4} \nBotten:{7} 2ndBotten:{8}\nSquare meters for single: {12}, Price for single: {10}\nTotal square meters = {13}, Total Price = {11}", Id, X, Y, Lenght, Radie, DimmedX, DimmedY, WithBotten, WithSecondBotten, Centered, Price, TotalPrice, SquareMeters, TotalSquareMeters, Quantity);
        }

    }
}
