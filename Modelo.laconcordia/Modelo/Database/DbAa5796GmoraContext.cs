using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Modelo.laconcordia.Modelo.Database;

public partial class DbAa5796GmoraContext : DbContext
{
    public DbAa5796GmoraContext()
    {
    }

    public DbAa5796GmoraContext(DbContextOptions<DbAa5796GmoraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Controlaplicacione> Controlaplicaciones { get; set; }

    public virtual DbSet<Controlunidade> Controlunidades { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Duenopuesto> Duenopuestos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estadocivil> Estadocivils { get; set; }

    public virtual DbSet<Fichaobservacione> Fichaobservaciones { get; set; }

    public virtual DbSet<Fichapersonal> Fichapersonals { get; set; }

    public virtual DbSet<Flujocaja> Flujocajas { get; set; }

    public virtual DbSet<Generarcuotum> Generarcuota { get; set; }

    public virtual DbSet<Generarmultum> Generarmulta { get; set; }

    public virtual DbSet<Generarplanayudum> Generarplanayuda { get; set; }

    public virtual DbSet<Generarplanchoque> Generarplanchoques { get; set; }

    public virtual DbSet<MenuInfo> MenuInfos { get; set; }

    public virtual DbSet<Movimientocuotum> Movimientocuota { get; set; }

    public virtual DbSet<Movimientoubm> Movimientoubms { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }

    public virtual DbSet<NavigationItem> NavigationItems { get; set; }

    public virtual DbSet<Niveleducacion> Niveleducacions { get; set; }

    public virtual DbSet<Ordendepago> Ordendepagos { get; set; }

    public virtual DbSet<Parentesco> Parentescos { get; set; }

    public virtual DbSet<Pasajero> Pasajeros { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoAut> PedidoAuts { get; set; }

    public virtual DbSet<RoleNavigationPermission> RoleNavigationPermissions { get; set; }

    public virtual DbSet<Segurovidum> Segurovida { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Tipolicencium> Tipolicencia { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UserNavigationPermission> UserNavigationPermissions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User= db_aa5796_gmora_admin; Password= gmora100;Persist Security Info=False;Initial Catalog=db_aa5796_gmora;Data Source=sql8006.site4now.net");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.ToTable("AspNetRoles", "Identity");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "Identity");

            entity.Property(e => e.RoleId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.ToTable("AspNetUsers", "Identity");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "Identity");

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "Identity");

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.ToTable("AspNetUserRoles", "Identity");

            entity.Property(e => e.Discriminator).HasMaxLength(34);

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "Identity");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Idcargo).HasName("PKCARGO");

            entity.ToTable("CARGO");

            entity.Property(e => e.Idcargo).HasColumnName("idcargo");
            entity.Property(e => e.Cargo1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
        });

        modelBuilder.Entity<Controlaplicacione>(entity =>
        {
            entity.HasKey(e => e.IdControlaplicaciones);

            entity.ToTable("controlaplicaciones");

            entity.Property(e => e.IdControlaplicaciones).HasColumnName("id_controlaplicaciones");
            entity.Property(e => e.IdMenu).HasColumnName("id_menu");
            entity.Property(e => e.IdTipoUsuario).HasColumnName("id_tipo_Usuario");
        });

        modelBuilder.Entity<Controlunidade>(entity =>
        {
            entity.HasKey(e => new { e.Fecharegistro, e.Unidad, e.Estado }).HasName("PK_CONTROLUNIDAD");

            entity.ToTable("CONTROLUNIDADES");

            entity.Property(e => e.Fecharegistro).HasColumnName("fecharegistro");
            entity.Property(e => e.Unidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Ciconductor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ciconductor");
            entity.Property(e => e.Conductor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conductor");
            entity.Property(e => e.Monitora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("monitora");
            entity.Property(e => e.Monitorasig)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("monitorasig");
            entity.Property(e => e.Turno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("turno");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => new { e.Latitud, e.Longitud, e.Celular }).HasName("PK_LATITUD_LONG");

            entity.ToTable("DIRECCION");

            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("longitud");
            entity.Property(e => e.Celular)
                .HasMaxLength(12)
                .HasColumnName("celular");
            entity.Property(e => e.Calle)
                .HasMaxLength(300)
                .HasColumnName("calle");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Referencia)
                .HasMaxLength(500)
                .HasColumnName("referencia");

            entity.HasOne(d => d.CelularNavigation).WithMany(p => p.Direccions)
                .HasForeignKey(d => d.Celular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PASAJERO_DIRECCION");
        });

        modelBuilder.Entity<Duenopuesto>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK_DPCEDULA");

            entity.ToTable("DUENOPUESTO");

            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cedula");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Ruc).HasName("PK_RUC");

            entity.ToTable("EMPRESA");

            entity.Property(e => e.Ruc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Estadocivil>(entity =>
        {
            entity.HasKey(e => e.Idestadocivil).HasName("PK_IDESTADOCIVIL");

            entity.ToTable("ESTADOCIVIL");

            entity.Property(e => e.Idestadocivil).HasColumnName("idestadocivil");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
        });

        modelBuilder.Entity<Fichaobservacione>(entity =>
        {
            entity.HasKey(e => e.Idfichaobs).HasName("PK_IDFICHAOBS");

            entity.ToTable("FICHAOBSERVACIONES");

            entity.Property(e => e.Idfichaobs).HasColumnName("idfichaobs");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Fkcedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fkcedula");
            entity.Property(e => e.Fkunidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fkunidad");
            entity.Property(e => e.Motivo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("motivo");

            entity.HasOne(d => d.FkcedulaNavigation).WithMany(p => p.Fichaobservaciones)
                .HasForeignKey(d => d.Fkcedula)
                .HasConstraintName("FK_OBSERVACION_PERSONAL");
        });

        modelBuilder.Entity<Fichapersonal>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK_CEDULA");

            entity.ToTable("FICHAPERSONAL");

            entity.Property(e => e.Cedula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cedula");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Celular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Cuotaf)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("cuotaf");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("domicilio");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Estadoservicio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("p")
                .IsFixedLength()
                .HasColumnName("estadoservicio");
            entity.Property(e => e.Fechaingreso)
                .HasColumnType("datetime")
                .HasColumnName("fechaingreso");
            entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");
            entity.Property(e => e.Fkcargo).HasColumnName("fkcargo");
            entity.Property(e => e.Fkdpuesto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fkdpuesto");
            entity.Property(e => e.Fkestadocivil).HasColumnName("fkestadocivil");
            entity.Property(e => e.Fknacionalidad).HasColumnName("fknacionalidad");
            entity.Property(e => e.Fkniveleducacion).HasColumnName("fkniveleducacion");
            entity.Property(e => e.Fktipolicencia).HasColumnName("fktipolicencia");
            entity.Property(e => e.Fkunidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fkunidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Referencia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.FkcargoNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fkcargo)
                .HasConstraintName("FK_FICHA_CARGO");

            entity.HasOne(d => d.FkdpuestoNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fkdpuesto)
                .HasConstraintName("FK_FICHA_DPUESTO");

            entity.HasOne(d => d.FkestadocivilNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fkestadocivil)
                .HasConstraintName("FK_FICHA_ESTADOCIVIL");

            entity.HasOne(d => d.FknacionalidadNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fknacionalidad)
                .HasConstraintName("FK_FICHA_NACIONALIDAD");

            entity.HasOne(d => d.FkniveleducacionNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fkniveleducacion)
                .HasConstraintName("FK_FICHA_EDUCACION");

            entity.HasOne(d => d.FktipolicenciaNavigation).WithMany(p => p.Fichapersonals)
                .HasForeignKey(d => d.Fktipolicencia)
                .HasConstraintName("FK_FICHA_LICENCIA");
        });

        modelBuilder.Entity<Flujocaja>(entity =>
        {
            entity.HasKey(e => e.Idflujocaja);

            entity.ToTable("FLUJOCAJA");

            entity.Property(e => e.Idflujocaja).HasColumnName("idflujocaja");
            entity.Property(e => e.Concepto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Egreso)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("egreso");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Ingreso)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("ingreso");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Generarcuotum>(entity =>
        {
            entity.HasKey(e => new { e.Periodo, e.Semana, e.Cidentidad });

            entity.ToTable("GENERARCUOTA");

            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("periodo");
            entity.Property(e => e.Semana)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("semana");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("abono");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Generarmultum>(entity =>
        {
            entity.HasKey(e => new { e.Idmulta, e.Cidentidad }).HasName("PK_IDMULTA");

            entity.ToTable("GENERARMULTA");

            entity.Property(e => e.Idmulta)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("idmulta");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("abono");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Observacion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Generarplanayudum>(entity =>
        {
            entity.HasKey(e => new { e.Beneficiario, e.Cidentidad, e.Fecha }).HasName("PK_GENERAR_PLAN_AYUDA");

            entity.ToTable("GENERARPLANAYUDA");

            entity.Property(e => e.Beneficiario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("beneficiario");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("abono");
            entity.Property(e => e.Observacion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Generarplanchoque>(entity =>
        {
            entity.HasKey(e => new { e.Unidad, e.Cidentidad, e.Fecha }).HasName("PK_GENERAR_PLAN_CHOQUE");

            entity.ToTable("GENERARPLANCHOQUE");

            entity.Property(e => e.Unidad)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unidad");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Abono)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("abono");
            entity.Property(e => e.Observacion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<MenuInfo>(entity =>
        {
            entity.HasKey(e => e.Menuid);

            entity.ToTable("MenuInfo");

            entity.Property(e => e.IcoName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Movimientocuotum>(entity =>
        {
            entity.HasKey(e => new { e.Periodo, e.Semana, e.Cidentidad, e.Fechapago }).HasName("PK__MOVIMIEN__C7390F04DA4B7FA7");

            entity.ToTable("MOVIMIENTOCUOTA");

            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("periodo");
            entity.Property(e => e.Semana)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("semana");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Fechapago)
                .HasColumnType("datetime")
                .HasColumnName("fechapago");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banco");
            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Formadepago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formadepago");
            entity.Property(e => e.Numcomprobante)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("numcomprobante");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.Valorpagado)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valorpagado");
        });

        modelBuilder.Entity<Movimientoubm>(entity =>
        {
            entity.HasKey(e => new { e.Ubm, e.Tipo, e.Cidentidad, e.Fechapago }).HasName("PK_MV_UBM");

            entity.ToTable("MOVIMIENTOUBM");

            entity.Property(e => e.Ubm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ubm");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Cidentidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cidentidad");
            entity.Property(e => e.Fechapago)
                .HasColumnType("datetime")
                .HasColumnName("fechapago");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banco");
            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Formadepago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formadepago");
            entity.Property(e => e.Numcomprobante)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("numcomprobante");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.Valorpagado)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("valorpagado");
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.Idnacionalidad).HasName("PK_IDNACIONALIDAD");

            entity.ToTable("NACIONALIDAD");

            entity.Property(e => e.Idnacionalidad).HasColumnName("idnacionalidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nacionalidad1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nacionalidad");
        });

        modelBuilder.Entity<NavigationItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Navigati__3214EC076A0A630B");

            entity.HasIndex(e => e.IsActive, "IX_NavigationItems_IsActive");

            entity.HasIndex(e => e.ParentId, "IX_NavigationItems_ParentId");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Order).HasDefaultValue(0);
            entity.Property(e => e.RequiredRole).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Url).HasMaxLength(255);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__Navigatio__Paren__0FB750B3");
        });

        modelBuilder.Entity<Niveleducacion>(entity =>
        {
            entity.HasKey(e => e.Ideducacion).HasName("PK_EDUCACION");

            entity.ToTable("NIVELEDUCACION");

            entity.Property(e => e.Ideducacion).HasColumnName("ideducacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
        });

        modelBuilder.Entity<Ordendepago>(entity =>
        {
            entity.HasKey(e => e.Numvoucher).HasName("PKVOUCHER");

            entity.ToTable("ORDENDEPAGO");

            entity.Property(e => e.Numvoucher)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numvoucher");
            entity.Property(e => e.Celular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Ciconductor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ciconductor");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.Conductor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conductor");
            entity.Property(e => e.Empleado)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empleado");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.Estadoproceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estadoproceso");
            entity.Property(e => e.Fechacorte).HasColumnName("fechacorte");
            entity.Property(e => e.Fechaderegistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaderegistro");
            entity.Property(e => e.Fechaproceso)
                .HasColumnType("datetime")
                .HasColumnName("fechaproceso");
            entity.Property(e => e.Fechayhora)
                .HasColumnType("datetime")
                .HasColumnName("fechayhora");
            entity.Property(e => e.Observacion)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Preciodesc)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("preciodesc");
            entity.Property(e => e.Puntofinal)
                .HasMaxLength(200)
                .HasColumnName("puntofinal");
            entity.Property(e => e.Puntopartida)
                .HasMaxLength(200)
                .HasColumnName("puntopartida");
            entity.Property(e => e.Recorrido)
                .HasMaxLength(300)
                .HasColumnName("recorrido");
            entity.Property(e => e.Ruc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Tiempoespera)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tiempoespera");
            entity.Property(e => e.Unidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("unidad");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.Valija)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("valija");
        });

        modelBuilder.Entity<Parentesco>(entity =>
        {
            entity.HasKey(e => e.Idparentesco).HasName("PK_IDPARENTESCO");

            entity.ToTable("PARENTESCO");

            entity.Property(e => e.Idparentesco).HasColumnName("idparentesco");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Parentesco1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parentesco");
        });

        modelBuilder.Entity<Pasajero>(entity =>
        {
            entity.HasKey(e => e.Celular);

            entity.ToTable("PASAJERO");

            entity.Property(e => e.Celular)
                .HasMaxLength(12)
                .HasColumnName("celular");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Observacion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Publicidad)
                .HasDefaultValue(0)
                .HasColumnName("publicidad");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Whatsapp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("whatsapp");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => new { e.Celular, e.Origenlat, e.Origenlog, e.Destinolat, e.Destinolog, e.Fecharegistro });

            entity.ToTable("PEDIDO");

            entity.Property(e => e.Celular)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("celular");
            entity.Property(e => e.Origenlat)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("origenlat");
            entity.Property(e => e.Origenlog)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("origenlog");
            entity.Property(e => e.Destinolat)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("destinolat");
            entity.Property(e => e.Destinolog)
                .HasColumnType("decimal(10, 7)")
                .HasColumnName("destinolog");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Autorizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .IsFixedLength()
                .HasColumnName("autorizado");
            entity.Property(e => e.Base)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("base");
            entity.Property(e => e.Ciconductor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ciconductor");
            entity.Property(e => e.Ciconductorsiguiente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ciconductorsiguiente");
            entity.Property(e => e.Conductor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conductor");
            entity.Property(e => e.Conductorsiguiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conductorsiguiente");
            entity.Property(e => e.Empleado)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empleado");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Despachadas")
                .HasColumnName("estado");
            entity.Property(e => e.Km)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("km");
            entity.Property(e => e.Numvoucher)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numvoucher");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Recorrido)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("recorrido");
            entity.Property(e => e.Ruc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Tiempodemora).HasColumnName("tiempodemora");
            entity.Property(e => e.Unidad)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("unidad");
            entity.Property(e => e.Unidadsiguiente)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("unidadsiguiente");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.Valija)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("valija");
        });

        modelBuilder.Entity<PedidoAut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PEDIDO_AUT");

            entity.Property(e => e.Empleado)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empleado");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecharegistro");
            entity.Property(e => e.Numvoucher)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numvoucher");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Recorrido)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("recorrido");
            entity.Property(e => e.Ruc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<RoleNavigationPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RoleNavi__3214EC07F6A51F0C");

            entity.ToTable("RoleNavigationPermissions", "Identity");

            entity.HasIndex(e => e.NavigationItemId, "IX_RoleNavigationPermissions_NavigationItemId");

            entity.HasIndex(e => e.RoleId, "IX_RoleNavigationPermissions_RoleId");

            entity.HasIndex(e => new { e.RoleId, e.NavigationItemId }, "UQ_RoleNavPerm").IsUnique();

            entity.Property(e => e.CanView).HasDefaultValue(true);
            entity.Property(e => e.GrantedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrantedBy).HasMaxLength(450);

            entity.HasOne(d => d.GrantedByNavigation).WithMany(p => p.RoleNavigationPermissions)
                .HasForeignKey(d => d.GrantedBy)
                .HasConstraintName("FK_RoleNavPerm_GrantedBy");

            entity.HasOne(d => d.NavigationItem).WithMany(p => p.RoleNavigationPermissions)
                .HasForeignKey(d => d.NavigationItemId)
                .HasConstraintName("FK_RoleNavPerm_NavItem");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleNavigationPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_RoleNavPerm_Role");
        });

        modelBuilder.Entity<Segurovidum>(entity =>
        {
            entity.HasKey(e => new { e.CiBeneficiario, e.CiAfiliado }).HasName("PK_BENEFICIARIO");

            entity.ToTable("SEGUROVIDA");

            entity.Property(e => e.CiBeneficiario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ci_beneficiario");
            entity.Property(e => e.CiAfiliado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ci_afiliado");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Pkparentesco).HasColumnName("pkparentesco");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .IsFixedLength()
                .HasColumnName("tipo");

            entity.HasOne(d => d.CiAfiliadoNavigation).WithMany(p => p.Segurovida)
                .HasForeignKey(d => d.CiAfiliado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEGUROVIDA_FICHA");

            entity.HasOne(d => d.PkparentescoNavigation).WithMany(p => p.Segurovida)
                .HasForeignKey(d => d.Pkparentesco)
                .HasConstraintName("FK_SEGURO_PARENTESCO");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdtipoUsuario);

            entity.ToTable("TIPO_USUARIO");

            entity.Property(e => e.IdtipoUsuario).HasColumnName("idtipo_usuario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.TipoUsuario1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_usuario");
        });

        modelBuilder.Entity<Tipolicencium>(entity =>
        {
            entity.HasKey(e => e.Idtipo).HasName("PK_IDTIPOLICENCIA");

            entity.ToTable("TIPOLICENCIA");

            entity.Property(e => e.Idtipo).HasColumnName("idtipo");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Profesional)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("profesional");
            entity.Property(e => e.Tipolicencia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipolicencia");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => new { e.Unidad1, e.Placa });

            entity.ToTable("UNIDAD");

            entity.Property(e => e.Unidad1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unidad");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Idpropietario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idpropietario");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("propietario");
        });

        modelBuilder.Entity<UserNavigationPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserNavi__3214EC07A7D17D33");

            entity.ToTable("UserNavigationPermissions", "Identity");

            entity.HasIndex(e => e.NavigationItemId, "IX_UserNavigationPermissions_NavigationItemId");

            entity.HasIndex(e => e.UserId, "IX_UserNavigationPermissions_UserId");

            entity.HasIndex(e => new { e.UserId, e.NavigationItemId }, "UQ_UserNavPerm").IsUnique();

            entity.Property(e => e.CanView).HasDefaultValue(true);
            entity.Property(e => e.GrantedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrantedBy).HasMaxLength(450);

            entity.HasOne(d => d.GrantedByNavigation).WithMany(p => p.UserNavigationPermissionGrantedByNavigations)
                .HasForeignKey(d => d.GrantedBy)
                .HasConstraintName("FK_UserNavPerm_GrantedBy");

            entity.HasOne(d => d.NavigationItem).WithMany(p => p.UserNavigationPermissions)
                .HasForeignKey(d => d.NavigationItemId)
                .HasConstraintName("FK_UserNavPerm_NavItem");

            entity.HasOne(d => d.User).WithMany(p => p.UserNavigationPermissionUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserNavPerm_User");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Usuario1);

            entity.ToTable("USUARIO");

            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Fktipousuario).HasColumnName("fktipousuario");
            entity.Property(e => e.Nombres)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Passwd)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("passwd");

            entity.HasOne(d => d.FktipousuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Fktipousuario)
                .HasConstraintName("FK_USUARIO_TIPOUSU");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
