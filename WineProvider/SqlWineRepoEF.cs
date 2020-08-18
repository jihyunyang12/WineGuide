using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WineProvider.Classes;

namespace WineProvider
{
    public class SqlWineRepoEF: IWine
    {
        private readonly WineContext _wineContext;

        public SqlWineRepoEF(WineContext wineContext)
        {
            _wineContext = wineContext;
        }

        public List<WineDataModel> GetAll<WineDataModel>()
        {
            Console.WriteLine(_wineContext.WineDataModels.ToList());
            return _wineContext.WineDataModels.ToList() as List<WineDataModel>;
        }

        public WineDataModel Get<WineDataModel>()
        {
            throw new NotImplementedException();
        }

        public void Add<WineDataModel>(WineDataModel wine)
        {
            throw new NotImplementedException();
        }

        public void Delete<WineDataModel>(int id)
        {
            throw new NotImplementedException();
        }

    }
}
