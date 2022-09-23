using MediatR;

namespace CourseManagement.api.Commands
{
    public record DeleteCourseCommand(int Id):IRequest<Unit>;
    
}
