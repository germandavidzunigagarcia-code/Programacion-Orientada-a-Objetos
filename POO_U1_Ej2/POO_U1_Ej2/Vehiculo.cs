using System;
using System.Collections.Generic;
using System.Text;
using POO_U1_Ej2.Enum;

namespace POO_U1_Ej2
{
    public class Vehiculo
    {
        private string _placa;
        private int _anio;
        public Estado Estado { get; private set; }

        public string Placa
        {
            get => _placa;
            set
            {
                if (value.Trim().Length == 0)
                    throw new ArgumentException("La placa no puede estar vacia.");
                else
                    _placa = value;
            }
        }
        public int Anio
        {
            get => _anio;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El anio no puede ser mejor que 0.");
                else
                    _anio = value;
            }
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public TipoVehiculo Tipo { get; set; }

        //Constructor con parametros
        public Vehiculo(string marca, string modelo, string color, string placa, int anio, Estado estado)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Placa = placa;
            this.Anio = anio;
            this.Estado = Estado.Detenido;
        }
        //Constructor sin parametros
        public Vehiculo()
        {
            this.Marca = "Indefinido";
            this.Modelo = "Indefinido";
            this.Color = "Indefinido";
            this.Placa = "No tiene";
            this.Anio = 0;
            this.Estado = Estado.Detenido;
        }

        public void Acelerar()
        {
           this.Estado = Estado.Marcha;
        }
        public void Frenar()
        {
        this.Estado = Estado.Detenido;
        }
    

    }
}
