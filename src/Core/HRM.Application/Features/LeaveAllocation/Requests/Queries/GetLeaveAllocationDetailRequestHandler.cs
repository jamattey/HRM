using System;
using System.Collections.Generic;
using System.Text;
using MediatR; 
using HRM.Application.DTOs;
using HRM.Application.DTOs.LeaveRequest;

namespace HRM.Application.DTOs.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailRequestHandler : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}