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
        public void Update(WineDataModel wine)
        {
            throw new NotImplementedException();
        }
        public WineDataModel Get(int id)
        {
            return _wineDataModels.Find(wine => wine.Id == id);
        }

        public List<WineDataModel> GetAll()
        {
            return _wineDataModels;
        }

        private void CreateWines()
        {
            WineDataModel wineDataModelPinotNoir = new WineDataModel();
            wineDataModelPinotNoir.Id = 0;
            wineDataModelPinotNoir.Name = "Pinot Noir";
            wineDataModelPinotNoir.Color = "Red";
            wineDataModelPinotNoir.Fruit = "Medium-high";
            wineDataModelPinotNoir.Body = "Full body";
            wineDataModelPinotNoir.Tannin = "Medium-high";
            _wineDataModels.Add(wineDataModelPinotNoir);

            WineDataModel wineDataModelRiesling = new WineDataModel();
            wineDataModelRiesling.Id = 1;
            wineDataModelRiesling.Name = "Riesling";
            wineDataModelRiesling.Color = "White";
            wineDataModelRiesling.Fruit = "High";
            wineDataModelRiesling.Body = "Light body";
            wineDataModelRiesling.Tannin = "Medium";
            _wineDataModels.Add(wineDataModelRiesling);

        }


    }
}