﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using doLittle.Execution;

namespace doLittle.Entities
{
    /// <summary>
    /// Represents a null implementation of <see cref="IEntityContextConnection"/>
    /// </summary>
    public class NullEntityContextConnection : IEntityContextConnection
    {
#pragma warning disable 1591 // Xml Comments
        public void Initialize(IContainer container)
        {

        }
#pragma warning restore 1591 // Xml Comments
    }
}