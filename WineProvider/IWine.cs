using System;
using System.Collections.Generic;
using WineProvider.Models;

namespace WineProvider
{
    public interface IWine
    {
        public List<WineDataModel> GetAll();
        public WineDataModel Get(int id);
        public void Add(WineDataModel wine);
        public void Delete(int id);
        public void Update(WineDataModel wine);
    }
}
