using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WatchStore.Models;

namespace WatchStore.DAL
{
    public class WatchRepository : IWatchRepository
    {
        private WatchContext _context;

        public WatchRepository(WatchContext watchContext)
        {
            this._context = watchContext;
        }

        #region Watch

        public IEnumerable<Watch> GetWatchs()
        {
            return _context.Watchs.ToList();
        }

        public Watch GetWatchByID(int watchID)
        {
            return _context.Watchs.Find(watchID);
        }

        public void InsertWatch(Watch watch)
        {
            _context.Watchs.Add(watch);
        }

        public void DeleteWatch(int watchID)
        {
            Watch watch = _context.Watchs.Find(watchID);
            _context.Watchs.Remove(watch);
        }

        public void UpdateWatch(Watch watch)
        {
            _context.Entry(watch).State = EntityState.Modified;
        }
        #endregion

        #region Collection
        public IEnumerable<Collection> GetCollection()
        {
            return _context.Collections.ToList();
        }

        public Collection GetCollectionID(int collectionID)
        {
            return _context.Collections.Find(collectionID);
        }

        public void InsertCollection(Collection collection)
        {
            _context.Collections.Add(collection);
        }

        public void DeleteCollection(int collectionID)
        {
            Collection collection = _context.Collections.Find(collectionID);
            _context.Collections.Remove(collection);
        }

        public void UpdateCollection(Collection collection)
        {
            _context.Entry(collection).State = EntityState.Modified;
        }

        #endregion


        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}