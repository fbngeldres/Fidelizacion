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
    
    public partial class t_tienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_tienda()
        {
            this.t_campana = new HashSet<t_campana>();
            this.t_reporte_stock_producto_canje = new HashSet<t_reporte_stock_producto_canje>();
            this.t_solicitud_atencion = new HashSet<t_solicitud_atencion>();
        }
    
        public int pk_tienda { get; set; }
        public string nombre_tienda { get; set; }
        public string nombre_direccion { get; set; }
        public Nullable<System.DateTime> fecha_apertura { get; set; }
        public string distrito { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string tipo_tienda { get; set; }
        public string pais { get; set; }
        public string horario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_campana> t_campana { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_reporte_stock_producto_canje> t_reporte_stock_producto_canje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_solicitud_atencion> t_solicitud_atencion { get; set; }
    }
}
