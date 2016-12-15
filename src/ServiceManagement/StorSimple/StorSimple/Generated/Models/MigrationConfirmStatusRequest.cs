// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// This class represents confirm migration request.
    /// </summary>
    public partial class MigrationConfirmStatusRequest
    {
        private IList<string> _dataContainerNameList;
        
        /// <summary>
        /// Required. Gets or sets the list of volume container names which
        /// needs to committed/rolled back
        /// </summary>
        public IList<string> DataContainerNameList
        {
            get { return this._dataContainerNameList; }
            set { this._dataContainerNameList = value; }
        }
        
        private MigrationOperation _operation;
        
        /// <summary>
        /// Required. Gets or sets the type of operation to be performed during
        /// confirm migration.
        /// </summary>
        public MigrationOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationConfirmStatusRequest
        /// class.
        /// </summary>
        public MigrationConfirmStatusRequest()
        {
            this.DataContainerNameList = new List<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationConfirmStatusRequest
        /// class with required arguments.
        /// </summary>
        public MigrationConfirmStatusRequest(List<string> dataContainerNameList, MigrationOperation operation)
            : this()
        {
            if (dataContainerNameList == null)
            {
                throw new ArgumentNullException("dataContainerNameList");
            }
            this.DataContainerNameList = dataContainerNameList;
            this.Operation = operation;
        }
    }
}