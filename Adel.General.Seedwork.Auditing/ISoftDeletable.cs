namespace Adel.Asp.General.Auditing
{
    public interface ISoftDeletable
    {
        bool IsActive { get; set; }
    }
}