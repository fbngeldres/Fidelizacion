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
    
    public partial class t_modalidad_canje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_modalidad_canje()
        {
            this.t_producto_canje = new HashSet<t_producto_canje>();
        }
    
        public int pk_modalidad { get; set; }
        public string nombre_modalidad_canje { get; set; }
        public string tipo_canje { get; set; }
        public Nullable<decimal> punto_canje { get; set; }
        public Nullable<decimal> importe_canje { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public Nullable<System.DateTime> fecha_inicio_vigencia { get; set; }
        public Nullable<System.DateTime> fecha_fin_vigencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_producto_canje> t_producto_canje { get; set; }
    }
}
