﻿using CoffeeBlog.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.BlogService
{
    public class ArticleRepository : IRepository
    {
        private CbDbContext dbContext;
        public ArticleRepository(CbDbContext cbDbContext) {
            dbContext = cbDbContext;
        }

        public async Task<IModel> AddAsync(IModel entity)
        {
            throw new NotImplementedException();
        }

        Task<List<IModel>> IRepository.AddRangeAsync(List<IModel> data)
        {
            throw new NotImplementedException();
        }

        Task<IModel> IRepository.DeleteAsync(IModel changes)
        {
            throw new NotImplementedException();
        }

        Task<IModel> IRepository.GetAsync(IModel entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<IModel> IRepository.GetMany(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        Task<IModel> IRepository.UpdateAsync(IModel changes)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~BlogRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
