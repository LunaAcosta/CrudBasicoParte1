using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CrudBasicoParte1
{
    class Crud
    {
        //Instancia
        private Connection conn = new Connection();

        // metodo para selecionar los registros de la tabla de la base de datos 

        public MySqlDataReader select( string query)
        {
            MySqlDataReader dataReader;

            //utilizar command de la clase conecion

            conn.command = new MySqlCommand(query, conn.openConnection());
            dataReader = conn.command.ExecuteReader();// lleva acabo a la consulta
            return dataReader;



        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.openConnection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery();
            conn.command.Dispose();
            conn.closeConnection();

        }
    }
}
