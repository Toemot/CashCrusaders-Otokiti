using CashCrusaders_Otokiti.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders_Otokiti.DataAccess.Data
{
    public class DataProvider
    {
        public IEnumerable<ItemList> LoadItems()
        {
            yield return new ItemList { Id = 1, Name = "Users" };
            yield return new ItemList { Id = 2, Name = "User Groups" };
            yield return new ItemList { Id = 3, Name = "User Activity Log" };
            yield return new ItemList { Id = 4, Name = "Report Designer" };
            yield return new ItemList { Id = 5, Name = "Report Activity Log" };
            yield return new ItemList { Id = 6, Name = "Security" };
            yield return new ItemList { Id = 7, Name = "Security Log" };
            yield return new ItemList { Id = 8, Name = "Security Access" };
            yield return new ItemList { Id = 9, Name = "Security Management" };
            yield return new ItemList { Id = 10, Name = "Database" };
            yield return new ItemList { Id = 11, Name = "Database Management" };
            yield return new ItemList { Id = 12, Name = "Database Control" };
            yield return new ItemList { Id = 13, Name = "Printers" };
            yield return new ItemList { Id = 14, Name = "Printer Control" };
        }
    }
}
