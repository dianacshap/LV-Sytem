namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v07 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Servico", "Agendamento_Codigo", "dbo.Agendamento");
            DropIndex("dbo.Servico", new[] { "Agendamento_Codigo" });
            CreateTable(
                "dbo.ServicoAgendamento",
                c => new
                    {
                        Servico_Id = c.Int(nullable: false),
                        Agendamento_Codigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Servico_Id, t.Agendamento_Codigo })
                .ForeignKey("dbo.Servico", t => t.Servico_Id, cascadeDelete: true)
                .ForeignKey("dbo.Agendamento", t => t.Agendamento_Codigo, cascadeDelete: true)
                .Index(t => t.Servico_Id)
                .Index(t => t.Agendamento_Codigo);
            
            DropColumn("dbo.Servico", "Agendamento_Codigo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servico", "Agendamento_Codigo", c => c.Int());
            DropForeignKey("dbo.ServicoAgendamento", "Agendamento_Codigo", "dbo.Agendamento");
            DropForeignKey("dbo.ServicoAgendamento", "Servico_Id", "dbo.Servico");
            DropIndex("dbo.ServicoAgendamento", new[] { "Agendamento_Codigo" });
            DropIndex("dbo.ServicoAgendamento", new[] { "Servico_Id" });
            DropTable("dbo.ServicoAgendamento");
            CreateIndex("dbo.Servico", "Agendamento_Codigo");
            AddForeignKey("dbo.Servico", "Agendamento_Codigo", "dbo.Agendamento", "Codigo");
        }
    }
}
