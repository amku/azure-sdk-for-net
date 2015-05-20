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
using Hyak.Common;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// The collection details.
    /// </summary>
    public partial class Collection
    {
        private ActiveDirectoryConfig _adInfo;
        
        /// <summary>
        /// Optional. The domain join details for this collection.
        /// </summary>
        public ActiveDirectoryConfig AdInfo
        {
            get { return this._adInfo; }
            set { this._adInfo = value; }
        }
        
        private string _customRdpProperty;
        
        /// <summary>
        /// Optional. Optional customer-defined RDP properties of the
        /// collection.
        /// </summary>
        public string CustomRdpProperty
        {
            get { return this._customRdpProperty; }
            set { this._customRdpProperty = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. The description of the collection.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IList<string> _dnsServers;
        
        /// <summary>
        /// Optional. List of the DNS Servers.
        /// </summary>
        public IList<string> DnsServers
        {
            get { return this._dnsServers; }
            set { this._dnsServers = value; }
        }
        
        private string _lastErrorCode;
        
        /// <summary>
        /// Optional. The last operation error code on this collection.
        /// </summary>
        public string LastErrorCode
        {
            get { return this._lastErrorCode; }
            set { this._lastErrorCode = value; }
        }
        
        private DateTime _lastModifiedTimeUtc;
        
        /// <summary>
        /// Optional. UTC Date time of the last modification of this collection.
        /// </summary>
        public DateTime LastModifiedTimeUtc
        {
            get { return this._lastModifiedTimeUtc; }
            set { this._lastModifiedTimeUtc = value; }
        }
        
        private int _maxSessions;
        
        /// <summary>
        /// Optional. The maximum number of concurrent users allowed for this
        /// collection.
        /// </summary>
        public int MaxSessions
        {
            get { return this._maxSessions; }
            set { this._maxSessions = value; }
        }
        
        private CollectionMode _mode;
        
        /// <summary>
        /// Optional. The collection mode.
        /// </summary>
        public CollectionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. The collection name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OfficeType _officeType;
        
        /// <summary>
        /// Optional. If the template image for this collection includes Office
        /// this will specify the type.
        /// </summary>
        public OfficeType OfficeType
        {
            get { return this._officeType; }
            set { this._officeType = value; }
        }
        
        private string _planName;
        
        /// <summary>
        /// Required. The plan name associated with this collection.
        /// </summary>
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }
        
        private bool _readyForPublishing;
        
        /// <summary>
        /// Optional. A flag denoting if this collection is ready for
        /// publishing operations.
        /// </summary>
        public bool ReadyForPublishing
        {
            get { return this._readyForPublishing; }
            set { this._readyForPublishing = value; }
        }
        
        private string _region;
        
        /// <summary>
        /// Optional. The region where the collection is deployed.
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }
        
        private int _sessionWarningThreshold;
        
        /// <summary>
        /// Optional. The end-user session limit warning threshold.  Reaching
        /// or crossing this threshold will cause a capacity warning message
        /// to be shown in the management portal.
        /// </summary>
        public int SessionWarningThreshold
        {
            get { return this._sessionWarningThreshold; }
            set { this._sessionWarningThreshold = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. The collection status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _subnetName;
        
        /// <summary>
        /// Optional. The subnet name of the customer created Azure VNet.
        /// </summary>
        public string SubnetName
        {
            get { return this._subnetName; }
            set { this._subnetName = value; }
        }
        
        private string _templateImageName;
        
        /// <summary>
        /// Optional. The name of the template image associated with this
        /// collection.
        /// </summary>
        public string TemplateImageName
        {
            get { return this._templateImageName; }
            set { this._templateImageName = value; }
        }
        
        private bool _trialOnly;
        
        /// <summary>
        /// Optional. Trial-only collections can be used only during the trial
        /// period of your subscription. When the trial expires or you
        /// activate your subscription, these collections will be permanently
        /// disabled.
        /// </summary>
        public bool TrialOnly
        {
            get { return this._trialOnly; }
            set { this._trialOnly = value; }
        }
        
        private CollectionType _type;
        
        /// <summary>
        /// Optional. The collection type.
        /// </summary>
        public CollectionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _vNetName;
        
        /// <summary>
        /// Optional. The VNet name associated with this collection.
        /// </summary>
        public string VNetName
        {
            get { return this._vNetName; }
            set { this._vNetName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Collection class.
        /// </summary>
        public Collection()
        {
            this.DnsServers = new LazyList<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the Collection class with required
        /// arguments.
        /// </summary>
        public Collection(string name, string planName)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (planName == null)
            {
                throw new ArgumentNullException("planName");
            }
            this.Name = name;
            this.PlanName = planName;
        }
    }
}
