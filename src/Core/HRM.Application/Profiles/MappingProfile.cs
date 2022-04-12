using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile(Parameters)
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>.ReverseMap();
        }
    }
}