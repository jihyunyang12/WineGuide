using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WineProvider.Classes;
using WineProvider.Models;

namespace WineProvider.Classes
{
    public class SqlWineRepoEF: IWine
    {
        private readonly WineContext _wineContext;

        public SqlWineRepoEF(WineContext wineContext)
        {
            _wineContext = wineContext;
        }

        public List<WineDataModel> GetAll()
        {
            Console.WriteLine(_wineContext.WineCellar.ToList());
            return _wineContext.WineCellar.ToList() as List<WineDataModel>;
        }

        public WineDataModel Get()
        {
            throw new NotImplementedException();
        }

        public void Add(WineDataModel wine)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
