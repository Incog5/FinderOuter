﻿// The FinderOuter
// Copyright (c) 2020 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

using Autarkysoft.Bitcoin.Cryptography.Asymmetric.EllipticCurve;
using FinderOuter.Backend.Cryptography.Hashing;
using System;
using System.Numerics;

namespace FinderOuter.Services.Comparers
{
    public abstract class PrvToAddrBase : ICompareService, IDisposable
    {
        protected readonly BigInteger order = new SecP256k1().N;
        protected readonly EllipticCurveCalculator calc = new EllipticCurveCalculator();
        protected byte[] hash;
        protected readonly Hash160 hash160 = new Hash160();

        public virtual bool Init(string address)
        {
            AddressService serv = new AddressService();
            return serv.CheckAndGetHash(address, out hash);
        }

        public bool Compare(byte[] key)
        {
            BigInteger kVal = new BigInteger(key, true, true);
            if (kVal >= order || kVal == 0)
            {
                return false;
            }
            return Compare(kVal);
        }

        public bool Compare(BigInteger key) => Compare(calc.MultiplyByG(key));

        public abstract bool Compare(in EllipticCurvePoint point);

        public void Dispose() => hash160.Dispose();
    }
}
