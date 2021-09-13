namespace Adel.Asp.General.Auditing
{
    public interface IDeletionAuditable<TUserKey>:IHasDeletionTime, ISoftDeletable
    {
        TUserKey DeletedUserId { get; set; }
    }
}