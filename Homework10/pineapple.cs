using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
	internal class Pineapple : Fruit

	{
		public int VitaminE;
		public int VitaminD;
		private double _price;
		private string _sort;
		public override double Price
		{
			get
			{
				return _price;
			}
			set
			{

				_price = value;
			}

		}
		public override string Sort
		{
			get
			{
				return _sort;
			}
			set
			{
				_sort = value;
			}


		}

		public override void Taste()
		{
			Console.WriteLine("Bu meyvenin dadi  cox sirindir");
		}
	}
}
