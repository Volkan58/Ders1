//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUrun()
        {
            this.TblSatis = new HashSet<TblSatis>();
        }
    
        public int Urunİd { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public Nullable<short> UrunStok { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<int> Kategori { get; set; }
    
        public virtual TblKategori TblKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSatis> TblSatis { get; set; }
    }
}
