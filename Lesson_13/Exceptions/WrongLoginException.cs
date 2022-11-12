using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13.Exceptions
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException() { }
        public WrongLoginException(string message) : base(message) { }
    }
}
