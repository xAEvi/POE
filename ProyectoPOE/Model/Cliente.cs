namespace frmMain.Model
{
    internal class Cliente : Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(string apellidos, string nombres, string cedula, string direccion, string telefono)
                : base(apellidos, nombres, cedula)
        {
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
