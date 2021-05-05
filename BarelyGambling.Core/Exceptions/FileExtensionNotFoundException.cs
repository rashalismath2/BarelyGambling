using System;
using System.Collections.Generic;
using System.Text;

namespace BarelyGambling.Core.Exceptions
{
    public class FileExtensionNotFoundException : Exception
    {
        public FileExtensionNotFoundException()
        {

        }
        public FileExtensionNotFoundException(string message):base(message)
        {

        }
    }
}
