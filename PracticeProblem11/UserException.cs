using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblem11
{
    class UserException: Exception
    {
        public UserException()
        {

        }
        public UserException(string message)
        : base(message)
        {
        }
    }
}
