En esta carpeta se guarda todo lo relacionado a Bases de Datos, como por ejemplo:
- Entidades
- Migraciones (Creacion de tablas o esquemas en la base de datos)
- Seeders (Siembra de nuevos datos en una tabla de base d)

# Crear o actualizar base de datos
## Requisitos 
Para levantar la base de datos del proyecto es necesario que tengas instalado SQLServer en tu maquina
## Pasos
1. Abre Visual Studio
1. Abre Tools → NuGet Package Manager → Package Manager Console 
1. En la consola de Package Manager ejecuta el siguiente comando:
   ```powershell
   Update-Database
   ```
   Esto creara la base de datos y las tablas necesarias para el proyecto.


## Crear nueva tabla de base de datos
1. Crea una nueva clase en la carpeta Entidades que represente la nueva tabla, con sus propiedades y sus anotaciones correspondientes. Ejemplo: Pais
```csharp
   public class NombreEntidad
   {
		[Key]
        [Column("id")]
		public int Id { get; set; }
	   
	    [Required]
        [Column("descripcion", TypeName = "varchar(100)")]
		public string Nombre { get; set; }
   }
   ```
1. Crea una nueva clase de configuracion en la carpeta Configuraciones que implemente `IEntityTypeConfiguration<NombreEntidad>`. Ejemplo: PaisConfig
   ```csharp
   public class NombreEntidadConfig : IEntityTypeConfiguration<NombreEntidad>
   {
	   public void Configure(EntityTypeBuilder<NombreEntidad> builder)
	   {	
			// Configuracion de primary key
			builder.ToTable("rubro");

            builder.Property(rubro => rubro.Id)
                   .ValueGeneratedOnAdd();

		   // Relaciones de la entidad
	   }
   }
   ```
1. En la clase ProyectoPOEContext agrega la nueva entidad a la propiedad `DbSet<T>` correspondiente.
   ```csharp
   public DbSet<NombreEntidad> NombreEntidades { get; set; }
   ```
1. Dentro de ProyectoPOEContext, en el metodo OnModelCreating agrega la configuracion de la nueva entidad.
   ```csharp
	modelBuilder.ApplyConfiguration(new RubroConfig());
   ```
1. Cuando hayas terminado de crear la nueva entidad, ejecuta el siguiente comando en la consola de Package Manager, para que los demás puedan actualizar la base de datos con los cambios realizados:
```powershell
	Add-Migration CreateEmprendimientoTable -OutputDir Datos\Migraciones
```
