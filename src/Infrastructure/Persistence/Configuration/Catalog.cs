using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.BackEnd.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.BackEnd.Infrastructure.Persistence.Configuration;

public class BrandConfig : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(256);
    }
}

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(1024);

        builder
            .Property(p => p.ImagePath)
                .HasMaxLength(2048);
    }
}

public class NV_RoleConfig : IEntityTypeConfiguration<NV_Role>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(256);
    }

    public void Configure(EntityTypeBuilder<NV_Role> builder)
    {
        builder.IsMultiTenant();

        builder
            .Property(b => b.MaPMIS)
                .HasMaxLength(100);

        builder
            .Property(b => b.MaDVQL)
                .HasMaxLength(50);
        builder
            .Property(b => b.TenCongTy)
                .HasMaxLength(200);
        builder
            .Property(b => b.TruyenTaiDien)
                .HasMaxLength(200);
        builder
            .Property(b => b.TenRole)
                .HasMaxLength(100);
        builder
            .Property(b => b.SoHieu)
                .HasMaxLength(100);
        builder
            .Property(b => b.ThuocTram)
                .HasMaxLength(100);
        builder
            .Property(b => b.TenTram)
                .HasMaxLength(200);
        builder
            .Property(b => b.HangSanXuat)
                .HasMaxLength(200);
        builder
            .Property(b => b.SoSerial)
                .HasMaxLength(100);
        builder
            .Property(b => b.SoHieuBanVe)
                .HasMaxLength(100);
        builder
            .Property(b => b.SoDoDanhSo)
                .HasMaxLength(100);
        builder
            .Property(b => b.Mach)
                .HasMaxLength(100);
        builder
            .Property(b => b.TBBaoVe)
                .HasMaxLength(100);
        builder
            .Property(b => b.TuBV)
                .HasMaxLength(100);
        builder
            .Property(b => b.CotTenHienThi)
                .HasMaxLength(100);
        builder
            .Property(b => b.DaHienThiTrenSoDo)
                .HasMaxLength(1)
                .IsUnicode(false);
        builder
            .Property(b => b.HienThiTen)
                .HasMaxLength(1)
                .IsUnicode(false);
        builder
            .Property(b => b.HoatDong)
                .HasMaxLength(1)
                .IsUnicode(false);
        builder
            .Property(b => b.TrangThaiHienTai)
                .HasMaxLength(10);
        builder
            .Property(b => b.GeoJSON)
                .HasColumnType("CLOB");
        builder
            .Property(b => b.MauDong)
                .HasMaxLength(100)
                .IsUnicode(false);
        builder
            .Property(b => b.MauCat)
                .HasMaxLength(100)
                .IsUnicode(false);
        builder
            .Property(b => b.DauNoiDau)
                .HasMaxLength(100);
        builder
            .Property(b => b.DauNoiCuoi)
                .HasMaxLength(100);
        builder
            .Property(b => b.GhiChu)
                .HasMaxLength(250);
    }
}