// Copyright (C) 2024, The Duplicati Team
// https://duplicati.com, hello@duplicati.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

namespace Duplicati.Server.Serialization.Interface
{
    /// <summary>
    /// Gets all server settings
    /// </summary>
    public interface IServerSettings
    {
        /// <summary>
        /// The backend modules known by the server
        /// </summary>
        IDynamicModule[] BackendModules { get; }
        /// <summary>
        /// The encryption modules known by the server
        /// </summary>
        IDynamicModule[] EncryptionModules { get; }
        /// <summary>
        /// The compression modules known by the server
        /// </summary>
        IDynamicModule[] CompressionModules { get; }
        /// <summary>
        /// The generic modules known by the server
        /// </summary>
        IDynamicModule[] GenericModules { get; }

        /// <summary>
        /// The filters that are applied to all backups
        /// </summary>
        IFilter[] Filters { get; }
        /// <summary>
        /// The settings applied to all backups by default
        /// </summary>
        ISetting[] Settings { get; }
    }
}

