using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Models;
using TeduShop.Web.Models;

namespace TeduShop.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Post, PostViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Tag, TagViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'

#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Product, ProductViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Footer, FooterViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Slide, SlideViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<Page, PageViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
#pragma warning disable CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'
            Mapper.CreateMap<ContactDetail, ContactDetailViewModel>();
#pragma warning restore CS0618 // 'Mapper.CreateMap<TSource, TDestination>()' is obsolete: 'Dynamically creating maps will be removed in version 5.0. Use a MapperConfiguration instance and store statically as needed, or Mapper.Initialize. Use CreateMapper to create a mapper instance.'

        }
    }
}