using System;

namespace Basic.Templates
{
#if (Public)
    public struct Basic
#endif
#if (Protected)
    protected struct Basic
#endif
#if (Internal)
    internal struct Basic
#endif
#if (ProtectedInternal)
    protected internal struct Basic
#endif
#if (PrivateProtected)
    private protected struct Basic
#endif
    {
    }
}
