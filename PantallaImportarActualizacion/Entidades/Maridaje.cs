namespace PantallaImportarActualizacion.Entidades
{
    public class Maridaje
    {
        private string nombre;
        private string descripcion;
        

        public Maridaje( string nombreMaridaje, string descripcionMaridaje)
        {
            descripcion = descripcionMaridaje;
            nombre = nombreMaridaje;
        }

        public string descripcionMaridaje
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string nombreMaridaje
        {
            get => nombre;
            set => nombre = value;
        }

        public bool sosMaridaje( string nombre, string nombreM)
        {
            if ( nombre == nombreM)
            {return true; }
            return false;
        }
    }
}
