﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PORTAL_TRABAJO.Web.Models
{
    public partial class Tipoestudio
    {
        public Tipoestudio()
        {
            Formaccand = new HashSet<Formaccand>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Formaccand> Formaccand { get; set; }
    }
}
