using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRM.Domain;
using HRM.Application.DTOs;
using HRM.Application.DTOs.LeaveRequest;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>.ReverseMap();
        }
    }
}