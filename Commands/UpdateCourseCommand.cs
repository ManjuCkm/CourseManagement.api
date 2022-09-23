using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Commands
{
    public record UpdateCourseCommand(CourseDetails coursedetails):IRequest<Unit>;
    
}
