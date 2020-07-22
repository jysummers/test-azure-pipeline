using System;

namespace Tester
{
    public class Module
    {
        public void Run()
        {
            throw new InvalidOperationException("This is only a test.");
        }
    }
}
