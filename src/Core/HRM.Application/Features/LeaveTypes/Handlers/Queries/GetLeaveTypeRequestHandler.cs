using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HRM.Application.Features.LeaveTypes.Requests;
using HRM.Application.Persistence.Contracts;
using HRM.Application.DTOs;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;


namespace HRM.Application.Features.LeaveTypes.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public GetLeaveTypeRequestHandler(ILeaveTypeRepository leavetypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }
        public Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken CancellationToken)
        {
            throw new NotImplementedException(); 
        }
    }
}