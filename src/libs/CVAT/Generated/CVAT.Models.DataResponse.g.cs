#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataResponse : global::System.IEquatable<DataResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.RqId? RqId { get; init; }
#else
        public global::CVAT.RqId? RqId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RqId))]
#endif
        public bool IsRqId => RqId != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? DataResponseVariant2 { get; init; }
#else
        public byte[]? DataResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataResponseVariant2))]
#endif
        public bool IsDataResponseVariant2 => DataResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataResponse(global::CVAT.RqId value) => new DataResponse((global::CVAT.RqId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CVAT.RqId?(DataResponse @this) => @this.RqId;

        /// <summary>
        /// 
        /// </summary>
        public DataResponse(global::CVAT.RqId? value)
        {
            RqId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataResponse(byte[] value) => new DataResponse((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(DataResponse @this) => @this.DataResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DataResponse(byte[]? value)
        {
            DataResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataResponse(
            global::CVAT.RqId? rqId,
            byte[]? dataResponseVariant2
            )
        {
            RqId = rqId;
            DataResponseVariant2 = dataResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DataResponseVariant2 as object ??
            RqId as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RqId?.ToString() ??
            DataResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRqId && !IsDataResponseVariant2 || !IsRqId && IsDataResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CVAT.RqId?, TResult>? rqId = null,
            global::System.Func<byte[]?, TResult>? dataResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRqId && rqId != null)
            {
                return rqId(RqId!);
            }
            else if (IsDataResponseVariant2 && dataResponseVariant2 != null)
            {
                return dataResponseVariant2(DataResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::CVAT.RqId?>? rqId = null,
            global::System.Action<byte[]?>? dataResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRqId)
            {
                rqId?.Invoke(RqId!);
            }
            else if (IsDataResponseVariant2)
            {
                dataResponseVariant2?.Invoke(DataResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RqId,
                typeof(global::CVAT.RqId),
                DataResponseVariant2,
                typeof(byte[]),
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
        public bool Equals(DataResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CVAT.RqId?>.Default.Equals(RqId, other.RqId) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(DataResponseVariant2, other.DataResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataResponse obj1, DataResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataResponse obj1, DataResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataResponse o && Equals(o);
        }
    }
}
