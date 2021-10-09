namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agendamento", "DataAg", c => c.String());
        }
        
        public override void Down()
        {
            AddColumn("dbo.Agendamento", "Data", c => c.String());
            DropColumn("dbo.Agendamento", "DataAg");
        }
    }
}
