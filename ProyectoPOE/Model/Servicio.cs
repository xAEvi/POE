﻿namespace frmMain.Model
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Servicio(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }

    
}
