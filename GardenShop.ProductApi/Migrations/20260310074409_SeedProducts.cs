using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GardenShop.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Price, Descripton, Stock, ImageUrl, CategoryId)" +
                                "Values('Orange Skunk', 60.50, 'A Orange Skunk é um híbrido claro entre a Californian Orange e Skunk. Com um aroma doce e ácido.', 10, 'orange skunk', 1)");

            migrationBuilder.Sql("Insert into Products(Name, Price, Descripton, Stock, ImageUrl, CategoryId)" +
                                "Values('Purple Afghani', 100.0, 'Purple Afghani é uma planta resistente e fácil de cultivar. Esta variedade apresenta folhas verde-escuras e cálices que adquirem tonalidade roxa durante a floração." +
                                "', 10, 'Purple Afghani', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
