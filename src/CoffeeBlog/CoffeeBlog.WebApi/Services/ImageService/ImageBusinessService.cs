using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.ImageService
{
    public class ImageBusinessService : IBusinessService<ImageDataTransferModel>
    {
        static CloudBlobClient blobClient;
        const string blobContainerName = "webappstoragedotnet-imagecontainer";
        static CloudBlobContainer blobContainer;

        public ImageBusinessService(IOptions<AppSettings> options) { 
        
        }
        public async Task<ImageDataTransferModel> Create(ImageDataTransferModel dto)
        {
            CloudBlockBlob blob = blobContainer.GetBlockBlobReference(GetRandomBlobName(dto.FileName));
            await blob.UploadFromFileAsync(dto.FileName);
            return dto;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<ImageDataTransferModel> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDataTransferModel>> GetMany(int start, int skip, int max)
        {
            throw new NotImplementedException();
        }

        public Task<ImageDataTransferModel> Remove(ImageDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDataTransferModel>> Search(ImageDataTransferModel dto, int start, int skip, int max)
        {
            throw new NotImplementedException();
        }

        public Task<ImageDataTransferModel> Update(ImageDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        private string GetRandomBlobName(string filename)
        {
            string ext = Path.GetExtension(filename);
            return string.Format("{0:10}_{1}{2}", DateTime.Now.Ticks, Guid.NewGuid(), ext);
        }
    }
}
