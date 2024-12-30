using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Entities.Concrete;

namespace MultiShop.Catalog.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping() 
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();

        }
    }
}
