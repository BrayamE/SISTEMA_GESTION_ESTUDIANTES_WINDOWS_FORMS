using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Estudiante
    {
        [PrimaryKey,Identity]
        public int ID { get; set; }
        public string DNI { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string EMAIL { get; set; }
        public byte[] image { get; set; }
    }
}
