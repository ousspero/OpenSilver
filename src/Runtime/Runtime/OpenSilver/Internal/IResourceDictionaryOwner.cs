﻿
/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/

using System.Windows;

namespace OpenSilver.Internal;

internal interface IResourceDictionaryOwner
{
    void SetResources(ResourceDictionary resourceDictionary);

    void OnResourcesChange(ResourcesChangeInfo info, bool shouldInvalidate, bool hasImplicitStyles);
}