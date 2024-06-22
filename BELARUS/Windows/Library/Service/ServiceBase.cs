using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace BELARUS.Service
{
    public abstract class ServiceBase<T> where T : class
    {
        #region Properties

        private BELARUS.Data.Entities _Context = null;
        private readonly IDbSet<T> dbSet;

        protected BELARUS.Data.Entities DbContext
        {
            get { return _Context; }
        }

        protected ServiceBase()
        {
            _Context = new BELARUS.Data.Entities();
            var internalContext = _Context.GetType().GetProperty("InternalContext", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_Context);
            var providerName = (string)internalContext.GetType().GetProperty("ProviderName").GetValue(internalContext);
            var configuration = new BELARUS.Data.Migrations.Configuration()
            {
                TargetDatabase = new DbConnectionInfo(_Context.Database.Connection.ConnectionString, providerName)
            };
            var migrator = new System.Data.Entity.Migrations.DbMigrator(configuration);
            var _historyRepository = migrator.GetType().GetField("_historyRepository", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(migrator);
            var _existingConnection = _historyRepository.GetType().BaseType.GetField("_existingConnection", BindingFlags.Instance | BindingFlags.NonPublic);
            if (_existingConnection != null)
            {
                _existingConnection.SetValue(_historyRepository, null);
            }
            migrator.Update();
            dbSet = _Context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Clone(T entity)
        {
            dbSet.Add(entity);
            _Context.Entry(entity).State = EntityState.Added;
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual void Create(T entity)
        {
            Add(entity);
        }

        public virtual void Commit()
        {
            try
            {
                _Context.SaveChanges();
            }
            catch (OptimisticConcurrencyException)
            {
                ((IObjectContextAdapter)_Context).ObjectContext.Refresh(RefreshMode.ClientWins, dbSet);
                _Context.SaveChanges();
            }
            catch
            {

            }
        }
        #endregion Properties
    }
}