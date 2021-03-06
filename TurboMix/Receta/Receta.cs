﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class Receta
    {
        public String nombre { get; set; }
        public Alimento alimentoPrincipal { get; set; }
        public Alimento alimentoSecundario { get; set; }
        public CategoriaReceta categoriaReceta { get; set; }

        public Receta() { }
        public Receta(Alimento alimentoPrincipal, Alimento alimentoSecundario, String nombre, CategoriaReceta categoriaReceta)
        {
            this.alimentoPrincipal = alimentoPrincipal;
            this.alimentoSecundario = alimentoSecundario;
            this.nombre = nombre;
            this.categoriaReceta = categoriaReceta;
        }


    }
}
