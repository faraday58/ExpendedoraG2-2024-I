﻿using System;
using System.Threading;

namespace ExpendedoraG2_2024_I
{
    internal  abstract class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos;
        internal byte temperatura;
        private float precio;


        #endregion

        #region Propiedades
        public virtual byte Temperatura { 
            get => temperatura;
            set
            {
                if (0 < value && value < 25)
                    temperatura = value;
                else
                    temperatura = 20;
            }
        }

        public string Marca { get => marca; set => marca = value; }
        public float Precio
        {
            get => precio;
            set
            {
                if ( value < 0)
                {
                    precio = 10;
                }
                else
                {
                    precio = value;
                }
            }
        }
        #endregion



        #region Métodos

        public void Saludar()
        {
            Console.WriteLine(" Bienvenido, elige un producto");
        }

        public void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        public virtual string MostrarProducto()
        {
            string codigo="";
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto ");
            codigo = Console.ReadLine();
            return codigo;

        }

        public virtual void MostrarPrecio(string codigo)
        {
            switch(codigo )
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", Precio - 6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto válido");
                    break;

            }
        }

        #endregion

        #region Constructor

        public Expendedora()
        {
            Marca = "AMS";
            Precio = 18;
            Saludar();
            LimpiarDisplay();
          
        }

        public Expendedora(bool Mantenimiento)
        {
            Temperatura = 1;
            if (  Mantenimiento == true)
             Console.WriteLine("Entrando en modo mantenimiento");
            Console.WriteLine("Cambiando temperatura");
            LimpiarDisplay();
            for (int i =0; i < 20; i++)
            {
                Temperatura++;
            }
            Console.WriteLine("Mostrando Temperatura {0} [°C]",Temperatura );
        }
        #endregion




    }
}
