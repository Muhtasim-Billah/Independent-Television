using System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace Count_Down
{
   public class Utility
    {
        public static EntityConnection getConnection()
        {
            string providerName = "System.Data.SqlClient";

            string serverName = "ServerName";
            string databaseName = "DBNAME";
            SqlConnectionStringBuilder sqlb = new SqlConnectionStringBuilder();
            sqlb.DataSource = serverName;
            sqlb.InitialCatalog = databaseName;

            sqlb.UserID = "adcaad";

            sqlb.Password = "adasdad";
            sqlb.IntegratedSecurity = false;
            string provs = sqlb.ToString();

            EntityConnectionStringBuilder enb = new EntityConnectionStringBuilder();
            enb.Provider = providerName;
            enb.ProviderConnectionString = provs;
            enb.Metadata = @"res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            return new EntityConnection(enb.ToString());
        }
    }
}
