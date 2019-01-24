namespace FormsVsModelBinding.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DragonDB : DbContext
    {
        // Your context has been configured to use a 'DragonDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FormsVsModelBinding.Models.DragonDB' database on your LocalDb instance. 
        // 
    }
}        // If you wish to target a different database and/or database provider, modify the 'DragonDB' 
         // connection string in the application configuration file.
public DragonDB()
    : base("name=DragonDB")
{
}

// Add a DbSet for each entity type that you want to include in your model. For more information 
// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

// public virtual DbSet<MyEntity> MyEntities { get; set; }
public virtual DbSet<Dragon> Dragons { get; set; }


public System.Data.Entity.DbSet<FormsVsModelBinding.Models.Species> Species { get; set; }

public System.Data.Entity.DbSet<FormsVsModelBinding.Models.Class> Classes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //
