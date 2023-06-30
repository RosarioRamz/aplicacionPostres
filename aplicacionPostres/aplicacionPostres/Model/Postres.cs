using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionPostres.Model
{
    public class Postres
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
    }
}
