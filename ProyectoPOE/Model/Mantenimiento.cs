namespace frmMain.Model
{
    public class Mantenimiento
    {
        string codigo;
        Cliente cliente;
        Mecanico mecanico;
        DateTime fechamant;
        Vehiculo vehiculo;
        string diagnostico;
        string trabajos;
        bool escorrectivo;
        Repuesto[] repuestos;
        Servicio[] servicios;

        public Mantenimiento(string codigo, Cliente cliente, Mecanico mecanico, DateTime fechamant, Vehiculo vehiculo, string diagnostico, string trabajos, bool escorrectivo, Repuesto[] repuestos, Servicio[] servicios)
        {
            this.codigo = codigo;
            this.cliente = cliente;
            this.mecanico = mecanico;
            this.fechamant = fechamant;
            this.vehiculo = vehiculo;
            this.diagnostico = diagnostico;
            this.trabajos = trabajos;
            this.escorrectivo = escorrectivo;
            this.repuestos = repuestos;
            this.servicios = servicios;
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Mecanico Mecanico
        {
            get { return mecanico; }
            set { mecanico = value; }
        }
        public DateTime Fechamant
        {
            get { return fechamant; }
            set { fechamant = value; }
        }
        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public bool Escorrectivo
        {
            get { return escorrectivo; }
            set { escorrectivo = value; }
        }
        public Repuesto[] Repuestos
        {
            get { return repuestos; }
            set { repuestos = value; }
        }
        public Servicio[] Servicios
        {
            get { return servicios; }
            set { servicios = value; }
        }
    }
}
