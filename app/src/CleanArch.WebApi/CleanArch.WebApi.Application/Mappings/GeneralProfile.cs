using AutoMapper;
using CleanArch.WebApi.Application.Features.Products.Commands.CreateProduct;
using CleanArch.WebApi.Application.Features.Products.Queries.GetAllProducts;
using CleanArch.WebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.WebApi.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
