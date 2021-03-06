// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel
{
    /// <summary>
    /// Specifies whether the property this attribute is bound to
    /// is read-only or read/write.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class ReadOnlyAttribute : Attribute
    {
        /// <summary>
        /// Specifies that the property this attribute is bound to is read-only and
        /// cannot be modified in the server explorer.
        /// This <see langword='static'/> field is read-only.
        /// </summary>
        public static readonly ReadOnlyAttribute Yes = new ReadOnlyAttribute(true);

        /// <summary>
        /// Specifies that the property this attribute is bound to is read/write and can
        /// be modified at design time. This <see langword='static'/> field is read-only.
        /// </summary>
        public static readonly ReadOnlyAttribute No = new ReadOnlyAttribute(false);

        /// <summary>
        /// Specifies the default value for the <see cref='System.ComponentModel.ReadOnlyAttribute'/>,
        /// which is <see cref='System.ComponentModel.ReadOnlyAttribute.No'/>, that is, the
        /// property this attribute is bound to is read/write.
        /// This <see langword='static'/> field is read-only.
        /// </summary>
        public static readonly ReadOnlyAttribute Default = No;

        /// <summary>
        /// Initializes a new instance of the <see cref='System.ComponentModel.ReadOnlyAttribute'/> class.
        /// </summary>
        public ReadOnlyAttribute(bool isReadOnly) => IsReadOnly = isReadOnly;

        /// <summary>
        /// Gets a value indicating whether the property this attribute is bound to is
        /// read-only.
        /// </summary>
        public bool IsReadOnly { get; }

        public override bool Equals(object value)
        {
            if (this == value)
            {
                return true;
            }

            ReadOnlyAttribute other = value as ReadOnlyAttribute;
            return other?.IsReadOnly == IsReadOnly;
        }

        public override int GetHashCode() => base.GetHashCode();

        public override bool IsDefaultAttribute() => IsReadOnly == Default.IsReadOnly;
    }
}
