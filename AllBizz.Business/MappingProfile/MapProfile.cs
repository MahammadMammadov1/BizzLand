using AllBizz.Business.DTOs.ServiceDtos;
using AllBizz.Business.DTOs.SliderDtos;
using AllBizz.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBizz.Business.MappingProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Slider, SliderGetDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();

            CreateMap<Services, ServiceGetDto>().ReverseMap();
            CreateMap<Services, ServiceCreateDto>().ReverseMap();
            CreateMap<Services, ServiceUpdateDto>().ReverseMap();


        }

    }
}
