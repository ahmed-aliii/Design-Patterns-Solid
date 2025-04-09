using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{

    // Step 2: Create a Builder
    public class BurgerBuilder
    {

        //Readonly => Once you assigne Object you can't change its state
        private readonly Burger _burger = new Burger();

        //Why Use return this;?
        //Method Chaining → this Allows calling multiple methods in a single statement.
        public BurgerBuilder SetBread(string? bread)
        {
            _burger.Bread = bread;
            return this;
        }
        public BurgerBuilder AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            _burger.Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public BurgerBuilder AddDoublePatty()
        {
            _burger.DoublePatty = true;
            return this;
        }

        //Return The Whole Object
        public Burger Build()
        {
            return _burger;
        }
    }
}
