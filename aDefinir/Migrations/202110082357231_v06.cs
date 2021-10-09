namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v06 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServicoAgendamento", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.ServicoAgendamento", "Agendamento_Codigo", "dbo.Agendamento");
            DropIndex("dbo.ServicoAgendamento", new[] { "Servico_Id" });
            DropIndex("dbo.ServicoAgendamento", new[] { "Agendamento_Codigo" });
            AddColumn("dbo.Servico", "Agendamento_Codigo", c => c.Int());
            CreateIndex("dbo.Servico", "Agendamento_Codigo");
            AddForeignKey("dbo.Servico", "Agendamento_Codigo", "dbo.Agendamento", "Codigo");
            DropTable("dbo.ServicoAgendamento");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServicoAgendamento",
                c => new
                    {
                        Servico_Id = c.Int(nullable: false),
                        Agendamento_Codigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Servico_Id, t.Agendamento_Codigo });
            
            DropForeignKey("dbo.Servico", "Agendamento_Codigo", "dbo.Agendamento");
            DropIndex("dbo.Servico", new[] { "Agendamento_Codigo" });
            DropColumn("dbo.Servico", "Agendamento_Codigo");
            CreateIndex("dbo.ServicoAgendamento", "Agendamento_Codigo");
            CreateIndex("dbo.ServicoAgendamento", "Servico_Id");
            AddForeignKey("dbo.ServicoAgendamento", "Agendamento_Codigo", "dbo.Agendamento", "Codigo", cascadeDelete: true);
            AddForeignKey("dbo.ServicoAgendamento", "Servico_Id", "dbo.Servico", "Id", cascadeDelete: true);
        }
    }
}
