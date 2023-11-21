namespace frmMain.Model
{
    public abstract class Persona
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }

        public Persona(string apellidos, string nombres, string cedula)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            Cedula = cedula;
        }
    }
}
