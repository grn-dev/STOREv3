using Microsoft.EntityFrameworkCore.Migrations;

namespace INFRASTRUCTURES.DAL.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE  PROCEDURE [dbo].[SP_GetProductByTag_v2]
    @ProductName nvarchar(100),
	@pageSize int,
	@pageNumber int
AS
BEGIN
     
select top 10 p.ProductID,p.Name,p.mainImages,p.CategoryId from Products p
inner join ProductInfo INFO on p.ProductID = INFO.productID
where INFO.[key]='TAG'
and INFO.Value like '%' + @ProductName + '%'
group by  p.ProductID,p.Name,p.mainImages,p.CategoryId
-- the paging comes here
--OFFSET  10 ROWS       -- skip 10 rows
--FETCH NEXT 10 ROWS ONLY; -- take 10 rows
END


";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
