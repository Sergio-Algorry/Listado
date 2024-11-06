using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Contactos
    {
        public DataTable Lista { get; set; } 

        public Contactos()
        {
            Lista = new DataTable();
            Lista.TableName = "Contactos";
            Lista.Columns.Add("Celu");
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Apellido");
            Lista.Columns.Add("NumLlamadas", typeof(int));

            LeerArchivo();
        }

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Contactos.xml"))
            {
                Lista.ReadXml("Contactos.xml");
            }
        }

        public void Insert(Contacto contacto)
        {
            Lista.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Celu"] = contacto.Celu;
            Lista.Rows[NuevoRenglon]["Nombre"] = contacto.Nombre;
            Lista.Rows[NuevoRenglon]["Apellido"] = contacto.Apellido;
            Lista.Rows[NuevoRenglon]["NumLlamadas"] = contacto.NumLlamadas;

            Lista.WriteXml("Contactos.xml");
        }
    }
}
