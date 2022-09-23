using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Commands
{
    public record AddCoursesCommand(CourseDetails coursedetails):IRequest<Unit>;
    
}
