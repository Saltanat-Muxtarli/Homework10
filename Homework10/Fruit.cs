using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
	 abstract class Fruit
	{
		public abstract double Price { get; set; }	
		public abstract string Sort {  get; set; }


		public abstract void Taste();


	}
}
