/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information on the resource.
    /// </summary>
    public partial class Resource
    {
        private string _id;
        private string _name;
        private ResourceDataContainer _resourceDataContainer;

        /// <summary>
        /// Gets and sets the property Id. Resource Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. A descriptive resource name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDataContainer. A container of data for all resource
        /// types.
        /// </summary>
        public ResourceDataContainer ResourceDataContainer
        {
            get { return this._resourceDataContainer; }
            set { this._resourceDataContainer = value; }
        }

        // Check to see if ResourceDataContainer property is set
        internal bool IsSetResourceDataContainer()
        {
            return this._resourceDataContainer != null;
        }

    }
}