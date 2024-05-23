namespace PantallaImportarActualizacion.Entidades
{
    public class TipoUva
    {
        private string nombre;
        private string descripcion;

        public TipoUva(string nombreUva, string descripcionUva)
        {
            nombre = nombreUva;
            descripcion = descripcionUva;
        }

        public string nombreUva
        {
            get => nombre;
            set => nombre = value;
        }

        public string descripcionUva
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
