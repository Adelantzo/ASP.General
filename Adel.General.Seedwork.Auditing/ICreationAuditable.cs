namespace Adel.Asp.General.Auditing
{
    public interface ICreationAuditable<TUserKey>: IHasCreationTime
    {
        TUserKey? CreatedUserId { get; set; }
    }
}