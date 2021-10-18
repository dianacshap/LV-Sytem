namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServicoProduto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Consumo = c.String(),
                        ConsumoTotal = c.String(),
                        Produto_Id = c.Int(),
                        Servico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .ForeignKey("dbo.Servico", t => t.Servico_Id)
                .Index(t => t.Produto_Id)
                .Index(t => t.Servico_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicoProduto", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.ServicoProduto", "Produto_Id", "dbo.Produto");
            DropIndex("dbo.ServicoProduto", new[] { "Servico_Id" });
            DropIndex("dbo.ServicoProduto", new[] { "Produto_Id" });
            DropTable("dbo.ServicoProduto");
        }
    }
}
