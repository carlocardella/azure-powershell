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

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskDiskEncryptionKey", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDisk))]
    public partial class SetAzureRmDiskDiskEncryptionKeyCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSDisk Disk { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string SecretUrl { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string SourceVaultId { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("Disk", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            if (this.MyInvocation.BoundParameters.ContainsKey("SecretUrl"))
            {
                // EncryptionSettings
                if (this.Disk.EncryptionSettings == null)
                {
                    this.Disk.EncryptionSettings = new EncryptionSettings();
                }
                // DiskEncryptionKey
                if (this.Disk.EncryptionSettings.DiskEncryptionKey == null)
                {
                    this.Disk.EncryptionSettings.DiskEncryptionKey = new KeyVaultAndSecretReference();
                }
                this.Disk.EncryptionSettings.DiskEncryptionKey.SecretUrl = this.SecretUrl;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("SourceVaultId"))
            {
                // EncryptionSettings
                if (this.Disk.EncryptionSettings == null)
                {
                    this.Disk.EncryptionSettings = new EncryptionSettings();
                }
                // DiskEncryptionKey
                if (this.Disk.EncryptionSettings.DiskEncryptionKey == null)
                {
                    this.Disk.EncryptionSettings.DiskEncryptionKey = new KeyVaultAndSecretReference();
                }
                // SourceVault
                if (this.Disk.EncryptionSettings.DiskEncryptionKey.SourceVault == null)
                {
                    this.Disk.EncryptionSettings.DiskEncryptionKey.SourceVault = new SourceVault();
                }
                this.Disk.EncryptionSettings.DiskEncryptionKey.SourceVault.Id = this.SourceVaultId;
            }

            WriteObject(this.Disk);
        }
    }
}
