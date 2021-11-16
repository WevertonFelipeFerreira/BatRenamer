using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
