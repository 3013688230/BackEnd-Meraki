using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIMeraki.Entities
{
    public partial class MerakiV2Context : DbContext
    {
        public MerakiV2Context()
        {
        }

        public MerakiV2Context(DbContextOptions<MerakiV2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Conductore> Conductores { get; set; }
        public virtual DbSet<EstadoServicio> EstadoServicios { get; set; }
        public virtual DbSet<EstadoUsuario> EstadoUsuarios { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Propietario> Propietarios { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoCarga> TipoCargas { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SD53LKE\\SQLEXPRESS;Database=MerakiV2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__D5946642BB2FD90A");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_Genero");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Clientes_TipoD");
            });

            modelBuilder.Entity<Conductore>(entity =>
            {
                entity.HasKey(e => e.IdConductor)
                    .HasName("PK__Conducto__D6D29603217C47E1");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoV).HasColumnName("Codigo_V");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_inicio");

                entity.Property(e => e.FotoConductor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Foto_Conductor");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.CodigoVNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.CodigoV)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductor_Vehiculo");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductor_Genero");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Conductores)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conductor_TipoD");
            });

            modelBuilder.Entity<EstadoServicio>(entity =>
            {
                entity.HasKey(e => e.IdEstadoServicio)
                    .HasName("PK__EstadoSe__6E13DB5429D026E4");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdEstadoUsuario)
                    .HasName("PK__EstadoUs__C8A30BCDB6811F5A");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__Generos__0F8349886675C5C2");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Propietario>(entity =>
            {
                entity.HasKey(e => e.IdPropietario)
                    .HasName("PK__Propieta__4D581B50E3F3D560");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento).HasColumnName("numeroDocumento");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Propietarios_Genero");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Propietarios_TipoD");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__2A49584C049C409A");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__2DCCF9A2BD41B52E");

                entity.Property(e => e.CelularRecibe).HasColumnName("Celular_Recibe");

                entity.Property(e => e.DireccionCarga)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Direccion_Carga");

                entity.Property(e => e.DireccionEntrega)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Direccion_Entrega");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Inicio");

                entity.Property(e => e.PersonaRecibe)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Persona_Recibe");

                entity.Property(e => e.PrecioServicio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Precio_Servicio");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Cliente");

                entity.HasOne(d => d.IdConductorNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdConductor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Coductor");

                entity.HasOne(d => d.IdEstadoServicioNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdEstadoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Estado");

                entity.HasOne(d => d.IdTipoCargaNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTipoCarga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_Carga");

                entity.HasOne(d => d.IdTipoVehiculoNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdTipoVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Servicios_TipoVehiculo");
            });

            modelBuilder.Entity<TipoCarga>(entity =>
            {
                entity.HasKey(e => e.IdTipoCarga)
                    .HasName("PK__TipoCarg__5D382ACBD5EB1967");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK__TipoDocu__3AB3332FF4FAA0F7");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculo)
                    .HasName("PK__TipoVehi__DC20741E88909CE2");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF979A1ED77E");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_EstadoUsuario");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_rol");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.CodigoV)
                    .HasName("PK__Vehiculo__DB3716A87D84BBE7");

                entity.Property(e => e.CodigoV)
                    .ValueGeneratedNever()
                    .HasColumnName("Codigo_V");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FotoV)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("foto_V");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SeguroCarga)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("seguro_Carga");

                entity.Property(e => e.Soat)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TecnoMecanica)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("tecno_Mecanica");

                entity.HasOne(d => d.IdPropietarioNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdPropietario)
                    .HasConstraintName("fk_Vehiculo_Dueño");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
