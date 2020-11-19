using System.Runtime.InteropServices.ComTypes;
using System;

namespace System.Daemon.Utils
{
    public class RuleException : Exception
    {
        public RuleException(string message) : base(message)
        {

        }
    }
}