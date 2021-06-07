using TimeTrackingApp.Domain.Interfaces;

namespace TimeTrackingApp.Domain.Classes
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract void GetInfo();
    }
}
