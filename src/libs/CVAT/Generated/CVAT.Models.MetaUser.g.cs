#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetaUser : global::System.IEquatable<MetaUser>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.User? User { get; init; }
#else
        public global::CVAT.User? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.BasicUser? Basic { get; init; }
#else
        public global::CVAT.BasicUser? Basic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Basic))]
#endif
        public bool IsBasic => Basic != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetaUser(global::CVAT.User value) => new MetaUser((global::CVAT.User?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CVAT.User?(MetaUser @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public MetaUser(global::CVAT.User? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetaUser(global::CVAT.BasicUser value) => new MetaUser((global::CVAT.BasicUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CVAT.BasicUser?(MetaUser @this) => @this.Basic;

        /// <summary>
        /// 
        /// </summary>
        public MetaUser(global::CVAT.BasicUser? value)
        {
            Basic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MetaUser(
            global::CVAT.User? user,
            global::CVAT.BasicUser? basic
            )
        {
            User = user;
            Basic = basic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Basic as object ??
            User as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Basic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUser || IsBasic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CVAT.User?, TResult>? user = null,
            global::System.Func<global::CVAT.BasicUser?, TResult>? basic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsBasic && basic != null)
            {
                return basic(Basic!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::CVAT.User?>? user = null,
            global::System.Action<global::CVAT.BasicUser?>? basic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsBasic)
            {
                basic?.Invoke(Basic!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::CVAT.User),
                Basic,
                typeof(global::CVAT.BasicUser),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MetaUser other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CVAT.User?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::CVAT.BasicUser?>.Default.Equals(Basic, other.Basic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetaUser obj1, MetaUser obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetaUser>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetaUser obj1, MetaUser obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetaUser o && Equals(o);
        }
    }
}
