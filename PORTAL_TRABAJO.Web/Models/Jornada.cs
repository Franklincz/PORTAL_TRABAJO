using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PORTAL_TRABAJO.Web.Models
{
    public partial class Jornada
    {
        public Jornada()
        {
            Ofertalaboral = new HashSet<Ofertalaboral>();
        }
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ofertalaboral> Ofertalaboral { get; set; }
    }
}
