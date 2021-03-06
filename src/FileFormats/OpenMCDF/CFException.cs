/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 * 
 * The Original Code is OpenMCDF - Compound Document Format library.
 * 
 * The Initial Developer of the Original Code is Federico Blaseotto.*/

using System;
#if !NETSTANDARD1_6
using System.Runtime.Serialization;
#endif

namespace Workshell.FileFormats.OpenMCDF
{
    /// <inheritdoc />
    /// <summary>
    /// OpenMCDF base exception.
    /// </summary>
    [Serializable]
    internal class CFException : Exception
    {
        public CFException()
        {
        }

#if !NETSTANDARD1_6
        protected CFException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFException(string message)
            : base(message, null)
        {
        }

        public CFException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when a data setter/getter method is invoked
    /// on a stream or storage object after the disposal of the owner
    /// compound file object.
    /// </summary>
    [Serializable]
    internal class CFDisposedException : CFException
    {
        public CFDisposedException()
        {
        }

#if !NETSTANDARD1_6
        protected CFDisposedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFDisposedException(string message)
            : base(message, null)
        {
        }

        public CFDisposedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when opening a file with invalid header
    /// or not supported COM/OLE Structured storage version.
    /// </summary>
    [Serializable]
    internal class CFFileFormatException : CFException
    {
        public CFFileFormatException()
        {
        }

#if !NETSTANDARD1_6
        protected CFFileFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        public CFFileFormatException(string message)
            : base(message, null)
        {
        }

        public CFFileFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when a named stream or a storage object
    /// are not found in a parent storage.
    /// </summary>
    [Serializable]
    internal class CFItemNotFound : CFException
    {
#if !NETSTANDARD1_6
        protected CFItemNotFound(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFItemNotFound()
            : base("Entry not found")
        {
        }

        public CFItemNotFound(string message)
            : base(message, null)
        {
        }

        public CFItemNotFound(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when a method call is invalid for the current object state
    /// </summary>
    [Serializable]
    internal class CFInvalidOperation : CFException
    {
        public CFInvalidOperation()
        {
        }

#if !NETSTANDARD1_6
        protected CFInvalidOperation(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFInvalidOperation(string message)
            : base(message, null)
        {
        }

        public CFInvalidOperation(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when trying to add a duplicated CFItem
    /// </summary>
    /// <remarks>
    /// Items are compared by name as indicated by specs.
    /// Two items with the same name CANNOT be added within 
    /// the same storage or sub-storage. 
    /// </remarks>
    [Serializable]
    internal class CFDuplicatedItemException : CFException
    {
        public CFDuplicatedItemException()
        {
        }

#if !NETSTANDARD1_6
        protected CFDuplicatedItemException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFDuplicatedItemException(string message)
            : base(message, null)
        {
        }

        public CFDuplicatedItemException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Raised when trying to load a Compound File with invalid, corrupted or mismatched fields (4.1 - specifications) 
    /// </summary>
    /// <remarks>
    /// This exception is NOT raised when Compound file has been opened with NO_VALIDATION_EXCEPTION option.
    /// </remarks>
    [Serializable]
    internal class CFCorruptedFileException : CFException
    {
        public CFCorruptedFileException()
        {
        }

#if !NETSTANDARD1_6
        protected CFCorruptedFileException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        public CFCorruptedFileException(string message)
            : base(message, null)
        {
        }

        public CFCorruptedFileException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}