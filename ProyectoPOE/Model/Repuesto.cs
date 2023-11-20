﻿namespace frmMain.Model
{
    internal class Repuesto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Repuesto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public string ObtenerInformacionRepuesto()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}";
        }
    }
}


