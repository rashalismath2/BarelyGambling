using System;
using System.Collections.Generic;
using System.Text;

namespace BarelyGambling.Core.Exceptions
{
    public class FileSizeExceededException:Exception
    {
        public FileSizeExceededException()
        {

        }
        public FileSizeExceededException(string message):base(message)
        {

        }
    }
}
