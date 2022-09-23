using CourseManagement.api.Commands;
using CourseManagement.core.Interfaces.Repositories;
using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Handlers
{
    public class AddCoursesHandler : IRequestHandler<AddCoursesCommand, Unit>
    {
        private readonly ICourseRepo courseRepo;

        public AddCoursesHandler(ICourseRepo courseRepo)
        {
            this.courseRepo = courseRepo;   
        }
        public async Task<Unit> Handle(AddCoursesCommand request, CancellationToken cancellationToken)
        {
            await courseRepo.AddCourse(request.coursedetails);
            return Unit.Value;



           
        }
    }
}
