using CashCrusaders_Otokiti.DataAccess.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_Otokiti.App
{
    public class CommandHandler : ICommandHandler
    {
        private readonly IEnumerable<ItemList> _items;
        private readonly string _line;

        public CommandHandler(IEnumerable<ItemList> items, string line)
        {
            _items = items;
            _line = line;
        }

        public void HandleCommand()
        {
            var foundItem = new List<ItemList>();

            if (_line.Length == 1)
                foundItem = _items.Where(x => x.Name.StartsWith(_line, StringComparison.OrdinalIgnoreCase)).ToList();

            else if (_line.Length > 1 && !_line.Contains(' '))
                foundItem = _items.Where(x => x.Name.Contains(_line, StringComparison.OrdinalIgnoreCase)).ToList();

            else if (_line.Contains(' '))
            {
                var items = _line.Split(' ');
                foundItem = _items.Where(x => x.Name.StartsWith(items[0], StringComparison.OrdinalIgnoreCase) && x.Name.Contains(items[^1], StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (foundItem.Count == 0)
            {
                Console.WriteLine($"> Command '{_line}' not found.");
                Console.WriteLine();
            }
            else if (foundItem.Count == 1)
            {
                var item = foundItem.Single();
                Console.WriteLine($"> Item found: {item.Name}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"> Multiple matching items found: ");
                Console.WriteLine();

                foreach (var item in foundItem)
                {
                    Console.WriteLine($"> {item.Name}");
                }
            }
        }
    }
}