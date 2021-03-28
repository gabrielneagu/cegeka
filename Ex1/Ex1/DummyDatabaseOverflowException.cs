using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class DummyDatabaseOverflowException : Exception
    {
        public DummyDatabaseOverflowException(string message) : base(message)
        {

        }
    }
}
