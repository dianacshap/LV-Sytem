namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v05 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Agendamento", "Data", c => c.String());
            AlterColumn("dbo.Agendamento", "Hora", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Agendamento", "Hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Agendamento", "Data", c => c.DateTime(nullable: false));
        }
    }
}
