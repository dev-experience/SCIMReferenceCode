﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.SCIM
{
    using System.Runtime.Serialization;

    [DataContract]
    public sealed class Feature : FeatureBase
    {
        public Feature(bool supported)
        {
            this.Supported = supported;
        }
    }
}