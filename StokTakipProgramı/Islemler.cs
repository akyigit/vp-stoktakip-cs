//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipProgramı
{
    using System;
    using System.Collections.Generic;
    
    public partial class Islemler
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> Islem { get; set; }
        public Nullable<int> HesapId { get; set; }
        public Nullable<int> UrunId { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<decimal> Kdv { get; set; }
        public Nullable<decimal> VergisizFiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.DateTime> LastModify { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
