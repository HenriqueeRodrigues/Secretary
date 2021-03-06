// <auto-generated />
using System;
using Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20211126160142_ClassePessoaSemAsPK")]
    partial class ClassePessoaSemAsPK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Pessoa.PessoaViewModel", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PessoaId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Anciao")
                        .HasColumnType("bit");

                    b.Property<string>("Congregacao")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Databatismo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("NOME");

                    b.Property<bool>("PioneiroRegular")
                        .HasColumnType("bit");

                    b.Property<bool>("ServoMinisterial")
                        .HasColumnType("bit");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Ungido")
                        .HasColumnType("bit");

                    b.HasKey("PessoaId");

                    b.ToTable("PESSOA");
                });

            modelBuilder.Entity("Model.Produto.ProdutoViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PRD_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PRD_NOME");

                    b.HasKey("Id");

                    b.ToTable("TB_PRODUTO");
                });
#pragma warning restore 612, 618
        }
    }
}
