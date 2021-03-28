using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class DummyDatabaseConnectionException : Exception
    {
        public DummyDatabaseConnectionException(string message) : base(message)
        {

        }
    }
}
