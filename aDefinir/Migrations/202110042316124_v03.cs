namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v03 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produto", "Servico_Id", "dbo.Servico");
            DropIndex("dbo.Produto", new[] { "Servico_Id" });
            CreateTable(
                "dbo.ProdutoServico",
                c => new
                    {
                        Produto_Id = c.Int(nullable: false),
                        Servico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto_Id, t.Servico_Id })
                .ForeignKey("dbo.Produto", t => t.Produto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Servico", t => t.Servico_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Servico_Id);
            
            DropColumn("dbo.Produto", "Servico_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "Servico_Id", c => c.Int());
            DropForeignKey("dbo.ProdutoServico", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.ProdutoServico", "Produto_Id", "dbo.Produto");
            DropIndex("dbo.ProdutoServico", new[] { "Servico_Id" });
            DropIndex("dbo.ProdutoServico", new[] { "Produto_Id" });
            DropTable("dbo.ProdutoServico");
            CreateIndex("dbo.Produto", "Servico_Id");
            AddForeignKey("dbo.Produto", "Servico_Id", "dbo.Servico", "Id");
        }
    }
}
