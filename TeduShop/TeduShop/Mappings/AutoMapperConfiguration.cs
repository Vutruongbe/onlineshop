﻿using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Models;
using TeduShop.Web.Models;

namespace TeduShop.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();

            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            Mapper.CreateMap<Footer, FooterViewModel>();
            Mapper.CreateMap<Slide, SlideViewModel>();
            Mapper.CreateMap<Page, PageViewModel>();
        }
    }
}