//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Leasing.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaseObjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaseObjects()
        {
            this.Leases1 = new HashSet<Leases>();
        }
    
        public int ID { get; set; }
        public Nullable<int> LeaseID { get; set; }
        public string Name { get; set; }
        public int MonthCount { get; set; }
        public int CarPrice { get; set; }
        public Nullable<int> Avance { get; set; }
        public Nullable<int> MothlyPrice { get; set; }
        public Nullable<int> AllAmount { get; set; }
        public byte[] Images { get; set; }
    
        public virtual Leases Leases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leases> Leases1 { get; set; }
    }
}
