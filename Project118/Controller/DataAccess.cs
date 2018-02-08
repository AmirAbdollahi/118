using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project118.Controller
{
    class DataAccess
    {
        SqlConnection connection;
        SqlCommand command;

        public void Connect()
        {
            connection = new SqlConnection("Data Source=.;Initial Catalog=db118;Integrated Security=True");
            command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
        }

        public void DynamciSearch(string searchText, DataGridView dataGridView)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spDynamicSearchAllFields";

            command.Parameters.Add("@search", SqlDbType.NVarChar);
            command.Parameters[0].Value = searchText;

            SqlDataReader reader = command.ExecuteReader();

            List<Model.View118> view118List = new List<Model.View118>();
            while (reader.Read())
            {
                Model.View118 view118 = 
                    new Model.View118((long)reader[0], reader[1].ToString(), reader[2].ToString(), 
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    (int)reader[7], reader[8].ToString());

                view118List.Add(view118);
            }

            dataGridView.DataSource = view118List;
        }

        public void Disconnect()
        {
            connection.Close();
        }
    }
}
