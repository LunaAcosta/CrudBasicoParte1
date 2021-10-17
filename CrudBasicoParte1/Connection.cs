using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CrudBasicoParte1
{
    class Connection
    {

        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=smis083121;Uid=root;" +
                "Pwd=usbw;SSL Mode=None");

        public MySqlCommand command;

        //Abrir La coneccion

        public MySqlConnection openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }

        // Cerrar la Connecion

        public MySqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
        

    }
}
