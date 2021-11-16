using System;

namespace BatRenamer.Models.Exceptions
{
    public class IncorrectFolderException : Exception
    {
        public IncorrectFolderException() : base()
        {

        }
        public IncorrectFolderException(string message) : base(message)
        {
        }
    }
}
