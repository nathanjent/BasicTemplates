using System;

namespace Basic.Templates
{
#if (Internal)
    internal interface Basic
#elif (Public)
    public interface Basic
#endif
    {
    }
}
