﻿// The FinderOuter
// Copyright (c) 2020 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

using Autarkysoft.Bitcoin.Cryptography.Asymmetric.EllipticCurve;
using System;
using System.Numerics;

namespace FinderOuter.Services.Comparers
{
    /// <summary>
    /// Converts private key to address using only compressed public key
    /// </summary>
    public class PrvToAddrCompComparer : PrvToAddrBase
    {
        public override bool Compare(in EllipticCurvePoint point)
        {
            byte[] xBytes = point.X.ToByteArray(true, true);
            byte[] toHash = new byte[33];
            toHash[0] = point.Y.IsEven ? (byte)2 : (byte)3;
            Buffer.BlockCopy(xBytes, 0, toHash, 33 - xBytes.Length, xBytes.Length);

            ReadOnlySpan<byte> compHash = hash160.Compress33(toHash);
            return compHash.SequenceEqual(hash);
        }
    }
}
