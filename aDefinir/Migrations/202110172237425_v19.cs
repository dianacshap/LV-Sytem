namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v19 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ServicoProduto", "ConsumoTotal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ServicoProduto", "ConsumoTotal", c => c.String());
        }
    }
}
