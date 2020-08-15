using System;
using System.Collections.Generic;
using System.Text;
using WineProvider.Models;

namespace WineProvider.Classes
{
    public class Wine : IWine
    {
        private List<WineDataModel> _wineDataModels = new List<WineDataModel>();
        public Wine()
        {
            CreateWines();
        }

        public void Add<WineDataModel>(WineDataModel wine)
        {
            throw new NotImplementedException();
        }

        public void Delete<WineDataModel>(int id)
        {
            throw new NotImplementedException();
        }

        public WineDataModel Get<WineDataModel>()
        {
            throw new NotImplementedException();
        }

        public List<WineDataModel> GetAll<WineDataModel>()
        {
            Console.WriteLine(_wineDataModels);
            return _wineDataModels as List<WineDataModel>;
        }

        private void CreateWines()
        {
            WineDataModel wineDataModelPinotNoir = new WineDataModel();
            wineDataModelPinotNoir.Name = "Pinot Noir";
            wineDataModelPinotNoir.Color = "Red";
            wineDataModelPinotNoir.Taste = new List<string>() { "Cherry", "Cranberry", "Rose", "Rhubarb" };
            wineDataModelPinotNoir.FoodPairing = new List<string>() { "Chicken", "Pork", "Duck", "Soft Cheese" };
            _wineDataModels.Add(wineDataModelPinotNoir);

            WineDataModel wineDataModelRiesling = new WineDataModel();
            wineDataModelRiesling.Name = "Riesling";
            wineDataModelRiesling.Color = "White";
            wineDataModelRiesling.Taste = new List<string>() { "Citrus", "Nectarine", "Floral" };
            wineDataModelRiesling.FoodPairing = new List<string>() { "Chicken", "Pork", "Duck", "Indian", "Thai", "Vietnamese" };
            _wineDataModels.Add(wineDataModelRiesling);
        }
    }
}