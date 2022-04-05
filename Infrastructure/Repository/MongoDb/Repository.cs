using Infrastructure.Abstraction.Database;
using Infrastructure.Abstraction.Database.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.MongoDb {
    public class Repository<T> : IRepository<T>{
        private IMongoDbCommand _db;
        public Repository(IMongoDbCommand db) {
            this._db = db;
        }
        public async Task<bool> create(T staff) {
            bool inserted = await _db.insert<T>(staff);
            return inserted;
        }

        public async Task<bool> delete(Expression<Func<T, bool>> clause) {
            var filter = _db.getFilter<T>(clause);
            bool resp = await _db.delete<T>(filter);
            return resp;
        }

        public async Task<IEnumerable<T>> getAll() {
            return await _db.select<T>();
        }

        public async Task<IEnumerable<T>> getByCondition(Expression<Func<T, bool>> clause) {
            var filter = _db.getFilter<T>(clause);
            return await _db.select<T>(filter);
        }

        public async Task<IEnumerable<T>> getByCondition(IEnumerable<Expression<Func<T, bool>>> clause) {
            var filter = _db.getFilter<T>(clause);
            return await _db.select<T>(filter);
        }

        public async Task<bool> isExist(Expression<Func<T, bool>> clause) {
            var filter = _db.getFilter<T>(clause);
            List<T> results = (List<T>)await _db.select<T>(filter);
            return results.Count > 0;
        }

        public async Task<bool> update(object data, Expression<Func<T, bool>> clause) {
            bool resp = await _db.update<T>(clause, data);
            return resp;
        }
        public async Task<bool> update(Dictionary<string, dynamic> data, Expression<Func<T, bool>> clause) {
            bool resp = await _db.update<T>(clause, data);
            return resp;
        }
    }
}
