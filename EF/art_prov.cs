//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class art_prov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public art_prov()
        {
            this.ped_art_prov = new HashSet<ped_art_prov>();
        }
    
        public string codigoOriginalArt { get; set; }
        public string codigoArProveedor { get; set; }
        public Nullable<int> stockMinimoArPro { get; set; }
        public Nullable<int> stockActualArPro { get; set; }
        public string obsArPro { get; set; }
        public string descripArPro { get; set; }
        public Nullable<System.DateTime> fechaUltimaActualizacionArPro { get; set; }
        public string razonSocialProv { get; set; }
    
        public virtual articulos articulos { get; set; }
        public virtual proveedores proveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ped_art_prov> ped_art_prov { get; set; }
    }
}
