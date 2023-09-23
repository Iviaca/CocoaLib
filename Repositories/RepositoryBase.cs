using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.EntityFrameworkCore;

namespace CocoaLib
{
    class RepositoryBase
    {
        private string _connectionString;

        public RepositoryBase()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["npgsqlConnectionString"].ConnectionString;
        }

        /// <summary>
        /// 返回一个Datasource内有connectionstring
        /// </summary>
        /// <returns></returns>
        protected NpgsqlDataSource GetConnecton()
        {
            return NpgsqlDataSource.Create(_connectionString);
        }
    }
}
