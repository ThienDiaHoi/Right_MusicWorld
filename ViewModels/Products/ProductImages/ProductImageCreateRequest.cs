using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Products.ProductImages
{
    public class ProductImageCreateRequest
    {
        public IFormFile ImageFile { get; set; }
    }
}