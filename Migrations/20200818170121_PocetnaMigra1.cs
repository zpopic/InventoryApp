using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace InventoryApp.Migrations
{
    public partial class PocetnaMigra1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetusertokens");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_aspnetusers",
            //    table: "aspnetusers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetuserroles");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetuserlogins");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_aspnetuserclaims",
            //    table: "aspnetuserclaims");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_aspnetroles",
            //    table: "aspnetroles");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_aspnetroleclaims",
            //    table: "aspnetroleclaims");

            //migrationBuilder.RenameTable(
            //    name: "aspnetusertokens",
            //    newName: "AspNetUserTokens");

            //migrationBuilder.RenameTable(
            //    name: "aspnetusers",
            //    newName: "AspNetUsers");

            //migrationBuilder.RenameTable(
            //    name: "aspnetuserroles",
            //    newName: "AspNetUserRoles");

            //migrationBuilder.RenameTable(
            //    name: "aspnetuserlogins",
            //    newName: "AspNetUserLogins");

            //migrationBuilder.RenameTable(
            //    name: "aspnetuserclaims",
            //    newName: "AspNetUserClaims");

            //migrationBuilder.RenameTable(
            //    name: "aspnetroles",
            //    newName: "AspNetRoles");

            //migrationBuilder.RenameTable(
            //    name: "aspnetroleclaims",
            //    newName: "AspNetRoleClaims");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    newName: "IX_AspNetUserRoles_RoleId1");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    newName: "IX_AspNetUserLogins_UserId1");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserClaims_UserId1",
            //    table: "AspNetUserClaims",
            //    newName: "IX_AspNetUserClaims_UserId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    newName: "IX_AspNetRoleClaims_RoleId1");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Value",
            //    table: "AspNetUserTokens",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetUserTokens",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserTokens",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "AspNetUserTokens",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserName",
            //    table: "AspNetUsers",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<bool>(
            //    name: "TwoFactorEnabled",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "bit(1)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "SecurityStamp",
            //    table: "AspNetUsers",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<bool>(
            //    name: "PhoneNumberConfirmed",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "bit(1)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PhoneNumber",
            //    table: "AspNetUsers",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "PasswordHash",
            //    table: "AspNetUsers",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedUserName",
            //    table: "AspNetUsers",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedEmail",
            //    table: "AspNetUsers",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<DateTimeOffset>(
            //    name: "LockoutEnd",
            //    table: "AspNetUsers",
            //    nullable: true,
            //    oldClrType: typeof(DateTimeOffset),
            //    oldType: "timestamp",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<bool>(
            //    name: "LockoutEnabled",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "bit(1)");

            //migrationBuilder.AlterColumn<bool>(
            //    name: "EmailConfirmed",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(short),
            //    oldType: "bit(1)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Email",
            //    table: "AspNetUsers",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ConcurrencyStamp",
            //    table: "AspNetUsers",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<int>(
            //    name: "AccessFailedCount",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int(11)");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "AspNetUsers",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "RoleId",
            //    table: "AspNetUserRoles",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "AspNetUserRoles",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "AspNetUserLogins",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderDisplayName",
            //    table: "AspNetUserLogins",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "AspNetUserLogins",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "AspNetUserLogins",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "AspNetUserClaims",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimValue",
            //    table: "AspNetUserClaims",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimType",
            //    table: "AspNetUserClaims",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "AspNetUserClaims",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int(11)")
            //    .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedName",
            //    table: "AspNetRoles",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "AspNetRoles",
            //    maxLength: 256,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(256)",
            //    oldUnicode: false,
            //    oldMaxLength: 256,
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ConcurrencyStamp",
            //    table: "AspNetRoles",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "AspNetRoles",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "RoleId",
            //    table: "AspNetRoleClaims",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(128)",
            //    oldUnicode: false,
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimValue",
            //    table: "AspNetRoleClaims",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimType",
            //    table: "AspNetRoleClaims",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "text",
            //    oldNullable: true,
            //    oldDefaultValueSql: "'NULL'");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "AspNetRoleClaims",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int(11)")
            //    .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddColumn<string>(
            //    name: "ident",
            //    table: "artikl",
            //    unicode: false,
            //    maxLength: 45,
            //    nullable: true,
            //    defaultValueSql: "'NULL'");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetUserTokens",
            //    table: "AspNetUserTokens",
            //    columns: new[] { "UserId", "LoginProvider", "Name" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetUsers",
            //    table: "AspNetUsers",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetUserRoles",
            //    table: "AspNetUserRoles",
            //    columns: new[] { "UserId", "RoleId" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetUserLogins",
            //    table: "AspNetUserLogins",
            //    columns: new[] { "LoginProvider", "ProviderKey" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetUserClaims",
            //    table: "AspNetUserClaims",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetRoles",
            //    table: "AspNetRoles",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_AspNetRoleClaims",
            //    table: "AspNetRoleClaims",
            //    column: "Id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
            //    name: "aspnetroles");

            //migrationBuilder.DropTable(
            //    name: "aspnetusers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUserTokens",
            //    table: "AspNetUserTokens");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUsers",
            //    table: "AspNetUsers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUserRoles",
            //    table: "AspNetUserRoles");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUserLogins",
            //    table: "AspNetUserLogins");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetUserClaims",
            //    table: "AspNetUserClaims");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetRoles",
            //    table: "AspNetRoles");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_AspNetRoleClaims",
            //    table: "AspNetRoleClaims");

            //migrationBuilder.DropColumn(
            //    name: "ident",
            //    table: "artikl");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUserTokens",
            //    newName: "aspnetusertokens");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUsers",
            //    newName: "aspnetusers");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUserRoles",
            //    newName: "aspnetuserroles");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUserLogins",
            //    newName: "aspnetuserlogins");

            //migrationBuilder.RenameTable(
            //    name: "AspNetUserClaims",
            //    newName: "aspnetuserclaims");

            //migrationBuilder.RenameTable(
            //    name: "AspNetRoles",
            //    newName: "aspnetroles");

            //migrationBuilder.RenameTable(
            //    name: "AspNetRoleClaims",
            //    newName: "aspnetroleclaims");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserRoles_RoleId1",
            //    table: "aspnetuserroles",
            //    newName: "IX_AspNetUserRoles_RoleId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserLogins_UserId1",
            //    table: "aspnetuserlogins",
            //    newName: "IX_AspNetUserLogins_UserId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "aspnetuserclaims",
            //    newName: "IX_AspNetUserClaims_UserId1");

            //migrationBuilder.RenameIndex(
            //    name: "IX_AspNetRoleClaims_RoleId1",
            //    table: "aspnetroleclaims",
            //    newName: "IX_AspNetRoleClaims_RoleId");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Value",
            //    table: "aspnetusertokens",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "aspnetusertokens",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "aspnetusertokens",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "aspnetusertokens",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserName",
            //    table: "aspnetusers",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<short>(
            //    name: "TwoFactorEnabled",
            //    table: "aspnetusers",
            //    type: "bit(1)",
            //    nullable: false,
            //    oldClrType: typeof(bool));

            //migrationBuilder.AlterColumn<string>(
            //    name: "SecurityStamp",
            //    table: "aspnetusers",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<short>(
            //    name: "PhoneNumberConfirmed",
            //    table: "aspnetusers",
            //    type: "bit(1)",
            //    nullable: false,
            //    oldClrType: typeof(bool));

            //migrationBuilder.AlterColumn<string>(
            //    name: "PhoneNumber",
            //    table: "aspnetusers",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "PasswordHash",
            //    table: "aspnetusers",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedUserName",
            //    table: "aspnetusers",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedEmail",
            //    table: "aspnetusers",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<DateTimeOffset>(
            //    name: "LockoutEnd",
            //    table: "aspnetusers",
            //    type: "timestamp",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(DateTimeOffset),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<short>(
            //    name: "LockoutEnabled",
            //    table: "aspnetusers",
            //    type: "bit(1)",
            //    nullable: false,
            //    oldClrType: typeof(bool));

            //migrationBuilder.AlterColumn<short>(
            //    name: "EmailConfirmed",
            //    table: "aspnetusers",
            //    type: "bit(1)",
            //    nullable: false,
            //    oldClrType: typeof(bool));

            //migrationBuilder.AlterColumn<string>(
            //    name: "Email",
            //    table: "aspnetusers",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ConcurrencyStamp",
            //    table: "aspnetusers",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "AccessFailedCount",
            //    table: "aspnetusers",
            //    type: "int(11)",
            //    nullable: false,
            //    oldClrType: typeof(int));

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "aspnetusers",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "RoleId",
            //    table: "aspnetuserroles",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "aspnetuserroles",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "aspnetuserlogins",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderDisplayName",
            //    table: "aspnetuserlogins",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ProviderKey",
            //    table: "aspnetuserlogins",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "LoginProvider",
            //    table: "aspnetuserlogins",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId",
            //    table: "aspnetuserclaims",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimValue",
            //    table: "aspnetuserclaims",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimType",
            //    table: "aspnetuserclaims",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "aspnetuserclaims",
            //    type: "int(11)",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AlterColumn<string>(
            //    name: "NormalizedName",
            //    table: "aspnetroles",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Name",
            //    table: "aspnetroles",
            //    type: "varchar(256)",
            //    unicode: false,
            //    maxLength: 256,
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldMaxLength: 256,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ConcurrencyStamp",
            //    table: "aspnetroles",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "aspnetroles",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "RoleId",
            //    table: "aspnetroleclaims",
            //    type: "varchar(128)",
            //    unicode: false,
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string));

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimValue",
            //    table: "aspnetroleclaims",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ClaimType",
            //    table: "aspnetroleclaims",
            //    type: "text",
            //    nullable: true,
            //    defaultValueSql: "'NULL'",
            //    oldClrType: typeof(string),
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "aspnetroleclaims",
            //    type: "int(11)",
            //    nullable: false,
            //    oldClrType: typeof(int))
            //    .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
            //    .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetusertokens",
            //    columns: new[] { "UserId", "LoginProvider", "Name" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_aspnetusers",
            //    table: "aspnetusers",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetuserroles",
            //    columns: new[] { "UserId", "RoleId" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PRIMARY",
            //    table: "aspnetuserlogins",
            //    columns: new[] { "LoginProvider", "ProviderKey" });

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_aspnetuserclaims",
            //    table: "aspnetuserclaims",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_aspnetroles",
            //    table: "aspnetroles",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_aspnetroleclaims",
            //    table: "aspnetroleclaims",
            //    column: "Id");
        }
    }
}
