﻿/*
  Copyright (C) 2007-2015 Jeroen Frijters
  Copyright (C) 2009 Volker Berlin (i-net software)

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Jeroen Frijters
  jeroen@frijters.net
  
*/
using System;

namespace IKVM.Java.Externs.sun.misc
{

    static class Perf
	{

		public static object attach(object thisPerf, string user, int lvmid, int mode)
		{
			throw new NotImplementedException();
		}

		public static void detach(object thisPerf, object bb)
		{
			throw new NotImplementedException();
		}

		public static object createLong(object thisPerf, string name, int variability, int units, long value)
		{
#if FIRST_PASS
			return null;
#else
			return global::java.nio.ByteBuffer.allocate(8);
#endif
		}

		public static object createByteArray(object thisPerf, string name, int variability, int units, byte[] value, int maxLength)
		{
#if FIRST_PASS
			return null;
#else
			return global::java.nio.ByteBuffer.allocate(maxLength).put(value);
#endif
		}

		public static long highResCounter(object thisPerf)
		{
			throw new NotImplementedException();
		}

		public static long highResFrequency(object thisPerf)
		{
			throw new NotImplementedException();
		}

		public static void registerNatives()
		{

		}

	}

}