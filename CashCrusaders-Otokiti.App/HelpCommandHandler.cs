using CashCrusaders_Otokiti.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_Otokiti.App
{
    public class HelpCommandHandler : ICommandHandler
    {
        private readonly IEnumerable<ItemList> _items;

        public HelpCommandHandler(IEnumerable<ItemList> items)
        {
            _items = items;
        }

        public void HandleCommand()
        {
            Console.WriteLine("> Available items on the system includes: ");
            Console.WriteLine();

            foreach (var item in _items)
            {
                Console.WriteLine($"> {item.Name}");
            }
        }
    }
}
