using FrontToBack.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using System;

namespace FrontToBack.Migrations
{
    public partial class deletePropIsAddedtoProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
         name: "IsDeleted",
         table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                nullable: false,
                defaultValue: false);
         }
            

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "IsDeleted",
            table: "Products");
        }
    }
   

    
}
