//********************************* bs::framework - Copyright 2018-2019 Marko Pintera ************************************//
//*********** Licensed under the MIT license. See LICENSE.md for full terms. This notice is not to be removed. ***********//
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if IS_B3D
namespace BansheeEngine
#else
namespace bs
#endif
{
	/** @addtogroup GUI
	 *  @{
	 */

	/// <summary>Specifies how is text horizontally aligned within its bounds.</summary>
	public enum TextHorzAlign
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	/** @} */
}
