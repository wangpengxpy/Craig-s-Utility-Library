﻿/*
Copyright (c) 2013 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Xml.Serialization;
using Utilities.DataTypes;
using Utilities.DataTypes.DataMapper;
using Utilities.DataTypes.Dynamic.Interfaces;
#endregion

namespace Utilities.DataTypes.Dynamic.BaseClasses
{
    /// <summary>
    /// Dynamo extension base class
    /// </summary>
    public abstract class DynamoExtensionBase : IDynamoExtension
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected DynamoExtensionBase()
        {
        }

        /// <summary>
        /// Extends the given dynamo object
        /// </summary>
        /// <param name="Object">Object to extend</param>
        public abstract void Extend(Dynamo Object);
    }
}