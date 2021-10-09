﻿namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v09 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Agendamento", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Agendamento", "Data", c => c.String());
        }
    }
}
