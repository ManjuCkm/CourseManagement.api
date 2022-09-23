using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Queries
{
    public record GetCourseByIdQuery(int Id):IRequest<CourseDetails>;
    
}
