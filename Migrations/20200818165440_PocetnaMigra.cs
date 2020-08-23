using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace InventoryApp.Migrations
{
    public partial class PocetnaMigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "__efmigrationshistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
            //        ProductVersion = table.Column<string>(unicode: false, maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.MigrationId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "artikl_audit",
            //    columns: table => new
            //    {
            //        pocetno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        aktualno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        zavrsno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetroles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        NormalizedName = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        ConcurrencyStamp = table.Column<string>(nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetroles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetusers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        UserName = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        NormalizedUserName = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        Email = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        NormalizedEmail = table.Column<string>(unicode: false, maxLength: 256, nullable: true, defaultValueSql: "'NULL'"),
            //        EmailConfirmed = table.Column<short>(type: "bit(1)", nullable: false),
            //        PasswordHash = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        SecurityStamp = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        ConcurrencyStamp = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        PhoneNumber = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        PhoneNumberConfirmed = table.Column<short>(type: "bit(1)", nullable: false),
            //        TwoFactorEnabled = table.Column<short>(type: "bit(1)", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        LockoutEnabled = table.Column<short>(type: "bit(1)", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int(11)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetusers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "izvedba_audit",
            //    columns: table => new
            //    {
            //        naziv = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "'NULL'"),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "kategorija",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        naziv = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_kategorija", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "kategorija_audit",
            //    columns: table => new
            //    {
            //        naziv = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "'NULL'"),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "skladiste",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Naziv = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_skladiste", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "skladiste_audit",
            //    columns: table => new
            //    {
            //        naziv = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "'NULL'"),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tip_audit",
            //    columns: table => new
            //    {
            //        naziv = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "'NULL'"),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "vrsta_audit",
            //    columns: table => new
            //    {
            //        naziv = table.Column<string>(unicode: false, maxLength: 40, nullable: true, defaultValueSql: "'NULL'"),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        edit_time = table.Column<DateTimeOffset>(nullable: true, defaultValueSql: "'NULL'"),
            //        change_type = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetroleclaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        RoleId = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        ClaimType = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        ClaimValue = table.Column<string>(nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetroleclaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "aspnetroles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserclaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        ClaimType = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        ClaimValue = table.Column<string>(nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetuserclaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserlogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(nullable: true, defaultValueSql: "'NULL'"),
            //        UserId = table.Column<string>(unicode: false, maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserroles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        RoleId = table.Column<string>(unicode: false, maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "aspnetroles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetusertokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        LoginProvider = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Value = table.Column<string>(nullable: true, defaultValueSql: "'NULL'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "vrsta",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        naziv = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        kategorija_Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_vrsta", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_vrsta_kategorija1",
            //            column: x => x.kategorija_Id,
            //            principalTable: "kategorija",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tip",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        naziv = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        vrsta_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        kategorija_Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tip", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_tip2",
            //            column: x => x.kategorija_Id,
            //            principalTable: "kategorija",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_tip1",
            //            column: x => x.vrsta_Id,
            //            principalTable: "vrsta",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "izvedba",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        naziv = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        opis = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        tip_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        vrsta_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        kategorija_Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_izvedba", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_izvedba3",
            //            column: x => x.kategorija_Id,
            //            principalTable: "kategorija",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_izvedba1",
            //            column: x => x.tip_Id,
            //            principalTable: "tip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_izvedba2",
            //            column: x => x.vrsta_Id,
            //            principalTable: "vrsta",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "artikl",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        pocetno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        aktualno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        zavrsno_stanje = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'NULL'"),
            //        usr_changed = table.Column<string>(unicode: false, maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
            //        izvedba_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        tip_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        vrsta_Id = table.Column<int>(type: "int(10) unsigned", nullable: false),
            //        kategorija_Id = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_artikl", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_artikl1",
            //            column: x => x.izvedba_Id,
            //            principalTable: "izvedba",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_artikl4",
            //            column: x => x.kategorija_Id,
            //            principalTable: "kategorija",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_artikl2",
            //            column: x => x.tip_Id,
            //            principalTable: "tip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "fk_artikl3",
            //            column: x => x.vrsta_Id,
            //            principalTable: "vrsta",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    },
            //    comment: "					");

            //migrationBuilder.CreateIndex(
            //    name: "fk_artikl1_idx",
            //    table: "artikl",
            //    column: "izvedba_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_artikl4_idx",
            //    table: "artikl",
            //    column: "kategorija_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_artikl2_idx",
            //    table: "artikl",
            //    column: "tip_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_artikl3_idx",
            //    table: "artikl",
            //    column: "vrsta_Id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "aspnetroleclaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "aspnetroles",
            //    column: "NormalizedName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId1",
            //    table: "aspnetuserclaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "aspnetuserlogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "aspnetuserroles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "aspnetusers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "aspnetusers",
            //    column: "NormalizedUserName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "fk_izvedba3_idx",
            //    table: "izvedba",
            //    column: "kategorija_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_izvedba1_idx",
            //    table: "izvedba",
            //    column: "tip_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_izvedba2_idx",
            //    table: "izvedba",
            //    column: "vrsta_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_tip2_idx",
            //    table: "tip",
            //    column: "kategorija_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_tip1_idx",
            //    table: "tip",
            //    column: "vrsta_Id");

            //migrationBuilder.CreateIndex(
            //    name: "fk_vrsta_kategorija1_idx",
            //    table: "vrsta",
            //    column: "kategorija_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "__efmigrationshistory");

            //migrationBuilder.DropTable(
            //    name: "artikl");

            //migrationBuilder.DropTable(
            //    name: "artikl_audit");

            //migrationBuilder.DropTable(
            //    name: "aspnetroleclaims");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserclaims");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserlogins");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserroles");

            //migrationBuilder.DropTable(
            //    name: "aspnetusertokens");

            //migrationBuilder.DropTable(
            //    name: "izvedba_audit");

            //migrationBuilder.DropTable(
            //    name: "kategorija_audit");

            //migrationBuilder.DropTable(
            //    name: "skladiste");

            //migrationBuilder.DropTable(
            //    name: "skladiste_audit");

            //migrationBuilder.DropTable(
            //    name: "tip_audit");

            //migrationBuilder.DropTable(
            //    name: "vrsta_audit");

            //migrationBuilder.DropTable(
            //    name: "izvedba");

            //migrationBuilder.DropTable(
            //    name: "aspnetroles");

            //migrationBuilder.DropTable(
            //    name: "aspnetusers");

            //migrationBuilder.DropTable(
            //    name: "tip");

            //migrationBuilder.DropTable(
            //    name: "vrsta");

            //migrationBuilder.DropTable(
            //    name: "kategorija");
        }
    }
}
