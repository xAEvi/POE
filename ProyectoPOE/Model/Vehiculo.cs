﻿namespace frmMain.Model
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string AnoFabricacion { get; set; }
        public string Tipo { get; set; }

        public Vehiculo(string placa, string marca, string anoFabricacion, string tipo)
        {
            Placa = placa;
            Marca = marca;
            AnoFabricacion = anoFabricacion;
            Tipo = tipo;
        }
    }
}
