using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using P4zad2.Tabele;

namespace P4zad2.Entity
{
    public partial class KomunikacjaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name:"Kierowca",
                columns: table=>new
                {
                    KierowcaId=table.Column<int>(type:"int", nullable: false)
                    .Annotation("SqlServer:Identity","1,1"),
                    Imie=table.Column<string>(type:"nvarchar(20)",nullable:false),
                    Nazwisko=table.Column<string>(type:"nvarchar(50)", nullable:false),
                    Nr_tel=table.Column<int>(type:"decial(9)",nullable:true),
                    Adres=table.Column<string>(type:"nvarchar(80)",nullable:false),
                    Data_ur=table.Column<DateTime>(type:"date",nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kierowca", x => x.KierowcaId);
                });

            migrationBuilder.CreateTable(
                name: "Autobus",
                columns: table => new
                {
                    Nr_rejestracji = table.Column<string>(type: "char(7)", nullable: false)
                    .Annotation("SqlServer:Identity","1,1"),
                    KierowcaId = table.Column<int>(type: "int", nullable: false),
                    Marka = table.Column<string>(type:"nvarchar(20)",nullable:false),
                    Model = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Rocznik =table.Column<DateTime>(type:"date",nullable:false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autobus", x => x.Nr_rejestracji);
                    table.ForeignKey(
                        name:"FK_Kierowca",
                        column:x=>x.KierowcaId,
                        principalTable:"Kierowca",
                        principalColumn:"KierowcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Linia",
                columns: table => new
                {
                    Nr_linii = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity","1,1"),
                    Nr_rejestracji = table.Column<string>(type: "cahr(7)", nullable: false),
                    Kierunek = table.Column<string>(type: "nvarchar(40)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linia", x => x.Nr_linii);
                    table.ForeignKey(
                        name: "FK_Nr_rejestracji",
                        column: x => x.Nr_linii,
                        principalTable:"Autobus",
                        principalColumn:"Nr_rejestracji",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name:"Przystanek",
                columns: table => new
                {
                    Nr_przystanku=table.Column<int>(type:"int",nullable:false)
                        .Annotation("SqlServer:Identity", "1,1"),
                    Nazwa=table.Column<string>(type:"nvarchar(40)",nullable:false),
                    Lokalizacja=table.Column<string>(type:"nvarchar(80)",nullable:false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przystanek", x => x.Nr_przystanku);
                });

            migrationBuilder.CreateTable(
                name:"Pozycja_kursu",
                columns: table => new
                {
                    Id_pozycji=table.Column<int>(type:"int",nullable:false)
                        .Annotation("SqlServer:Identity", "1,1"),
                    Status=table.Column<string>(type:"nvarchar(128)",nullable:true),
                    Godz_odjazdu=table.Column<DateTime>(type:"time",nullable:true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozycjaKursu", x => x.Id_pozycji);
                });

            migrationBuilder.CreateTable(
                name:"Rozklad_jazdy",
                columns: table => new
                {
                    Id_rozkladu=table.Column<int>(type:"int",nullable:false)
                        .Annotation("SqlServer:Identity","1,1"),
                    Id_pozycji=table.Column<int>(type:"int",nullable:false),
                    Dni_robocze=table.Column<int>(type:"int",nullable:true),
                    Soboty = table.Column<int>(type: "int", nullable: true),
                    Niedziele = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rozklad_jazdy", x => x.Id_rozkladu);
                table.ForeignKey(
                    name: "FK_I_pozycji",
                    column: x => x.Id_pozycji,
                    principalTable: "Pozycja_kursu",
                    principalColumn: "Id_pozycji",
                    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rozklad_przystanku",
                columns: table => new
                {
                    Nr_przystanku = table.Column<int>(type: "int", nullable: false),
                    Id_rozkladu = table.Column<int>(type: "int", nullable:false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rozklad_przystanku", x => new {x.Nr_przystanku, x.Id_rozkladu});
                    table.ForeignKey(
                        name: "FK_Przystanek",
                        column: x => x.Nr_przystanku,
                        principalTable: "Przystanek",
                        principalColumn: "Nr_przystanku",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Id_rozkladu",
                        column: x => x.Id_rozkladu,
                        principalTable: "Rozklad_jazdy",
                        principalColumn: "Id_rozkladu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name:"Kolejnosc_trasy",
                columns: table => new
                {
                    Nr_linii=table.Column<int>(type:"int", nullable: false),
                    Nr_przystanku=table.Column<int>(type:"int",nullable:false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolejnosc",x => new {x.Nr_linii,x.Nr_przystanku});
                    table.ForeignKey(
                        name: "FK_Linia",
                        column: x => x.Nr_linii,
                        principalTable: "Linia",
                        principalColumn: "Nr_linii",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Przystanek",
                        column: x => x.Nr_przystanku,
                        principalTable: "Przystanek",
                        principalColumn: "Nr_przystanku",
                        onDelete: ReferentialAction.Cascade);
                });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kierowca");

            migrationBuilder.DropTable(
                name: "Autobus");

            migrationBuilder.DropTable(
                name: "Linia");

            migrationBuilder.DropTable(
                name: "Pozycja_kursu");

            migrationBuilder.DropTable(
                name: "Przystanek");

            migrationBuilder.DropTable(
                name: "Rozklad_jazdy");
        }
    }
}
