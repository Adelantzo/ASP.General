namespace Adel.Asp.General.Auditing
{
    public interface IAuditable<TUserKey>: ICreationAuditable<TUserKey>, IModificationAuditable<TUserKey>
    {
        
    }
}