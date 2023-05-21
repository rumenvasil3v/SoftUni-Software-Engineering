using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double priceSneakers = annualFee - annualFee * 0.4;
            
            
            double basketballEquipment = priceSneakers - priceSneakers * 0.2;
          
            
            double basketBall = basketballEquipment * 0.25 ;
            

            double аccessories = basketBall * 0.20; 
            

            Console.WriteLine(annualFee + priceSneakers + basketballEquipment + basketBall + аccessories);


        }
    }
}
