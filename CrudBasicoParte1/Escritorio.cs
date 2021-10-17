using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CrudBasicoParte1
{
    class Escritorio
    {
        //Propiedades 

        public int _scrict { get; set; }

        public string _categoria { get; set; }

        public string _codigo { get; set; }

        public string _color{ get; set; }

        public string _material { get; set; }


        // Instancia

        private Crud crud = new Crud();

        public MySqlDataReader getAllEscritorios()
        {
            string query = "SELEC scrict,categoria,codigo,color,material FROM escritorio";

            //Llamado al medotodo select

            return crud.select(query);


        }

        public Boolean newEditEscritorio(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO escritorio(categoria, codigo, color, material)" +
                    "VALUES ('" + _categoria + "', '" + _codigo + "', '" + _color + "', '" + _material + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "Editar")
            {
                string query = "UPDATE book SET "
                    + "categoria='" + _categoria + "' ,"
                    + "codigo='" + _codigo + "',"
                    + "color='" + _color + "',"
                    + "material='" + _material + "'"
                    + "WHERE "
                    + "strict='" + _scrict + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }



    }
}
