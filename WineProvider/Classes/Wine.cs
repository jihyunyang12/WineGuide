using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using WineProvider.Models;

using System.Configuration;
using System.Data;

using System.Linq;
using System.Threading.Tasks;

namespace WineProvider.Classes
{
    public class Wine : IWine
    {
        private List<WineDataModel> _wineDataModels = new List<WineDataModel>();
        public Wine()
        {
            CreateWines();
        }

        public void Add(WineDataModel wine)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public WineDataModel Get()
        {
            throw new NotImplementedException();
        }

        public List<WineDataModel> GetAll()
        {
            Console.WriteLine(_wineDataModels);
            return _wineDataModels as List<WineDataModel>;
        }

        private void CreateWines()
        {
            WineDataModel wineDataModelPinotNoir = new WineDataModel();
            wineDataModelPinotNoir.Id = 0;
            wineDataModelPinotNoir.Name = "Pinot Noir";
            wineDataModelPinotNoir.Color = "Red";
            //wineDataModelPinotNoir.Taste = new List<string>() { "Cherry", "Cranberry", "Rose", "Rhubarb" };
            //wineDataModelPinotNoir.FoodPairing = new List<string>() { "Chicken", "Pork", "Duck", "Soft Cheese" };
            _wineDataModels.Add(wineDataModelPinotNoir);

            WineDataModel wineDataModelRiesling = new WineDataModel();
            wineDataModelRiesling.Id = 1;
            wineDataModelRiesling.Name = "Riesling";
            wineDataModelRiesling.Color = "White";
            //wineDataModelRiesling.Taste = new List<string>() { "citrus", "nectarine", "floral" };
            //wineDataModelRiesling.FoodPairing = new List<string>() { "chicken", "pork", "duck", "indian", "thai", "vietnamese" };
            _wineDataModels.Add(wineDataModelRiesling);

        }


    }
}