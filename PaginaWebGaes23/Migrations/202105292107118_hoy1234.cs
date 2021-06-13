namespace PaginaWebGaes23.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hoy1234 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DBCiudadesDROPs",
                c => new
                    {
                        IdCiudad = c.String(nullable: false, maxLength: 5),
                        Descripcion = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.IdCiudad);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DBCiudadesDROPs");
        }
    }
}
