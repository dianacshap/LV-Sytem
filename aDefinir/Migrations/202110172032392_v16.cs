namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v16 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProdutoServico", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.ProdutoServico", "Servico_Id", "dbo.Servico");
            DropIndex("dbo.ProdutoServico", new[] { "Produto_Id" });
            DropIndex("dbo.ProdutoServico", new[] { "Servico_Id" });
            AddColumn("dbo.Servico", "Produtos_Id", c => c.Int());
            AddColumn("dbo.Produto", "RendimentoDiluido", c => c.Double(nullable: false));
            CreateIndex("dbo.Servico", "Produtos_Id");
            AddForeignKey("dbo.Servico", "Produtos_Id", "dbo.Produto", "Id");
            DropColumn("dbo.Produto", "Diluicao");
            DropTable("dbo.ProdutoServico");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProdutoServico",
                c => new
                    {
                        Produto_Id = c.Int(nullable: false),
                        Servico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto_Id, t.Servico_Id });
            
            AddColumn("dbo.Produto", "Diluicao", c => c.Double(nullable: false));
            DropForeignKey("dbo.Servico", "Produtos_Id", "dbo.Produto");
            DropIndex("dbo.Servico", new[] { "Produtos_Id" });
            DropColumn("dbo.Produto", "RendimentoDiluido");
            DropColumn("dbo.Servico", "Produtos_Id");
            CreateIndex("dbo.ProdutoServico", "Servico_Id");
            CreateIndex("dbo.ProdutoServico", "Produto_Id");
            AddForeignKey("dbo.ProdutoServico", "Servico_Id", "dbo.Servico", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProdutoServico", "Produto_Id", "dbo.Produto", "Id", cascadeDelete: true);
        }
    }
}
