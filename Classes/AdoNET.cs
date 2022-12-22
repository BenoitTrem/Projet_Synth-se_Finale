using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2027678
// Benoit Tremblay

namespace Projet_Synthèse_Final
{
    public class AdoNET
    {
        // Attributs privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtVehicule;
        private DataSet dsLocation;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataTable DtVehicule { get => dtVehicule; set => dtVehicule = value; }
        public DataSet DsLocation { get => dsLocation; set => dsLocation = value; }
       
        public AdoNET()
        {   // Integrated Security=True;
            connectionString = "Data Source=DESKTOP - LJD0C65; Initial Catalog = Location; User ID=sa; Password=sql";           
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsLocation = new DataSet();
            dtVehicule = new DataTable();
        }
    }
}
