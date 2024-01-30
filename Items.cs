using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Proffsen_Utility_Tool
{
    class Items

    {
        public int iDCounter = 0;

        public int Id;
        public string Price;
        public string TotalPrice;
        public string SquareMeters;
        public string TotalSquareMeters;
        public string Quantity;

        public string X;
        public string Y;
        public bool WithBotten;
        public bool WithSecondBotten;


        public string Lenght;
        public string Radie;

        public string DimmedX;
        public string DimmedY;
        public bool Centered;
        public static int Counter;

        public Items(string x = "", string y = "", string l = "", string radie = "", string dimX = "", string dimY = "", bool botten = false, bool secondBotten = false, bool centered = true, string price = "", string totalPrice = "", string squareMeters = "", string totalSquareMeters = "", string quantity = "") 
        {
            X = x;
            Y = y;

            Lenght = l;
            Radie = radie;
            DimmedX = dimX;
            DimmedY = dimY;
            Centered = centered;


            WithBotten = botten;
            WithSecondBotten = secondBotten;

            Price = price;
            TotalPrice = totalPrice;
            SquareMeters = squareMeters;
            TotalSquareMeters = totalSquareMeters;

            Quantity = quantity;
            Id = Counter;
            Counter++;
        }

    }
}
