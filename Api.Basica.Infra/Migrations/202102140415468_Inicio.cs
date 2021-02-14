namespace Api.Basica.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PerfilDeUsuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 300, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        UltimoNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        PerfilDeUsuarioId = c.Guid(nullable: false),
                        DataCadastro = c.DateTime(nullable: false, precision: 0),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PerfilDeUsuario", t => t.PerfilDeUsuarioId)
                .Index(t => t.Email, unique: true, name: "UK1_USUARIO")
                .Index(t => t.PerfilDeUsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "PerfilDeUsuarioId", "dbo.PerfilDeUsuario");
            DropIndex("dbo.Usuario", new[] { "PerfilDeUsuarioId" });
            DropIndex("dbo.Usuario", "UK1_USUARIO");
            DropTable("dbo.Usuario");
            DropTable("dbo.PerfilDeUsuario");
        }
    }
}
