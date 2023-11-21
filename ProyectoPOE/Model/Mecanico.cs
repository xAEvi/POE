namespace frmMain.Model
{
    public class Mecanico : Persona
    {
        public string Especialidad { get; set; }
        public string Jornada { get; set; }

        public Mecanico(string apellidos, string nombres, string cedula, string especialidad, string jornada)
                 : base(apellidos, nombres, cedula)
        {
            Especialidad = especialidad;
            Jornada = jornada;
        }
    }
}
