namespace Adel.Asp.General.Auditing
{
    public interface IModificationAuditable<TUserKey>: IHasModificationTime
    {
        TUserKey? LastModifiedUserId { get; set; }
    }
}