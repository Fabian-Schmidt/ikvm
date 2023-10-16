﻿/*
  Copyright (C) 2007-2013 Jeroen Frijters
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

namespace IKVM.Java.Externs.java.util.prefs
{

	static class FileSystemPreferences
	{
		public static int chmod(string filename, int permission)
		{
			// TODO
			return 0;
		}

		public static int[] lockFile0(string filename, int permission, bool shared)
		{
			// TODO
			return new int[] { 1, 0 };
		}

		public static int unlockFile0(int fd)
		{
			// TODO
			return 0;
		}

	}

}