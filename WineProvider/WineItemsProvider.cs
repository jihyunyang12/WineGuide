using System;
using System.Collections.Generic;
using System.Text;
using WineProvider.Classes;
using WineProvider.Models;

namespace WineProvider
{
    public class WineItemsProvider
    {
        public List<WineDataModel> GetWines()
        {
            Wine wine = new Wine();
            return wine.GetAll<WineDataModel>();
        }
    }
}
