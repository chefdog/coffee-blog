﻿using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
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

        public async Task<List<ImageDataTransferModel>> GetMany(int start, int skip, int max)
        {
            var result = await loadTempData();
            return result;
        }

        public Task<ImageDataTransferModel> Remove(ImageDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ImageDataTransferModel>> Search(ImageDataTransferModel dto, int start, int skip, int max)
        {
            var result = await loadTempData();
            return result;
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

        private async Task<List<ImageDataTransferModel>> loadTempData() {
            List<ImageDataTransferModel> result = new List<ImageDataTransferModel>() {
                new ImageDataTransferModel {
                    Id = 1,
                    Created = DateTime.Now,
                    FileName = "../../assets/images/slider/20160409_131415000_iOS.jpg",
                    LastModified = DateTime.Now,
                    Title = "SCEA Training",
                    Description = "mijn fantastische omschrijving"
                },
                new ImageDataTransferModel {
                    Id = 2,
                    Created = DateTime.Now,
                    FileName = "../../assets/images/slider/20160409_131734000_iOS.jpg",
                    LastModified = DateTime.Now,
                    Title = "SCEA Training 02",
                    Description = "mijn fantastische omschrijving 2"
                },
                new ImageDataTransferModel {
                    Id = 3,
                    Created = DateTime.Now,
                    FileName = "../../assets/images/slider/20160409_132142000_iOS.jpg",
                    LastModified = DateTime.Now,
                    Title = "SCEA Training 03",
                    Description = "mijn fantastische omschrijving 3"
                }
            };
            await Task.Delay(500);
            return result;
        }
    }
}
