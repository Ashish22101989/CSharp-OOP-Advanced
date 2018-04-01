using Logger.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Interfaces
{
    public interface IAppender : ILevelable
    {
        ILayout Layout { get; }

        void Append(IError error);
    }
}
