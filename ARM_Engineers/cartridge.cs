//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARM_Engineers
{
    using System;
    using System.Collections.Generic;
    
    public partial class cartridge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cartridge()
        {
            this.printer = new HashSet<printer>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Inventory_Number { get; set; }
        public string Name_Cartinge { get; set; }
        public Nullable<int> ID_Room { get; set; }
        public string Description { get; set; }
    
        public virtual room room { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<printer> printer { get; set; }
    }
}
