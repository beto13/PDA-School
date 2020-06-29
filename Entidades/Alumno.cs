﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        public int IdAlumno { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Carrera { get; set; }
        public string Domicilio { get; set; }

        public Alumno()
        {
        }
    }
}
