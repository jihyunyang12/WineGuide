using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WineProvider.Models;

namespace WineProvider.Classes
{
    public class SqlWineRepoNonEF : IWine
    {
        public void Add(WineDataModel wine)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public WineDataModel Get(int id)
        {
            var WineData = new WineDataModel();
            {
                string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
                using SqlConnection con = new SqlConnection(_connectionString);
                using var command = new SqlCommand("select * from winecellar where ID = " + id, con);
                con.Open();
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Wine = new WineDataModel
                    {
                        Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.IsDBNull(reader.GetOrdinal("name")) ? "" : reader.GetString(reader.GetOrdinal("name")),
                        Color = reader.IsDBNull(reader.GetOrdinal("color")) ? "" : reader.GetString(reader.GetOrdinal("color"))
                    };
                    WineData = Wine;
                }
            }
            return WineData;
        }

        public List<WineDataModel> GetAll()
        {
            var WineData = new List<WineDataModel>();
            {
                string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
                using SqlConnection con = new SqlConnection(_connectionString);
                using var command = new SqlCommand("select * from winecellar", con);
                con.Open();
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Wine = new WineDataModel
                    {
                        Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.IsDBNull(reader.GetOrdinal("name")) ? "" : reader.GetString(reader.GetOrdinal("name")),
                        Color = reader.IsDBNull(reader.GetOrdinal("color")) ? "" : reader.GetString(reader.GetOrdinal("color"))
                    };
                    WineData.Add(Wine);
                }
            };
            return WineData;
        }

    }
}
