using System;
using System.Collections.Generic;
using System.Text;
using WineProvider.Classes;
using WineProvider.Models;

namespace WineProvider
{
    public class WineItemsProvider
    {
        private readonly IWine _repository;

        public WineItemsProvider(IWine repository)
        {
            _repository = repository;
        }

        public List<WineDataModel> GetWines()
        {
            return _repository.GetAll();
        }

        public WineDataModel GetWineById(int id)
        {
            return _repository.Get(id);
        }

        public void AddWine(WineDataModel wine)
        {
            _repository.Add(wine);
        }

        public void DeleteWine(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateWine(WineDataModel wine)
        {
            _repository.Update(wine);
        }
    }
}
