using System;

namespace BatRenamer.Exceptions
{
    class StringStructureException : FormatException
    {
        public StringStructureException() : base() 
        {
   
        }
        public StringStructureException(string message) : base(message) 
        {
        }
    }
}
