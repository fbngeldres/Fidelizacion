//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fidelizacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_cuenta()
        {
            this.t_cuenta1 = new HashSet<t_cuenta>();
            this.t_ticket_transferencia = new HashSet<t_ticket_transferencia>();
        }
    
        public int pk_cuenta { get; set; }
        public string numero_cuenta { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<decimal> puntos { get; set; }
        public string estado_cuenta { get; set; }
        public Nullable<int> fk_tipo_cuenta { get; set; }
        public Nullable<int> fk_cuenta { get; set; }
        public Nullable<int> fk_ficha_afiliacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_cuenta> t_cuenta1 { get; set; }
        public virtual t_cuenta t_cuenta2 { get; set; }
        public virtual t_ficha_afiliacion t_ficha_afiliacion { get; set; }
        public virtual t_tipo_cuenta t_tipo_cuenta { get; set; }
        public virtual t_tarjeta_afiliacion t_tarjeta_afiliacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_ticket_transferencia> t_ticket_transferencia { get; set; }

        public Nullable<decimal> getPuntosMaximosTransferir()
        {
            if(this.puntos != null)
                return Math.Round((decimal)this.puntos * (decimal)0.8);
            return null;
        }

    }
}
