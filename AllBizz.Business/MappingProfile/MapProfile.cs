using AllBizz.Business.DTOs.MemberDtos;
using AllBizz.Business.DTOs.ProfessionDtos;
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

            CreateMap<MemberCreateDto, Member>().ReverseMap();
            CreateMap<MemberUpdateDto, Member>().ReverseMap();
            CreateMap<MemberGetDto, Member>().ReverseMap();

            CreateMap<ProfessionCreateDto, Profession>().ReverseMap();
            CreateMap<ProfessionGetDto, Profession>().ReverseMap();
            CreateMap<ProfessionUpdateDto, Profession>().ReverseMap();

        }

    }
}
