using System;
using System.Collections.Generic;
using System.Text;

namespace taller.xamarin.Modelo
{
    public class publicacion
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechaPublicacion { get; set; }
        public Nullable<int> meGusta { get; set; }
        public Nullable<int> meDisgusta { get; set; }
        public Nullable<int> vecesCompartido { get; set; }
        public Nullable<bool> esPrivada { get; set; }
    }
}
