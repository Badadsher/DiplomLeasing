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
    
    public partial class Leases
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int StatusID { get; set; }
        public int CarID { get; set; }
    
        public virtual LeaseObjects LeaseObjects { get; set; }
        public virtual LeaseStatus LeaseStatus { get; set; }
        public virtual Users Users { get; set; }
    }
}
