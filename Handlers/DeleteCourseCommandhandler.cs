using CourseManagement.api.Commands;
using CourseManagement.core.Interfaces.Repositories;
using MediatR;

namespace CourseManagement.api.Handlers
{
    
   
    public class DeleteCourseCommandhandler : IRequestHandler<DeleteCourseCommand, Unit>
    {

        private readonly ICourseRepo courseRepo;

        public DeleteCourseCommandhandler(ICourseRepo courseRepo)
        {
            this.courseRepo = courseRepo;   
                
        }
        public async Task<Unit> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            await courseRepo.DeleteCourse(request.Id);
            return Unit.Value;
        }
    }
}
