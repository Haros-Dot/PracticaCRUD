using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLoginCRUD
{
    public class Usuarios
    {
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public Usuarios() { }

        public Usuarios (int id, string user, string password)
        {
            this.id = id;
            this.user = user;
            this.password = password;
        }
    }
}
