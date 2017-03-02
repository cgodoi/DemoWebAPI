using MongoDB.Driver;
using DemoWebApi.Models;
using DemoWebApi.Models.Repository;
using System.Configuration;

namespace DemoWebApi.Models.UnitOfWork
{
    public class UnitOfWork
    {
        private MongoDatabase _database;
        protected Repository<Usuario> _usuarios;

        public UnitOfWork()
        {
            var connectionString = ConfigurationManager.AppSettings
            ["MongoDBConectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = ConfigurationManager.AppSettings
            ["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }
        public Repository<Usuario> Usuarios
        {
            get
            {
                if (_usuarios == null)
                    _usuarios = new Repository<Usuario>(_database, "Usuario");

                return _usuarios;
            }
        }
    }

    public class DispositivosUnitOfWork
    {
        private MongoDatabase _database;
        protected Repository<Dispositivo> _dispositivos;

        public DispositivosUnitOfWork()
        {
            var connectionString = ConfigurationManager.AppSettings
            ["MongoDBConectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = ConfigurationManager.AppSettings
            ["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }
        public Repository<Dispositivo> Dispositivos
        {
            get
            {
                if (_dispositivos == null)
                    _dispositivos = new Repository<Dispositivo>(_database, "Dispositivos");

                return _dispositivos;
            }
        }
    }
}
