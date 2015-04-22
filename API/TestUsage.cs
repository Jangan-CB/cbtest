using ClashBot.Execution.API.Methods;
using ClashBot.Execution.API.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClashBot.Execution.API
{
    class TestUsage
    {
        private readonly MethodContext ctx = new MethodContext();
        
        public void test()
        {
            // Example 1 of usage using methods!
            ctx.heroes.get(Heroes.King).activateAbility();

            // Example 2 of usage using wrappers!
            Hero hero = new Hero(Heroes.King);
            hero.activateAbility();
        }
    }
}
