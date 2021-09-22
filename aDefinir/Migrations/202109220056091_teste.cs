﻿namespace aDefinir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentoes",
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
                .ForeignKey("dbo.Carroes", t => t.Carro_Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.Servicoes", t => t.Servico_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Servico_Id);
            
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Placa = c.String(),
                        Cor = c.String(),
                        Observacoes = c.String(),
                        Ano = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Clientes",
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
                "dbo.Servicoes",
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
                .ForeignKey("dbo.Carroes", t => t.Carro_Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Carro_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Produtoes",
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
            DropForeignKey("dbo.Agendamentoes", "Servico_Id", "dbo.Servicoes");
            DropForeignKey("dbo.Servicoes", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.Servicoes", "Carro_Id", "dbo.Carroes");
            DropForeignKey("dbo.Agendamentoes", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Agendamentoes", "Carro_Id", "dbo.Carroes");
            DropForeignKey("dbo.Carroes", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Servicoes", new[] { "Produto_Id" });
            DropIndex("dbo.Servicoes", new[] { "Carro_Id" });
            DropIndex("dbo.Carroes", new[] { "Cliente_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Servico_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Cliente_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Carro_Id" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Servicoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Carroes");
            DropTable("dbo.Agendamentoes");
        }
    }
}
