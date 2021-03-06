using System;
using System.Collections.Generic;


namespace NativeCodeSharp.Intrinsics
{
    /// <summary>
    /// Structure with information on SIMD instructions available on CPU.
    /// </summary>
    public struct CpuSimdFeature
        : ICloneable, IEquatable<CpuSimdFeature>
    {
        #region Private variables
        /// <summary>
        /// SIMD flag value.
        /// </summary>
        private CpuSimdFeatureFlag _simdFlagValue;
        #endregion

        #region Properties
        /// <summary>
        /// MMX is available or not.
        /// </summary>
        public bool HasMmx
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Mmx) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Mmx) : (_simdFlagValue & ~CpuSimdFeatureFlag.Mmx);
            }
        }
        /// <summary>
        /// SSE is available or not.
        /// </summary>
        public bool HasSse
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse);
            }
        }
        /// <summary>
        /// SSE2 is available or not.
        /// </summary>
        public bool HasSse2
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse2) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse2) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse2);
            }
        }
        /// <summary>
        /// SSE3 is available or not.
        /// </summary>
        public bool HasSse3
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse3) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse3) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse3);
            }
        }
        /// <summary>
        /// SSSE3 is available or not.
        /// </summary>
        public bool HasSsse3
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Ssse3) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Ssse3) : (_simdFlagValue & ~CpuSimdFeatureFlag.Ssse3);
            }
        }
        /// <summary>
        /// SSE4.1 is available or not.
        /// </summary>
        public bool HasSse41
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse41) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse41) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse41);
            }
        }
        /// <summary>
        /// SSE4.2 is available or not.
        /// </summary>
        public bool HasSse42
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse42) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse42) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse42);
            }
        }
        /// <summary>
        /// AES is available or not.
        /// </summary>
        public bool HasAes
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Aes) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Aes) : (_simdFlagValue & ~CpuSimdFeatureFlag.Aes);
            }
        }
        /// <summary>
        /// SSE4A is available or not.
        /// </summary>
        public bool HasSse4a
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Sse4a) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Sse4a) : (_simdFlagValue & ~CpuSimdFeatureFlag.Sse4a);
            }
        }
        /// <summary>
        /// AVX is available or not.
        /// </summary>
        public bool HasAvx
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx);
            }
        }
        /// <summary>
        /// AVX2 is available or not.
        /// </summary>
        public bool HasAvx2
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx2) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx2) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx2);
            }
        }
        /// <summary>
        /// FMA is available or not.
        /// </summary>
        public bool HasFma
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Fma) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Fma) : (_simdFlagValue & ~CpuSimdFeatureFlag.Fma);
            }
        }
        /// <summary>
        /// AVX-512F is available or not.
        /// </summary>
        public bool HasAvx512F
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512F) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512F) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512F);
            }
        }
        /// <summary>
        /// AVX-512BW is available or not.
        /// </summary>
        public bool HasAvx512Bw
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Bw) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Bw) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Bw);
            }
        }
        /// <summary>
        /// AVX-512CD is available or not.
        /// </summary>
        public bool HasAvx512Cd
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Cd) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Cd) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Cd);
            }
        }
        /// <summary>
        /// AVX-512DQ is available or not.
        /// </summary>
        public bool HasAvx512Dq
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Dq) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Dq) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Dq);
            }
        }
        /// <summary>
        /// AVX-512ER is available or not.
        /// </summary>
        public bool HasAvx512Er
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Er) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Er) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Er);
            }
        }
        /// <summary>
        /// AVX-512IFMA52 is available or not.
        /// </summary>
        public bool HasAvx512Ifma52
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Ifma52) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Ifma52) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Ifma52);
            }
        }
        /// <summary>
        /// AVX-512PF is available or not.
        /// </summary>
        public bool HasAvx512Pf
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Pf) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Pf) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Pf);
            }
        }
        /// <summary>
        /// AVX-512VL is available or not.
        /// </summary>
        public bool HasAvx512Vl
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Vl) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Vl) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Vl);
            }
        }
        /// <summary>
        /// AVX-512POPCNTDQ is available or not.
        /// </summary>
        public bool HasAvx512Vpopcntdq
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Vpopcntdq) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Vpopcntdq) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Vpopcntdq);
            }
        }
        /// <summary>
        /// AVX-512_4FMAPS is available or not.
        /// </summary>
        public bool HasAvx512_4fmaps
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512_4fmaps) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512_4fmaps) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512_4fmaps);
            }
        }
        /// <summary>
        /// AVX-512_4VNNIW is available or not.
        /// </summary>
        public bool HasAvx512_4vnniw
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512_4vnniw) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512_4vnniw) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512_4vnniw);
            }
        }
        /// <summary>
        /// AVX-512_BITALG is available or not.
        /// </summary>
        public bool HasAvx512Bitalg
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Bitalg) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Bitalg) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Bitalg);
            }
        }
        /// <summary>
        /// AVX-512_VBMI is available or not.
        /// </summary>
        public bool HasAvx512Vbmi
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Vbmi) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Vbmi) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Vbmi);
            }
        }
        /// <summary>
        /// AVX-512_VBMI2 is available or not.
        /// </summary>
        public bool HasAvx512Vbmi2
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Vbmi2) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Vbmi2) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Vbmi2);
            }
        }
        /// <summary>
        /// AVX-512_VNNI2 is available or not.
        /// </summary>
        public bool HasAvx512Vnni
        {
            get { return (_simdFlagValue & CpuSimdFeatureFlag.Avx512Vnni) != 0; }
            internal set
            {
                _simdFlagValue = value ? (_simdFlagValue | CpuSimdFeatureFlag.Avx512Vnni) : (_simdFlagValue & ~CpuSimdFeatureFlag.Avx512Vnni);
            }
        }
        #endregion

        #region public methods
        /// <summary>
        /// Get supported commma-separated SIMD instruction string.
        /// </summary>
        /// <returns>Supported commma-separated SIMD instruction string, ex) "MMX, SSE, SSE2".</returns>
        public override string ToString()
        {
            var list = new List<string>(27);

            if (HasMmx) list.Add("MMX");
            if (HasSse) list.Add("SSE");
            if (HasSse2) list.Add("SSE2");
            if (HasSse3) list.Add("SSE3");
            if (HasSsse3) list.Add("SSSE3");
            if (HasAes) list.Add("AES");
            if (HasSse41) list.Add("SSE4.1");
            if (HasSse42) list.Add("SSE4.2");
            if (HasSse4a) list.Add("SSE4A");
            if (HasAvx) list.Add("AVX");
            if (HasAvx2) list.Add("AVX2");
            if (HasFma) list.Add("FMA");
            if (HasAvx512F) list.Add("AVX-512F");
            if (HasAvx512Bw) list.Add("AVX-512BW");
            if (HasAvx512Cd) list.Add("AVX-512CD");
            if (HasAvx512Dq) list.Add("AVX-512DQ");
            if (HasAvx512Er) list.Add("AVX-512ER");
            if (HasAvx512Ifma52) list.Add("AVX-512IFMA52");
            if (HasAvx512Pf) list.Add("AVX-512PF");
            if (HasAvx512Vl) list.Add("AVX-512VL");
            if (HasAvx512Vpopcntdq) list.Add("AVX-512VPOPCNTDQ");
            if (HasAvx512_4fmaps) list.Add("AVX-512_4FMAPS");
            if (HasAvx512_4vnniw) list.Add("AVX-512_4VNNIW");
            if (HasAvx512Bitalg) list.Add("AVX-512_BITALG");
            if (HasAvx512Vbmi) list.Add("AVX-512_VBMI");
            if (HasAvx512Vbmi2) list.Add("AVX-512_VBMI2");
            if (HasAvx512Vnni) list.Add("AVX-512_VNNI");

            return string.Join(", ", list);
        }

        /// <summary>
        /// Check if given object is equivalent to this object.
        /// </summary>
        /// <param name="obj">An object to compare</param>
        /// <returns>Return <c>true</c> if <paramref name="obj"/> is an object equivalent to this object, otherwise <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj != null && obj is CpuSimdFeature feature && Equals(feature);
        }

        /// <summary>
        /// Compure hash code of this object.
        /// </summary>
        /// <returns>The has code of this object.</returns>
        public override int GetHashCode()
        {
            return _simdFlagValue.GetHashCode();
        }

        /// <summary>
        /// 
        /// Check if given object is equivalent to this object.
        /// </summary>
        /// <param name="obj">An object to compare</param>
        /// <returns>Return <c>true</c> if <paramref name="obj"/> is an object equivalent to this object, otherwise <c>false</c>.</returns>
        public bool Equals(CpuSimdFeature obj)
        {
            return _simdFlagValue == obj._simdFlagValue;
        }

        /// <summary>
        /// Clone this object.
        /// </summary>
        /// <returns>A clone of this object.</returns>
        public object Clone()
        {
            return new CpuSimdFeature()
            {
                _simdFlagValue = _simdFlagValue
            };
        }
        #endregion
    }

    /// <summary>
    /// Flag enum for SIMD features
    /// </summary>
    [Flags]
    public enum CpuSimdFeatureFlag : int
    {
        /// <summary>
        /// A flag bit which indicates MMX is available or not.
        /// </summary>
        Mmx = 0x00000001,
        /// <summary>
        /// A flag bit which indicates SSE is available or not.
        /// </summary>
        Sse = 0x00000002,
        /// <summary>
        /// A flag bit which indicates SSE2 is available or not.
        /// </summary>
        Sse2 = 0x00000004,
        /// <summary>
        /// A flag bit which indicates SSE3 is available or not.
        /// </summary>
        Sse3 = 0x00000008,
        /// <summary>
        /// A flag bit which indicates SSSE3 is available or not.
        /// </summary>
        Ssse3 = 0x00000010,
        /// <summary>
        /// A flag bit which indicates SSE4.1 is available or not.
        /// </summary>
        Sse41 = 0x00000020,
        /// <summary>
        /// A flag bit which indicates SSE4.2 is available or not.
        /// </summary>
        Sse42 = 0x00000040,
        /// <summary>
        /// A flag bit which indicates AES is available or not.
        /// </summary>
        Aes = 0x00000080,
        /// <summary>
        /// A flag bit which indicates SSE4A is available or not.
        /// </summary>
        Sse4a = 0x00000100,
        /// <summary>
        /// A flag bit which indicates AVX is available or not.
        /// </summary>
        Avx = 0x00000200,
        /// <summary>
        /// A flag bit which indicates AVX2 is available or not.
        /// </summary>
        Avx2 = 0x00000400,
        /// <summary>
        /// A flag bit which indicates FMA is available or not.
        /// </summary>
        Fma = 0x00000800,
        /// <summary>
        /// A flag bit which indicates AVX-512F is available or not.
        /// </summary>
        Avx512F = 0x00001000,
        /// <summary>
        /// A flag bit which indicates AVX-512BW is available or not.
        /// </summary>
        Avx512Bw = 0x00002000,
        /// <summary>
        /// A flag bit which indicates AVX-512CD is available or not.
        /// </summary>
        Avx512Cd = 0x00004000,
        /// <summary>
        /// A flag bit which indicates AVX-512DQ is available or not.
        /// </summary>
        Avx512Dq = 0x00008000,
        /// <summary>
        /// A flag bit which indicates AVX-512ER is available or not.
        /// </summary>
        Avx512Er = 0x00010000,
        /// <summary>
        /// A flag bit which indicates AVX-512IFMA52 is available or not.
        /// </summary>
        Avx512Ifma52 = 0x00020000,
        /// <summary>
        /// A flag bit which indicates AVX-512PF is available or not.
        /// </summary>
        Avx512Pf = 0x00040000,
        /// <summary>
        /// A flag bit which indicates AVX-512VL is available or not.
        /// </summary>
        Avx512Vl = 0x00080000,
        /// <summary>
        /// A flag bit which indicates AVX-512POPCNTDQ is available or not.
        /// </summary>
        Avx512Vpopcntdq = 0x00100000,
        /// <summary>
        /// A flag bit which indicates AVX-512_4FMAPS is available or not.
        /// </summary>
        Avx512_4fmaps = 0x00200000,
        /// <summary>
        /// A flag bit which indicates AVX-512_4VNNIW is available or not.
        /// </summary>
        Avx512_4vnniw = 0x00400000,
        /// <summary>
        /// A flag bit which indicates AVX-512_BITALG is available or not.
        /// </summary>
        Avx512Bitalg = 0x00800000,
        /// <summary>
        /// A flag bit which indicates AVX-512_VBMI is available or not.
        /// </summary>
        Avx512Vbmi = 0x01000000,
        /// <summary>
        /// A flag bit which indicates AVX-512_VBMI2 is available or not.
        /// </summary>
        Avx512Vbmi2 = 0x02000000,
        /// <summary>
        /// A flag bit which indicates AVX-512_VNNI2 is available or not.
        /// </summary>
        Avx512Vnni = 0x04000000
    }
}
