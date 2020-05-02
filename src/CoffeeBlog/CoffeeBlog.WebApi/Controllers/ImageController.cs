using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IBusinessService<ImageDataTransferModel> imageService;
        public ImageController(IBusinessService<ImageDataTransferModel> imageService) {
            this.imageService = imageService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync(List<IFormFile> files)
        {
            var response = new ListResultResponse<ImageDataTransferModel>();
            try
            {
                ImageDataTransferModel dto = null;
                List<ImageDataTransferModel> result = new List<ImageDataTransferModel>();
                long size = files.Sum(f => f.Length);
                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        dto = new ImageDataTransferModel();
                        dto.FileName = Path.GetTempFileName();
                        result.Add(await imageService.Create(dto));
                    }
                }

                response.Model = result;
                response.Message = $"Total of records: {response.Model.Count()}";
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return response.ToHttpResponse();
        }
    }
}