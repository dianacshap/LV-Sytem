namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v02 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Servico", "Carro_Id", "dbo.Carro");
            DropForeignKey("dbo.Servico", "Produto_Id", "dbo.Produto");
            DropIndex("dbo.Servico", new[] { "Carro_Id" });
            DropIndex("dbo.Servico", new[] { "Produto_Id" });
            AddColumn("dbo.Produto", "Servico_Id", c => c.Int());
            CreateIndex("dbo.Produto", "Servico_Id");
            AddForeignKey("dbo.Produto", "Servico_Id", "dbo.Servico", "Id");
            DropColumn("dbo.Servico", "Carro_Id");
            DropColumn("dbo.Servico", "Produto_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servico", "Produto_Id", c => c.Int());
            AddColumn("dbo.Servico", "Carro_Id", c => c.Int());
            DropForeignKey("dbo.Produto", "Servico_Id", "dbo.Servico");
            DropIndex("dbo.Produto", new[] { "Servico_Id" });
            DropColumn("dbo.Produto", "Servico_Id");
            CreateIndex("dbo.Servico", "Produto_Id");
            CreateIndex("dbo.Servico", "Carro_Id");
            AddForeignKey("dbo.Servico", "Produto_Id", "dbo.Produto", "Id");
            AddForeignKey("dbo.Servico", "Carro_Id", "dbo.Carro", "Id");
        }
    }
}
