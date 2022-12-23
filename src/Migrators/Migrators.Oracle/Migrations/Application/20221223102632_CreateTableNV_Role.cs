using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.Oracle.Migrations.Application
{
    public partial class CreateTableNV_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "IDENTITY",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "Group",
                schema: "IDENTITY",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "IDENTITY",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "IDENTITY",
                table: "RoleClaims");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                schema: "CATALOG",
                table: "Products",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.CreateTable(
                name: "NV_Roles",
                schema: "CATALOG",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    MaPMIS = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    MaDVQL = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    TenCongTy = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    TruyenTaiDien = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    TenRole = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    SoHieu = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    SoHuu = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NgayLapDat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    NgayVanHanh = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    ThuocTram = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    TenTram = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    HangSanXuat = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    SoSerial = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    SoHieuBanVe = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    SoDoDanhSo = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    Mach = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    TBBaoVe = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    TuBV = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    CotTenHienThi = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    DaHienThiTrenSoDo = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    HienThiTen = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    HoatDong = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TrangThaiHienTai = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    GeoJSON = table.Column<string>(type: "CLOB", nullable: true),
                    MauDong = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    MauCat = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DauNoiDau = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    DauNoiCuoi = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "NVARCHAR2(250)", maxLength: 250, nullable: true),
                    TenantId = table.Column<string>(type: "NVARCHAR2(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "RAW(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NV_Roles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NV_Roles",
                schema: "CATALOG");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "IDENTITY",
                table: "RoleClaims",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                schema: "IDENTITY",
                table: "RoleClaims",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                schema: "IDENTITY",
                table: "RoleClaims",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "IDENTITY",
                table: "RoleClaims",
                type: "TIMESTAMP(7)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                schema: "CATALOG",
                table: "Products",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");
        }
    }
}
