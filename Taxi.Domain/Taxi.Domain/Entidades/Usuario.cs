﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Domain.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
