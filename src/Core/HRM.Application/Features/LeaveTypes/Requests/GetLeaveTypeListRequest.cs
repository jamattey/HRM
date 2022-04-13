using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace HRM.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        
    }
}