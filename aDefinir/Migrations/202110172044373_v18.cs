namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v18 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produto", "Custo", c => c.String());
            AlterColumn("dbo.Produto", "Volume", c => c.String());
            AlterColumn("dbo.Produto", "RendimentoDiluido", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "RendimentoDiluido", c => c.Double(nullable: false));
            AlterColumn("dbo.Produto", "Volume", c => c.Double(nullable: false));
            AlterColumn("dbo.Produto", "Custo", c => c.Double(nullable: false));
        }
    }
}
