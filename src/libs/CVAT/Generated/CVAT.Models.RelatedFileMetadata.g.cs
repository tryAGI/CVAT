#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RelatedFileMetadata : global::System.IEquatable<RelatedFileMetadata>
    {
        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedFileMetadataDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.FileMetadata? File { get; init; }
#else
        public global::CVAT.FileMetadata? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CVAT.FileMetadata? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CVAT.FileMetadata PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CVAT.RelatedImageMetadata? RelatedImage { get; init; }
#else
        public global::CVAT.RelatedImageMetadata? RelatedImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RelatedImage))]
#endif
        public bool IsRelatedImage => RelatedImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRelatedImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CVAT.RelatedImageMetadata? value)
        {
            value = RelatedImage;
            return IsRelatedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CVAT.RelatedImageMetadata PickRelatedImage() => RelatedImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RelatedImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RelatedFileMetadata(global::CVAT.FileMetadata value) => new RelatedFileMetadata((global::CVAT.FileMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CVAT.FileMetadata?(RelatedFileMetadata @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public RelatedFileMetadata(global::CVAT.FileMetadata? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RelatedFileMetadata FromFile(global::CVAT.FileMetadata? value) => new RelatedFileMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RelatedFileMetadata(global::CVAT.RelatedImageMetadata value) => new RelatedFileMetadata((global::CVAT.RelatedImageMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CVAT.RelatedImageMetadata?(RelatedFileMetadata @this) => @this.RelatedImage;

        /// <summary>
        ///
        /// </summary>
        public RelatedFileMetadata(global::CVAT.RelatedImageMetadata? value)
        {
            RelatedImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RelatedFileMetadata FromRelatedImage(global::CVAT.RelatedImageMetadata? value) => new RelatedFileMetadata(value);

        /// <summary>
        ///
        /// </summary>
        public RelatedFileMetadata(
            global::CVAT.RelatedFileMetadataDiscriminatorType? type,
            global::CVAT.FileMetadata? file,
            global::CVAT.RelatedImageMetadata? relatedImage
            )
        {
            Type = type;

            File = file;
            RelatedImage = relatedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RelatedImage as object ??
            File as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            RelatedImage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsRelatedImage || !IsFile && IsRelatedImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CVAT.FileMetadata, TResult>? file = null,
            global::System.Func<global::CVAT.RelatedImageMetadata, TResult>? relatedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0 && file != null)
            {
                return file(__value0);
            }
            else if (RelatedImage is { } __value1 && relatedImage != null)
            {
                return relatedImage(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CVAT.FileMetadata>? file = null,

            global::System.Action<global::CVAT.RelatedImageMetadata>? relatedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0)
            {
                file?.Invoke(__value0);
            }
            else if (RelatedImage is { } __value1)
            {
                relatedImage?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CVAT.FileMetadata>? file = null,
            global::System.Action<global::CVAT.RelatedImageMetadata>? relatedImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (File is { } __value0)
            {
                file?.Invoke(__value0);
            }
            else if (RelatedImage is { } __value1)
            {
                relatedImage?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::CVAT.FileMetadata),
                RelatedImage,
                typeof(global::CVAT.RelatedImageMetadata),
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
        public bool Equals(RelatedFileMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CVAT.FileMetadata?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::CVAT.RelatedImageMetadata?>.Default.Equals(RelatedImage, other.RelatedImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RelatedFileMetadata obj1, RelatedFileMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RelatedFileMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RelatedFileMetadata obj1, RelatedFileMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RelatedFileMetadata o && Equals(o);
        }
    }
}
