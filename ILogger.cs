using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    interface ILogger
    {
        void WriteInfo(String message);

        void WriteException(String exceptionMessage)
            => WriteInfo($"Exception : {exceptionMessage}");
    }
}
