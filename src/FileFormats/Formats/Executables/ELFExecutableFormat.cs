﻿#region License
//  Copyright(c) 2018, Workshell Ltd
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Workshell.FileFormats.Formats.Executables
{
    public enum ELFImageFormat : byte
    {
        _32Bit,
        _64Bit
    }

    public enum ELFImageEndianness : byte
    {
        Little,
        Big
    }

    public class ELFExecutableFormat : ExecutableFormat
    {
        private static string[] _contentTypes => new string[0];
        private static string[] _extensions => new[] { "axf", "bin", "elf", "o", "prx", "puff", "ko", "mod", "so" };

        internal ELFExecutableFormat(ELFImageFormat format, ELFImageEndianness endianness) : base(_contentTypes, _extensions)
        {
            Format = format;
            Endianness = endianness;
        }

        #region Properties

        public override int SortIndex => 20;
        public ELFImageFormat Format { get; }
        public ELFImageEndianness Endianness { get; }

        #endregion
    }
}
