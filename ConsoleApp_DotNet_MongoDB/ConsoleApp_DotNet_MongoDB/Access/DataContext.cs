using ConsoleApp_DotNet_MongoDB.Domain;
using MongoDB.Driver;
using System;

namespace ConsoleApp_DotNet_MongoDB.Access {
  public class DataContext {

    private IMongoDatabase MongoDatabase { get; set; }

    public DataContext() {
      var client = new MongoClient(Environment.GetEnvironmentVariable("MongoDBConnectionString",EnvironmentVariableTarget.User));
      this.MongoDatabase = client.GetDatabase("MongoDatabaseTest");
    }

    public IMongoCollection<Persona> Personas {
      get { return this.MongoDatabase.GetCollection<Persona>("personas"); }
    }
    public IMongoCollection<Vehiculo> Vehiculos {
      get { return this.MongoDatabase.GetCollection<Vehiculo>("vehiculos"); }
    }
  }
}
