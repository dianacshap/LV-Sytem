namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v061 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Agendamento", "Hora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Agendamento", "Hora", c => c.String());
        }
    }
}
