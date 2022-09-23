using CourseManagement.api.Queries;
using CourseManagement.core.Interfaces.Repositories;
using CourseManagement.core.Models;
using MediatR;

namespace CourseManagement.api.Handlers
{
    public class GetCoursesHandler : IRequestHandler<GetCoursesQuery,IEnumerable<CourseDetails>>
    {
        private readonly ICourseRepo _courserepo;
        public GetCoursesHandler(ICourseRepo courseRepo)
        {
            _courserepo = courseRepo;   
            
        }

        public async Task<IEnumerable<CourseDetails>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        => await _courserepo.GetAllCourses();

        ////public List<CourseDetails> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        ////{
        ////    return _courserepo.GetAllCourses();
        ////}

        //Task<List<CourseDetails>> IRequestHandler<GetCoursesQuery, List<CourseDetails>>.Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        //{
        //    _courserepo.Get
        //}
        ////public <List<CourseDetails> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        ////    => await _courserepo.GetAllCourses();

    }
}
