//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConfigAPI
    {
        public int ID { get; set; }
        public string MaNCC { get; set; }
        public string LinkRequesrToken { get; set; }
        public string LinkAccessToken { get; set; }
        public string LinkKiemTraLuongTon { get; set; }
        public string LinkXacNhanGiaoHang { get; set; }
    
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
