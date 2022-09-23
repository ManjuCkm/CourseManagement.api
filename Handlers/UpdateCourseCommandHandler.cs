using CourseManagement.api.Commands;
using CourseManagement.core.Interfaces.Repositories;
using MediatR;

namespace CourseManagement.api.Handlers
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
    {
        private readonly ICourseRepo _courserepo;
        public UpdateCourseCommandHandler(ICourseRepo courserepo)
        {
            _courserepo = courserepo;
        }
    
        public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            await _courserepo.UpdateCourse(request.coursedetails);
            return Unit.Value;
        }
    }
}
