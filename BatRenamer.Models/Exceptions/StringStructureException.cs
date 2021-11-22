using System;

namespace BatRenamer.Models.Exceptions
{
    public class StringStructureException : FormatException
    {
        public StringStructureException() : base() 
        {
   
        }
        public StringStructureException(string message) : base(message) 
        {
        }
    }
}
