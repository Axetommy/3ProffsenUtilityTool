using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3Proffsen_Utility_Tool
{
    internal class MyMath
    {
        double[] prisGruppList = new double[7] {385.0, 465.0, 585.0, 760.0, 925.0, 925.0, 0.0};
        double ffe = 140.0;
        public double biggerSizeCheckup(double x, double y)
        {
            if(x >= y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return 0;
            }
        }

        public double prisGruppCheckup(double x, double y)
        {
            double biggerDimension = biggerSizeCheckup(x, y);

            if(biggerDimension >= 2501.0)
            {
                return prisGruppList[5];
            }
            else if(biggerDimension <= 2500.0 && biggerDimension >= 2001.0)
            {
                return prisGruppList[4];
            }
            else if(biggerDimension <= 2000.0 && biggerDimension >= 1501.0)
            {
                return prisGruppList[3];
            }
            else if(biggerDimension <= 1500.0 && biggerDimension >= 801.0)
            {
                return prisGruppList[2];
            }
            else if(biggerDimension <= 800.0 && biggerDimension >= 301.0)
            {
                return prisGruppList[1];
            }
            else if(biggerDimension <= 300.0 && biggerDimension >= 1.0)
            {
                return prisGruppList[0];
            }
            else { return prisGruppList[6]; }
        }


        public double circularToSide(double fi)
        {
            double pi = 3.14;
            double side;

            side = (fi * pi)/4.0;

            return side;
        }

        public double rkSqMeters(double x, double y, double l, bool firstEndLocked, bool secondEndLocked) 
        {
            double sqMeters;
            double a = x / 1000.0;
            double b = y / 1000.0;
            double c = l / 1000.0;

            bool standardLenght;
            if (l == 1250.0 && firstEndLocked == false && secondEndLocked == false){standardLenght = true;}
            else { standardLenght = false; }

            if (standardLenght){sqMeters = (2.0 * a + 2.0 * b) * c;}
            else if (standardLenght == false && firstEndLocked == false && secondEndLocked == false){sqMeters = (2.0 * a + 2.0 * b) * c;}
            else if (firstEndLocked && secondEndLocked) { sqMeters = ((2.0 * a + 2.0 * b) * c) + 2.0 * (a * b); }
            else if (firstEndLocked || secondEndLocked) {sqMeters = ((2.0 * a + 2.0 * b) * c) + (a * b);}
            else { sqMeters = 0.0; }
            return sqMeters;
        }
        public double rkPris(double x, double y, double l, bool firstEndLocked, bool secondEndLocked)
        {
            double price;
            double prisGruppAmount = prisGruppCheckup(x, y);

            double addition = 140;
            double sqMeters = rkSqMeters(x, y, l, firstEndLocked, secondEndLocked);


            bool standardLenght;
            if (l == 1250.0 && firstEndLocked == false && secondEndLocked == false)
            {
                standardLenght = true;
            }
            else { standardLenght = false; }

            if (standardLenght){price = sqMeters * prisGruppAmount;}
            else if (standardLenght == false && firstEndLocked == false && secondEndLocked == false){price = sqMeters * prisGruppAmount + addition;}
            else if (firstEndLocked || secondEndLocked){price = sqMeters * prisGruppAmount + addition;}
            else { price = 0.0;}
            
            return price;
        }

        public double sqmNittiBoj(double x, double y, double radie, double secondRadie, bool firstEndLocked, bool secondEndLocked, bool sameRadieBoxChecked)
        {
            double sqMeters;
            double a = x / 1000.0;
            double b = y / 1000.0;
            double c = radie / 1000.0;
            double d = secondRadie / 1000.0;

            if (sameRadieBoxChecked) { d = c; }
            else { }

            double totalRadius = (c + d) / 2.0;

            if (firstEndLocked == false && secondEndLocked == false)
            {
                sqMeters = (2.0 * a + 2.0 * b) * (a + totalRadius - 0.03);
            }
            else if (firstEndLocked && secondEndLocked)
            {
                sqMeters = (2.0 * a + 2.0 * b) * (a + totalRadius - 0.03) + (2.0 * a * b);
            }
            else if (firstEndLocked || secondEndLocked)
            {
                sqMeters = (2.0 * a + 2.0 * b) * (a + totalRadius - 0.03) + (a * b);
            }
            else { sqMeters = 0.0; }
            return sqMeters;
        }

        public double nittiBoj(double x, double y, double radie, double secondRadie, bool firstEndLocked, bool secondEndLocked, bool sameRadieBoxChecked)
        {
            double price;
            double prisGruppAmount = prisGruppCheckup(x, y);
            double sqMeters = sqmNittiBoj(x, y, radie, secondRadie, firstEndLocked, secondEndLocked, sameRadieBoxChecked);


            double addition;
            double prisGrupp = prisGruppCheckup(x, y);

            if (prisGrupp == prisGruppList[0] || prisGrupp == prisGruppList[1])
            {
                addition = 4.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[2])
            {
                addition = 5.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[3])
            {
                addition = 7.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[4])
            {
                addition = 9.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[5])
            {
                addition = 24.0 * ffe;
            }
            else { addition= 0.0; }

            price = sqMeters * prisGruppAmount + addition;
            return price;
        }

        public double sqmFortiFemBoj(double x, double y, double radie, double secondRadie, bool firstEndLocked, bool secondEndLocked, bool sameRadieBoxChecked)
        {
            double sqMeters;
            double a = x / 1000.0;
            double b = y / 1000.0;
            double c = radie / 1000.0;
            double d = secondRadie / 1000.0;

            if (sameRadieBoxChecked) { d = c; }

            double totalRadius = c + d;

            if (!firstEndLocked && !secondEndLocked)
            {
                sqMeters = (((2.0 * a + 2.0 * b) * (a + totalRadius - 0.03)) * 0.575);
            }
            else if (firstEndLocked && secondEndLocked)
            {
                sqMeters = (((2.0 * a + 2.0 * b) * (a + totalRadius - 0.03)) * 0.575) + 2.0 * a * b;
            }
            else if (firstEndLocked || secondEndLocked)
            {
                sqMeters = (((2.0 * a + 2.0 * b) * (a + totalRadius - 0.03)) * 0.575) + a * b;
            }
            else { sqMeters = 0.0; }
            return sqMeters;
        }
        public double fortiFemBoj(double x, double y, double radie, double secondRadie, bool firstEndLocked, bool secondEndLocked, bool sameRadieBoxChecked)
        {
            double price;
            double prisGruppAmount = prisGruppCheckup(x, y);
            double addition;
            double prisGrupp = prisGruppCheckup(x, y);
            double sqMeters = sqmFortiFemBoj(x, y, radie, secondRadie, firstEndLocked, secondEndLocked, sameRadieBoxChecked);

            if (prisGrupp == prisGruppList[0] || prisGrupp == prisGruppList[1])
            {
                addition = 4.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[2])
            {
                addition = 5.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[3])
            {
                addition = 7.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[4])
            {
                addition = 9.0 * ffe;
            }
            else if (prisGrupp == prisGruppList[5])
            {
                addition = 24.0 * ffe;
            }
            else { addition = 0.0; }
            
            price = sqMeters * prisGruppAmount + addition;
            return price;
        }

        public double sqmDim(double x, double y, double l, double dimx, double dimy, bool firstEndLocked, bool secondEndLocked) 
        {
            double sqMeters;
            double a = x / 1000.0;
            double b = y / 1000.0;
            double c = l / 1000.0;
            double d = dimx / 1000.0;
            double e = dimy / 1000.0;
            double xAverage = (a + d) / 2.0;
            double yAverage = (b + e) / 2.0;


            if (firstEndLocked == false && secondEndLocked == false) { sqMeters = (2.0 * xAverage + 2.0 * yAverage) * c; }
            else if (firstEndLocked && secondEndLocked) { sqMeters = ((2.0 * yAverage + 2.0 * xAverage) * c) + 2.0 * (xAverage * yAverage); }
            else if (firstEndLocked || secondEndLocked) { sqMeters = ((2.0 * xAverage + 2.0 * yAverage) * c) + (xAverage * yAverage); }
            else { sqMeters = 0.0; }
            return sqMeters;
        }

        public double dimPris(double x, double y, double l, double dimx, double dimy, bool firstEndLocked, bool secondEndLocked, bool centeredOrGrad)
        {
            double price;
            double prisGrupp;
            double prisGruppAmount = prisGruppCheckup(x, y);
            double prisGruppDimmedSide = prisGruppCheckup(dimx, dimy);
            
            if(prisGruppAmount <= prisGruppDimmedSide) { prisGrupp = prisGruppDimmedSide; } 
            else { prisGrupp = prisGruppAmount; }
            

            double addition = 140;
            double sqMeters = sqmDim(x, y, l, dimx, dimy, firstEndLocked, secondEndLocked);

            if (centeredOrGrad)
            {
                if (prisGrupp == prisGruppList[0] || prisGrupp == prisGruppList[1])
                {
                    addition = 4.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[2])
                {
                    addition = 6.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[3])
                {
                    addition = 9.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[4])
                {
                    addition = 12.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[5])
                {
                    addition = 14.0 * ffe;
                }
                else { addition = 0.0; }
            }
            else
            {
                if (prisGrupp == prisGruppList[0] || prisGrupp == prisGruppList[1])
                {
                    addition = 5.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[2])
                {
                    addition = 7.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[3])
                {
                    addition = 10.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[4])
                {
                    addition = 13.0 * ffe;
                }
                else if (prisGrupp == prisGruppList[5])
                {
                    addition = 16.0 * ffe;
                }
                else { addition = 0.0; }
            }

            price = sqMeters * prisGrupp + addition;
            return price;
        }
    }
}
