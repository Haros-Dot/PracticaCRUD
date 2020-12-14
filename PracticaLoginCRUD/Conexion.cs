using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PracticaLoginCRUD
{
    class Conexion
    {

        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=practica_login;Uid=root;pwd=1234;");
            conexion.Open();
            return conexion;

        }
    }
}
