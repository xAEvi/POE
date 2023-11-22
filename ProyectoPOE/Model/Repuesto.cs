namespace frmMain.Model
{
    public class Repuesto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Repuesto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Nombre} - ${Precio}";
        }
    }
}


