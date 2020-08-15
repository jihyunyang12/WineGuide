using System;
using System.Collections.Generic;
using WineProvider.Models;

namespace WineProvider
{
    public interface IWine
    {
        public List<WineDataModel> GetAll<WineDataModel>();
        public WineDataModel Get<WineDataModel>();
        public void Add<WineDataModel>(WineDataModel wine);
        public void Delete<WineDataModel>(int id);
    }
}
