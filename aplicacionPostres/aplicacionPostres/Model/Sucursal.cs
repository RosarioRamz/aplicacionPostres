using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionPostres.Model
{
    public class Sucursal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
