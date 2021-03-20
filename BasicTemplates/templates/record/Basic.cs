using System;

namespace Basic.Templates
{
#if (Internal)
    internal record Basic
#endif
#if (InternalAbstract)
    internal abstract record Basic
#endif
#if (InternalSealed)
    internal sealed record Basic
#endif
#if (Public)
    public record Basic
#endif
#if (PublicAbstract)
    public abstract record Basic
#endif
#if (PublicSealed)
    public sealed record Basic
#endif
#if (Protected)
    protected record Basic
#endif
#if (ProtectedAbstract)
    protected abstract record Basic
#endif
#if (ProtectedInternal)
    protected internal record Basic
#endif
#if (ProtectedInternalAbstract)
    protected internal abstract record Basic
#endif
#if (PrivateProtected)
    private protected record Basic
#endif
#if (PrivateProtectedAbstract)
    private protected abstract record Basic
#endif
    {
    }
}
