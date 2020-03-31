using System;

namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for PizzaStore.
	/// </summary>
	public abstract class PizzaStore
	{
		#region Constructor
		public PizzaStore()
		{}
		#endregion//Constructor

		#region OrderPizza
		public Pizza OrderPizza(string type)
		{
			Pizza pizza;
			
			pizza = CreatePizza(type);

			Console.WriteLine(pizza.Prepare());
			Console.WriteLine(pizza.Bake());
			Console.WriteLine(pizza.Cut());
			Console.WriteLine(pizza.Box());

			return pizza;
		}
		#endregion//OrderPizza

		#region CreatePizza
		protected abstract Pizza CreatePizza(string type);
		#endregion//CreatePizza
	}
}
