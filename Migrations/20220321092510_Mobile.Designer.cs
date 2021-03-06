// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi.Entities;

namespace WebApi.Migrations
{
    [DbContext(typeof(StudentsContext))]
    [Migration("20220321092510_Mobile")]
    partial class Mobile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.HasSequence<int>("id", "dbo");

            modelBuilder.HasSequence<int>("rollno", "dbo");

            modelBuilder.Entity("WebApi.Entities.Data", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<int>("mark1")
                        .HasColumnType("integer");

                    b.Property<int>("mark2")
                        .HasColumnType("integer");

                    b.Property<int>("mark3")
                        .HasColumnType("integer");

                    b.Property<string>("result")
                        .HasColumnType("text");

                    b.Property<int>("rollno")
                        .HasColumnType("integer");

                    b.Property<int>("totalmarks")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("WebApi.Entities.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("WebApi.Entities.Marklist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("mark1")
                        .HasColumnType("integer");

                    b.Property<int>("mark2")
                        .HasColumnType("integer");

                    b.Property<int>("mark3")
                        .HasColumnType("integer");

                    b.Property<int>("rollno")
                        .HasColumnType("integer");

                    b.Property<int>("totalmarks")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Marklists");
                });

            modelBuilder.Entity("WebApi.Entities.Mobile", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.Property<int>("rollno")
                        .HasColumnType("integer");

                    b.ToTable("Mobiles");
                });

            modelBuilder.Entity("WebApi.Entities.Student", b =>
                {
                    b.Property<int>("rollno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<string>("phoneno")
                        .HasColumnType("text");

                    b.HasKey("rollno");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApi.Entities.StudentImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.Property<int>("rollno")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("StudentImages");
                });
#pragma warning restore 612, 618
        }
    }
}
