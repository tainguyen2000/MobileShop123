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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.BinhLuans = new HashSet<BinhLuan>();
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.HopDongNCCs = new HashSet<HopDongNCC>();
            this.SanPhamKhuyenMais = new HashSet<SanPhamKhuyenMai>();
            this.ThongSoKyThuats = new HashSet<ThongSoKyThuat>();
            this.Sanphamcanmuas = new HashSet<Sanphamcanmua>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public Nullable<int> SoLuotXemSP { get; set; }
        public string HangSX { get; set; }
        public string XuatXu { get; set; }
        public Nullable<decimal> GiaTien { get; set; }
        public string MoTa { get; set; }
        public string AnhDaiDien { get; set; }
        public string AnhNen { get; set; }
        public string AnhKhac { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<bool> isnew { get; set; }
        public Nullable<bool> ishot { get; set; }
        public Nullable<decimal> GiaGoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual HangSanXuat HangSanXuat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDongNCC> HopDongNCCs { get; set; }
        public virtual LoaiSP LoaiSP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamKhuyenMai> SanPhamKhuyenMais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongSoKyThuat> ThongSoKyThuats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sanphamcanmua> Sanphamcanmuas { get; set; }
    }
}
