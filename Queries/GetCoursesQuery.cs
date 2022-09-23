using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Queries
{
    public record GetCoursesQuery:IRequest<IEnumerable<CourseDetails>>;

    
}
