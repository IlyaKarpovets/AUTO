//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proj2Auto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderService
    {
        public int Id { get; set; }
        public Nullable<int> Order { get; set; }
        public Nullable<int> Service { get; set; }
    
        public virtual Order Order1 { get; set; }
        public virtual Service Service1 { get; set; }
    }
}
