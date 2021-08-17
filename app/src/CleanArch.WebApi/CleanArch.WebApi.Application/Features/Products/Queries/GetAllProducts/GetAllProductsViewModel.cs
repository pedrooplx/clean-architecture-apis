﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.WebApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
