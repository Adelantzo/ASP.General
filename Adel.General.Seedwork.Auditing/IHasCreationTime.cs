using System;

namespace Adel.Asp.General.Auditing
{
    public interface IHasCreationTime
    {
        DateTime? CreationTime { get; }
    }
}