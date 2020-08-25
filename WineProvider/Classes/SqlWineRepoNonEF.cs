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
            string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
            using SqlConnection con = new SqlConnection(_connectionString);
            using var command = new SqlCommand("insert into winecellar values ( '" + wine.Name + "', '" + wine.Color + "')", con);
            con.Open();
            DbDataReader reader = command.ExecuteReader();
            con.Close();
        }

        public void Delete(int id)
        {
            string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
            using SqlConnection con = new SqlConnection(_connectionString);
            using var command = new SqlCommand("delete from winecellar where ID = " + id, con);
            con.Open();
            DbDataReader reader = command.ExecuteReader();
            con.Close();
        }

        public WineDataModel Get(int id)
        {
            string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
            using SqlConnection con = new SqlConnection(_connectionString);
            using var command = new SqlCommand("select * from winecellar where ID = " + id, con);
            con.Open();
            DbDataReader reader = command.ExecuteReader();

            var WineData = new WineDataModel();

            {
                while (reader.Read())
                {
                    var Wine = new WineDataModel()
                    {
                        Id = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.IsDBNull(reader.GetOrdinal("name")) ? "" : reader.GetString(reader.GetOrdinal("name")),
                        Color = reader.IsDBNull(reader.GetOrdinal("color")) ? "" : reader.GetString(reader.GetOrdinal("color"))
                    };
                    WineData = Wine;
                }
            }

            con.Close();

            return WineData;
        }

        public List<WineDataModel> GetAll()
        {
            string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Wine;Trusted_Connection=True;";
            using SqlConnection con = new SqlConnection(_connectionString);
            using var command = new SqlCommand("select * from winecellar", con);
            con.Open();
            DbDataReader reader = command.ExecuteReader();

            var WineData = new List<WineDataModel>();
            {
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

            con.Close();
            return WineData;
        }

    }
}
