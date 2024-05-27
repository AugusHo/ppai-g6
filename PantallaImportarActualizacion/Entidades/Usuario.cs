namespace PantallaImportarActualizacion.Entidades
{
    public class Usuario
    {
        private string nombre;
        private int contraseña;
        private bool premium;

        public Usuario(string nombreU, int contraseñaU, bool premiumU)
        {
            nombre = nombreU;
            contraseña = contraseñaU;
            premium = premiumU;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Contraseña
        {
            get => contraseña;
            set => contraseña = value;
        }

        public bool Premium
        {
            get => premium;
            set => premium = value;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
