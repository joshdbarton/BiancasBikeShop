using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// renaming here so that code looks the same as if we were using ADO.NET for SQL Server
using SqlConnection = Microsoft.Data.Sqlite.SqliteConnection;
using BiancasBikeShop.Models;

namespace BiancasBikeShop.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private SqlConnection Connection
        {
            get
            {
                return new SqlConnection("Data Source=BiancasBikeShop.sqlite3");
            }
        }

        public List<Bike> GetAllBikes()
        {
            var bikes = new List<Bike>();
            // implement code here... 
            return bikes;
        }

        public Bike GetBikeById(int id)
        {
            Bike bike = null;
            //implement code here...
            return bike;
        }

        public int GetBikesInShopCount()
        {
            int count = 0;
            // implement code here... 
            return count;
        }
    }
}
