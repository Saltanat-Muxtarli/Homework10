using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fruit[] basket = new Fruit[3];
			basket[0] = new Apple { Price=5.6, Sort="Yellow Apple", VitaminA=10, VitaminB=5};
			basket[1] = new Pineapple { Price=8, Sort= "Black PineApple", VitaminD=15, VitaminE=9};
			basket[2] = new Orange { Price=6.4, Sort= "Great Orange", VitaminC=25};

			foreach (var fruit in basket)
			
			{
				if ( fruit is Apple apple)
				{
					Console.WriteLine($"Apple-Price: { apple.Price}, Sort: {apple.Sort}, VitaminA: {apple.VitaminA}, VitaminB: {apple.VitaminB}");

				}
				else if ( fruit is Pineapple pineapple)			
			    {
                    Console.WriteLine($"Pineapple-Price:{ pineapple.Price}, Sort:{pineapple.Sort}, VitaminD{pineapple.VitaminD}, VitaminE:{pineapple.VitaminE}");
                }
				else if ( fruit is Orange orange)
				{


					Console.WriteLine($"Orange-Price:{orange.Price}, Sort: {orange.Sort}, VitaminC:{orange.VitaminC}");
				}


				fruit.Taste();
                



            }
			

		}
		
	}

}
