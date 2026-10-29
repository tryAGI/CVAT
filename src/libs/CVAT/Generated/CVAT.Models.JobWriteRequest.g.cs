#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct JobWriteRequest : global::System.IEquatable<JobWriteRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.JobWriteRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.GroundTruthJobCreateRequest? GroundTruth { get; init; }
#else
        public global::CVAT.GroundTruthJobCreateRequest? GroundTruth { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GroundTruth))]
#endif
        public bool IsGroundTruth => GroundTruth != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGroundTruth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CVAT.GroundTruthJobCreateRequest? value)
        {
            value = GroundTruth;
            return IsGroundTruth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CVAT.GroundTruthJobCreateRequest PickGroundTruth() => GroundTruth is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GroundTruth' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.ReplicaJobCreateRequest? Replica { get; init; }
#else
        public global::CVAT.ReplicaJobCreateRequest? Replica { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Replica))]
#endif
        public bool IsReplica => Replica != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReplica(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CVAT.ReplicaJobCreateRequest? value)
        {
            value = Replica;
            return IsReplica;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CVAT.ReplicaJobCreateRequest PickReplica() => Replica is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Replica' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator JobWriteRequest(global::CVAT.GroundTruthJobCreateRequest value) => new JobWriteRequest((global::CVAT.GroundTruthJobCreateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CVAT.GroundTruthJobCreateRequest?(JobWriteRequest @this) => @this.GroundTruth;

        /// <summary>
        ///
        /// </summary>
        public JobWriteRequest(global::CVAT.GroundTruthJobCreateRequest? value)
        {
            GroundTruth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JobWriteRequest FromGroundTruth(global::CVAT.GroundTruthJobCreateRequest? value) => new JobWriteRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JobWriteRequest(global::CVAT.ReplicaJobCreateRequest value) => new JobWriteRequest((global::CVAT.ReplicaJobCreateRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CVAT.ReplicaJobCreateRequest?(JobWriteRequest @this) => @this.Replica;

        /// <summary>
        ///
        /// </summary>
        public JobWriteRequest(global::CVAT.ReplicaJobCreateRequest? value)
        {
            Replica = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JobWriteRequest FromReplica(global::CVAT.ReplicaJobCreateRequest? value) => new JobWriteRequest(value);

        /// <summary>
        ///
        /// </summary>
        public JobWriteRequest(
            global::CVAT.JobWriteRequestDiscriminatorType? type,
            global::CVAT.GroundTruthJobCreateRequest? groundTruth,
            global::CVAT.ReplicaJobCreateRequest? replica
            )
        {
            Type = type;

            GroundTruth = groundTruth;
            Replica = replica;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Replica as object ??
            GroundTruth as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GroundTruth?.ToString() ??
            Replica?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGroundTruth && !IsReplica || !IsGroundTruth && IsReplica;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CVAT.GroundTruthJobCreateRequest, TResult>? groundTruth = null,
            global::System.Func<global::CVAT.ReplicaJobCreateRequest, TResult>? replica = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroundTruth is { } __value0 && groundTruth != null)
            {
                return groundTruth(__value0);
            }
            else if (Replica is { } __value1 && replica != null)
            {
                return replica(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CVAT.GroundTruthJobCreateRequest>? groundTruth = null,

            global::System.Action<global::CVAT.ReplicaJobCreateRequest>? replica = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroundTruth is { } __value0)
            {
                groundTruth?.Invoke(__value0);
            }
            else if (Replica is { } __value1)
            {
                replica?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CVAT.GroundTruthJobCreateRequest>? groundTruth = null,
            global::System.Action<global::CVAT.ReplicaJobCreateRequest>? replica = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GroundTruth is { } __value0)
            {
                groundTruth?.Invoke(__value0);
            }
            else if (Replica is { } __value1)
            {
                replica?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GroundTruth,
                typeof(global::CVAT.GroundTruthJobCreateRequest),
                Replica,
                typeof(global::CVAT.ReplicaJobCreateRequest),
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
        public bool Equals(JobWriteRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CVAT.GroundTruthJobCreateRequest?>.Default.Equals(GroundTruth, other.GroundTruth) &&
                global::System.Collections.Generic.EqualityComparer<global::CVAT.ReplicaJobCreateRequest?>.Default.Equals(Replica, other.Replica)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(JobWriteRequest obj1, JobWriteRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobWriteRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(JobWriteRequest obj1, JobWriteRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobWriteRequest o && Equals(o);
        }
    }
}
