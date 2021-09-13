using System;

namespace Adel.Asp.General.Auditing
{
    public interface IHasDeletionTime
    {
        DateTime? DeletedTime { get; set; }
    }
}