using Application.Common;
using Microsoft.AspNetCore.Http;
using MusicWorld.Models;
using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Products.ProductImages;

namespace Application.Products
{
    public class ProductService : IProductService
    {
        private readonly MusicDbContext _context;
        private readonly IStorageService _storageService;

        public ProductService(MusicDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> CreateProduct(int productId, ProductImageCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImage(int imageId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}