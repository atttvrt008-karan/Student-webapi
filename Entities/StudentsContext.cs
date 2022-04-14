using Microsoft.EntityFrameworkCore;  
namespace WebApi.Entities
{     
public class StudentsContext : DbContext     
  {         
    public StudentsContext(DbContextOptions<StudentsContext> options)                 : base(options)         
{         
}       
    public DbSet<Student> Students{ get; set; } 
    public DbSet<Marklist>Marklists{ get; set; } 

    public DbSet<StudentImage>StudentImages {get; set ;}
    public DbSet<Data>Datas {get; set ;}

     public DbSet<Login>Logins {get; set ;}

       public DbSet<Mobile>Mobiles {get; set ;}
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
        modelBuilder.HasSequence<int>("rollno", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
            //builder.ForNpgsqlUseIdentityColumns();

        modelBuilder.Entity<Student>()
            .Property(o => o.rollno);
            // .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");

             modelBuilder.HasSequence<int>("id", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
          

        modelBuilder.Entity<Marklist>()
            .Property(o => o.id);
            // .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
             
             
           modelBuilder.HasSequence<int>("id", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
            //builder.ForNpgsqlUseIdentityColumns();

        modelBuilder.Entity<StudentImage>()
            .Property(o => o.id);
            // .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
            modelBuilder.HasSequence<int>("id", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
            //builder.ForNpgsqlUseIdentityColumns();

        modelBuilder.Entity<Data>()
            .Property(o => o.id);
            // .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
             modelBuilder.HasSequence<int>("id", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
            //builder.ForNpgsqlUseIdentityColumns();

        modelBuilder.Entity<Login>() 
            .Property(o => o.id);
            //   .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
                modelBuilder.HasSequence<int>("id", schema: "dbo")
            .StartsAt(1)
            .IncrementsBy(1);
        //      modelBuilder.Entity<Mobile>(); 
            // .Property(o => o.id);
            // //   .HasDefaultValueSql("NEXT VALUE FOR dbo.Order_seq");
            //     modelBuilder.HasSequence<int>("id", schema: "dbo")
            // .StartsAt(1)
            // .IncrementsBy(1);
      }
      // protected override void OnModelCreating(ModelBuilder modelBuilder)
      //   {
      //       modelBuilder.Entity<Student>().HasNoKey();
      //   }
  
   } 
}