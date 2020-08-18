using System;
using System.Collections.Generic;
using System.Text;
using WineProvider.Classes;
using WineProvider.Models;

namespace WineProvider
{
    public class WineItemsProvider
    {
        //private readonly SqlWineRepoEF _sqlWineRepoEF;

        //public WineItemsProvider(SqlWineRepoEF sqlwinerepoef)
        //{
        //    _sqlWineRepoEF = sqlwinerepoef;
        //}

        //private readonly WineContext _wineContext;

        //public WineItemsProvider(WineContext wineContext)
        //{
        //    _wineContext = wineContext;
        //}

        public List<WineDataModel> GetWines()
        {
            //SqlWineRepoEF wine = new SqlWineRepoEF();
            Wine wine = new Wine();
            return wine.GetAll<WineDataModel>();
        }
    }
}
