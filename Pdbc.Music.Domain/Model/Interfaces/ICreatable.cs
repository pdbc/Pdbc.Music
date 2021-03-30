using System;

namespace Pdbc.Music.Domain.Model
{
    public interface ICreatable
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedOn { get; set; }
    }
}