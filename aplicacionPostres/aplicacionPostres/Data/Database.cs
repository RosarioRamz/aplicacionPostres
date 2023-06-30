using aplicacionPostres.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionPostres.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Postres>(); //Creación de la tabla postres
            _database.CreateTableAsync<Sucursal>(); //Creación de la tabla Sucursal
        }
        public Task<List<Postres>> GetPostresAsync()
        {
            return _database.Table<Postres>().ToListAsync();
        }
        public Task<int> SavePostreAsync(Postres postre)
        {
            return _database.InsertAsync(postre);
        }
        public Task<int> UpdatePostreAsync(Postres postre)
        {
            return _database.UpdateAsync(postre);
        }
        public Task<int> DeletePostreAsync(Postres postre)
        {
            return _database.DeleteAsync(postre);
        }
        //Métodos para la sucursal
        //Sucursal
        public Task<List<Sucursal>> GetSucursalAsync()
        {
            return _database.Table<Sucursal>().ToListAsync();
        }
        public Task<int> SaveSucursalAsync(Sucursal sucursal)
        {
            return _database.InsertAsync(sucursal);
        }
        public Task<int> UpdateSucursalAsync(Sucursal sucursal)
        {
            return _database.UpdateAsync(sucursal);
        }
        public Task<int> DeleteSucursalAsync(Sucursal sucursal)
        {
            return _database.DeleteAsync(sucursal);
        }
    }
}
