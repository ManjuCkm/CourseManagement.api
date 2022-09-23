using CourseManagement.api.Queries;
using CourseManagement.core.Interfaces.Repositories;
using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Handlers
{
    public class GetCourseByIdHandler : IRequestHandler<GetCourseByIdQuery, CourseDetails>
    {
        private readonly ICourseRepo _courserepo;
        public GetCourseByIdHandler(ICourseRepo courseRepo)
        {
            _courserepo = courseRepo;   
                
        }
        public async Task<CourseDetails>Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
        {
          return  await _courserepo.GetCourseById(request.Id);
            
        }
    }
}
