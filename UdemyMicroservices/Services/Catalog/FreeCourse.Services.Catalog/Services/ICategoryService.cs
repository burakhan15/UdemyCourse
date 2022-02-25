using AutoMapper;
using FreeCourse.Services.Catalog.Dto;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Services.Catalog.Settings;
using FreeCourse.Shared.Dtos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace FreeCourse.Services.Catalog.Services
{
    internal interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsnyc();
        Task<Response<CategoryDto>> CreateAsnyc(Category category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
