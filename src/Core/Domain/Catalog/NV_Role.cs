namespace FSH.BackEnd.Domain.Catalog;

public class NV_Role : AuditableEntity, IAggregateRoot
{
    public string? MaPMIS { get; private set; }
    public string? MaDVQL { get; private set; }
    public string? TenCongTy { get; private set; }
    public string? TruyenTaiDien { get; private set; }
    public string? TenRole { get; private set; }
    public string? SoHieu { get; private set; }
    public string? SoHuu { get; private set; }
    public DateTime? NgayLapDat { get; private set; }
    public DateTime? NgayVanHanh { get; private set; }
    public string? ThuocTram { get; private set; }
    public string? TenTram { get; private set; }
    public string? HangSanXuat { get; private set; }
    public string? SoSerial { get; private set; }
    public string? SoHieuBanVe { get; private set; }
    public string? SoDoDanhSo { get; private set; }
    public string? Mach { get; private set; }
    public string? TBBaoVe { get; private set; }
    public string? TuBV { get; private set; }
    public string? CotTenHienThi { get; private set; }
    public string? DaHienThiTrenSoDo { get; private set; }
    public string? HienThiTen { get; private set; }
    public string? HoatDong { get; private set; }
    public string? TrangThaiHienTai { get; private set; }
    public string? GeoJSON { get; private set; }
    public string? MauDong { get; private set; }
    public string? MauCat { get; private set; }
    public string? DauNoiDau { get; private set; }
    public string? DauNoiCuoi { get; private set; }
    public string? GhiChu { get; private set; }
}