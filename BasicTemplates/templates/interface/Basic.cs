using System;

namespace Basic.Templates
{
#if (Public)
    public interface Basic
#endif
#if (Internal)
    internal interface Basic
#endif
    {
    }
}
