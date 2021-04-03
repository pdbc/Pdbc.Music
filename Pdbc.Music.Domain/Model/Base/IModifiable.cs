using System;

namespace Pdbc.Music.Domain.Model
{
    public interface IModifiable
    {
        string ModifiedBy { get; set; }

        DateTimeOffset ModifiedOn { get; set; }
    }
}