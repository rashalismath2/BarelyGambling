using System;
using System.Collections.Generic;
using System.Text;

namespace BarelyGambling.Core.Exceptions
{
    public class FileSavingToTheLocalStorageException : Exception
    {
        public FileSavingToTheLocalStorageException()
        {

        }
        public FileSavingToTheLocalStorageException(string message):base(message)
        {

        }
    }
}
