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
            //WineDataModel wineDataModelPinotNoir = new WineDataModel();
            //wineDataModelPinotNoir.Name = "Pinot Noir";
            //wineDataModelPinotNoir.Color = "Red";
            ////wineDataModelPinotNoir.Taste = new List<string>() { "Cherry", "Cranberry", "Rose", "Rhubarb" };
            ////wineDataModelPinotNoir.FoodPairing = new List<string>() { "Chicken", "Pork", "Duck", "Soft Cheese" };
            //_wineDataModels.Add(wineDataModelPinotNoir);

            //WineDataModel wineDataModelRiesling = new WineDataModel();
            //wineDataModelRiesling.Name = "Riesling";
            //wineDataModelRiesling.Color = "White";
            ////wineDataModelRiesling.Taste = new List<string>() { "citrus", "nectarine", "floral" };
            ////wineDataModelRiesling.FoodPairing = new List<string>() { "chicken", "pork", "duck", "indian", "thai", "vietnamese" };
            //_wineDataModels.Add(wineDataModelRiesling);

            var WineData = new WineDataModel();
            {
                //string _connectionString = ConfigurationManager.ConnectionStrings["DotaConnection"].ConnectionString;
                string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
                using SqlConnection con = new SqlConnection(_connectionString);
                using var command = new SqlCommand("select * from winecellar", con);
                con.Open();
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var WineModel = new WineDataModel
                    {
                        Name = reader.IsDBNull(reader.GetOrdinal("name")) ? "" : reader.GetString(reader.GetOrdinal("name")),
                        Color = reader.IsDBNull(reader.GetOrdinal("color")) ? "" : reader.GetString(reader.GetOrdinal("color"))
                    };
                    _wineDataModels.Add(WineModel);
                }
            };


        }


    }
}