using System;
using System.Collections.Generic;
using WatchStore.Models;

namespace WatchStore.DAL
{
    public interface IWatchRepository : IDisposable
    {
        #region Watch
        IEnumerable<Watch> GetWatchs();
        Watch GetWatchByID(int watchID);
        void InsertWatch(Watch watch);
        void DeleteWatch(int watchID);
        void UpdateWatch(Watch watch);
        #endregion

        #region Collection
        IEnumerable<Collection> GetCollection();
        Collection GetCollectionID(int collectionID);
        void InsertCollection(Collection collection);
        void DeleteCollection(int collectionID);
        void UpdateCollection(Collection collection);
        #endregion

        void Save();

    }

}