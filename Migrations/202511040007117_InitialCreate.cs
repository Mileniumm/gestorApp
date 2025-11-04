namespace gestorApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Edad = c.Int(nullable: false),
                        FechaNacimiento = c.String(nullable: false),
                        TipoDocumento = c.String(nullable: false),
                        NumeroDocumento = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        CoberturaMedica = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
