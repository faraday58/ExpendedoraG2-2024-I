﻿using System;


namespace ExpendedoraG2_2024_I
{
    internal class Snack : Expendedora
    {
        public Snack()
        {
            Saludar();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }
    }
}
