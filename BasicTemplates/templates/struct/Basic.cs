using System;

namespace Basic.Templates
{
#if (Internal)
    internal struct Basic
#elif (Public)
    public struct Basic
#endif
    {
    }
}
