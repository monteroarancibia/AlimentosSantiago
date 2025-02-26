﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class DireccionCliente : LayerSuperType
    {
        public String Direccion { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }


    }
}
