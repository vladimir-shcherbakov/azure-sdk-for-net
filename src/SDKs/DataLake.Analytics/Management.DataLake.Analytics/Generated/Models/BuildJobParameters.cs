// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to build a new Data Lake Analytics job.
    /// </summary>
    public partial class BuildJobParameters : BaseJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the BuildJobParameters class.
        /// </summary>
        public BuildJobParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildJobParameters class.
        /// </summary>
        /// <param name="type">the job type of the current job (Hive or USql).
        /// Possible values include: 'USql', 'Hive'</param>
        /// <param name="properties">the job specific properties.</param>
        /// <param name="name">the friendly name of the job to build.</param>
        public BuildJobParameters(JobType type, CreateJobProperties properties, string name = default(string))
            : base(type, properties)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name of the job to build.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
