﻿// <auto-generated />
using System;
using Datos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(CalidadContext))]
    partial class CalidadContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("Dominio.Entities.Defecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDefecto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Defectos");
                });

            modelBuilder.Entity("Dominio.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Dominio.Entities.Hallazgo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("DefectoId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoDeCalidadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("HorarioTrabajoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DefectoId");

                    b.HasIndex("EmpleadoDeCalidadId");

                    b.HasIndex("HorarioTrabajoId");

                    b.ToTable("Hallazgos");
                });

            modelBuilder.Entity("Dominio.Entities.Hermanado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HermanadoPrimera")
                        .HasColumnType("int");

                    b.Property<int>("HermanadoSegunda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hermanados");
                });

            modelBuilder.Entity("Dominio.Entities.HorarioTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HermanadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrdenDeProduccionId")
                        .HasColumnType("int");

                    b.Property<int?>("TurnoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HermanadoId");

                    b.HasIndex("OrdenDeProduccionId");

                    b.HasIndex("TurnoId");

                    b.ToTable("HorariosDeTrabajo");
                });

            modelBuilder.Entity("Dominio.Entities.LineaDeTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Lineas");
                });

            modelBuilder.Entity("Dominio.Entities.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denominacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Objetivo")
                        .HasColumnType("int");

                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("Dominio.Entities.OrdenDeProduccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoOrdenId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("LineaId")
                        .HasColumnType("int");

                    b.Property<int?>("LineaIniciadaPorId")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Objetivo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("EmpleadoOrdenId");

                    b.HasIndex("LineaId");

                    b.HasIndex("LineaIniciadaPorId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Dominio.Entities.Primera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoDeCalidadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HorarioTrabajoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoDeCalidadId");

                    b.HasIndex("HorarioTrabajoId");

                    b.ToTable("Primeras");
                });

            modelBuilder.Entity("Dominio.Entities.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("Dominio.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dominio.Entities.Hallazgo", b =>
                {
                    b.HasOne("Dominio.Entities.Defecto", "Defecto")
                        .WithMany()
                        .HasForeignKey("DefectoId");

                    b.HasOne("Dominio.Entities.Empleado", "EmpleadoDeCalidad")
                        .WithMany()
                        .HasForeignKey("EmpleadoDeCalidadId");

                    b.HasOne("Dominio.Entities.HorarioTrabajo", null)
                        .WithMany("Hallazgos")
                        .HasForeignKey("HorarioTrabajoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Defecto");

                    b.Navigation("EmpleadoDeCalidad");
                });

            modelBuilder.Entity("Dominio.Entities.HorarioTrabajo", b =>
                {
                    b.HasOne("Dominio.Entities.Hermanado", "Hermanado")
                        .WithMany()
                        .HasForeignKey("HermanadoId");

                    b.HasOne("Dominio.Entities.OrdenDeProduccion", "OrdenDeProduccion")
                        .WithMany("Horarios")
                        .HasForeignKey("OrdenDeProduccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Turno", "Turno")
                        .WithMany()
                        .HasForeignKey("TurnoId");

                    b.Navigation("Hermanado");

                    b.Navigation("OrdenDeProduccion");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("Dominio.Entities.LineaDeTrabajo", b =>
                {
                    b.HasOne("Dominio.Entities.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Dominio.Entities.OrdenDeProduccion", b =>
                {
                    b.HasOne("Dominio.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Empleado", "EmpleadoOrden")
                        .WithMany()
                        .HasForeignKey("EmpleadoOrdenId");

                    b.HasOne("Dominio.Entities.LineaDeTrabajo", "Linea")
                        .WithMany("OrdenesDeProduccion")
                        .HasForeignKey("LineaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Empleado", "LineaIniciadaPor")
                        .WithMany()
                        .HasForeignKey("LineaIniciadaPorId");

                    b.HasOne("Dominio.Entities.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("EmpleadoOrden");

                    b.Navigation("Linea");

                    b.Navigation("LineaIniciadaPor");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Dominio.Entities.Primera", b =>
                {
                    b.HasOne("Dominio.Entities.Empleado", "EmpleadoDeCalidad")
                        .WithMany()
                        .HasForeignKey("EmpleadoDeCalidadId");

                    b.HasOne("Dominio.Entities.HorarioTrabajo", null)
                        .WithMany("ParesPrimera")
                        .HasForeignKey("HorarioTrabajoId");

                    b.Navigation("EmpleadoDeCalidad");
                });

            modelBuilder.Entity("Dominio.Entities.Usuario", b =>
                {
                    b.HasOne("Dominio.Entities.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Dominio.Entities.HorarioTrabajo", b =>
                {
                    b.Navigation("Hallazgos");

                    b.Navigation("ParesPrimera");
                });

            modelBuilder.Entity("Dominio.Entities.LineaDeTrabajo", b =>
                {
                    b.Navigation("OrdenesDeProduccion");
                });

            modelBuilder.Entity("Dominio.Entities.OrdenDeProduccion", b =>
                {
                    b.Navigation("Horarios");
                });
#pragma warning restore 612, 618
        }
    }
}
