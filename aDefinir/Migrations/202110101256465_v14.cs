namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgendamentosServicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        Agendamentos_Codigo = c.Int(),
                        Servicos_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agendamento", t => t.Agendamentos_Codigo)
                .ForeignKey("dbo.Servico", t => t.Servicos_Id)
                .Index(t => t.Agendamentos_Codigo)
                .Index(t => t.Servicos_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgendamentosServicos", "Servicos_Id", "dbo.Servico");
            DropForeignKey("dbo.AgendamentosServicos", "Agendamentos_Codigo", "dbo.Agendamento");
            DropIndex("dbo.AgendamentosServicos", new[] { "Servicos_Id" });
            DropIndex("dbo.AgendamentosServicos", new[] { "Agendamentos_Codigo" });
            DropTable("dbo.AgendamentosServicos");
        }
    }
}
