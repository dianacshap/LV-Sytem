namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamento",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Situacao = c.String(),
                        Carro_Id = c.Int(),
                        Cliente_Id = c.Int(),
                        Servico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Carro", t => t.Carro_Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .ForeignKey("dbo.Servico", t => t.Servico_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Servico_Id);
            
            CreateTable(
                "dbo.Carro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Placa = c.String(),
                        Cor = c.String(),
                        Observacoes = c.String(),
                        Ano = c.String(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Endereco = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Double(nullable: false),
                        TempoServico = c.Double(nullable: false),
                        Carro_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carro", t => t.Carro_Id)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Funcao = c.String(),
                        Custo = c.Double(nullable: false),
                        Volume = c.Double(nullable: false),
                        Diluicao = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agendamento", "Servico_Id", "dbo.Servico");
            DropForeignKey("dbo.Servico", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.Servico", "Carro_Id", "dbo.Carro");
            DropForeignKey("dbo.Agendamento", "Cliente_Id", "dbo.Cliente");
            DropForeignKey("dbo.Agendamento", "Carro_Id", "dbo.Carro");
            DropForeignKey("dbo.Carro", "Cliente_Id", "dbo.Cliente");
            DropIndex("dbo.Servico", new[] { "Produto_Id" });
            DropIndex("dbo.Servico", new[] { "Carro_Id" });
            DropIndex("dbo.Carro", new[] { "Cliente_Id" });
            DropIndex("dbo.Agendamento", new[] { "Servico_Id" });
            DropIndex("dbo.Agendamento", new[] { "Cliente_Id" });
            DropIndex("dbo.Agendamento", new[] { "Carro_Id" });
            DropTable("dbo.Produto");
            DropTable("dbo.Servico");
            DropTable("dbo.Cliente");
            DropTable("dbo.Carro");
            DropTable("dbo.Agendamento");
        }
    }
}
