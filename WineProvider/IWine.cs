using System;
using System.Collections.Generic;
using WineProvider.Models;

namespace WineProvider
{
    public interface IWine
    {
        public List<WineDataModel> GetAll();
        public WineDataModel Get();
        public void Add(WineDataModel wine);
        public void Delete(int id);
    }
}
