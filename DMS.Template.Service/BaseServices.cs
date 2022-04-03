using DMS.Repository;

namespace DMS.Template.Service
{
    public class BaseService<T> : BaseRepository<T> where T : class, new()
    { }

}
