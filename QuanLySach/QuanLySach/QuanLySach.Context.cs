﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLySachEntities : DbContext
    {
        public QuanLySachEntities()
            : base("name=QuanLySachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAnBan> tblAnBans { get; set; }
        public virtual DbSet<tblDauSach> tblDauSaches { get; set; }
        public virtual DbSet<tblDocGia> tblDocGias { get; set; }
        public virtual DbSet<tblPhieuMuon> tblPhieuMuons { get; set; }
        public virtual DbSet<tblTaikhoan> tblTaikhoans { get; set; }
    }
}
