using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.WebApi.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
