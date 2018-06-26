// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight streaming activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightStreaming")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightStreamingActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightStreamingActivity class.
        /// </summary>
        public HDInsightStreamingActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightStreamingActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="mapper">Mapper executable name. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="reducer">Reducer executable name. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="input">Input blob path. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="output">Output blob path. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="filePaths">Paths to streaming job files. Can be
        /// directories.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="storageLinkedServices">Storage linked service
        /// references.</param>
        /// <param name="arguments">User specified arguments to
        /// HDInsightActivity.</param>
        /// <param name="getDebugInfo">Debug info option. Possible values
        /// include: 'None', 'Always', 'Failure'</param>
        /// <param name="fileLinkedService">Linked service reference where the
        /// files are located.</param>
        /// <param name="combiner">Combiner executable name. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="commandEnvironment">Command line environment
        /// values.</param>
        /// <param name="defines">Allows user to specify defines for streaming
        /// job request.</param>
        public HDInsightStreamingActivity(string name, object mapper, object reducer, object input, object output, IList<object> filePaths, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IDictionary<string, string> userProperties = default(IDictionary<string, string>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<LinkedServiceReference> storageLinkedServices = default(IList<LinkedServiceReference>), IList<object> arguments = default(IList<object>), string getDebugInfo = default(string), LinkedServiceReference fileLinkedService = default(LinkedServiceReference), object combiner = default(object), IList<object> commandEnvironment = default(IList<object>), IDictionary<string, object> defines = default(IDictionary<string, object>))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            Mapper = mapper;
            Reducer = reducer;
            Input = input;
            Output = output;
            FilePaths = filePaths;
            FileLinkedService = fileLinkedService;
            Combiner = combiner;
            CommandEnvironment = commandEnvironment;
            Defines = defines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets mapper executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mapper")]
        public object Mapper { get; set; }

        /// <summary>
        /// Gets or sets reducer executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.reducer")]
        public object Reducer { get; set; }

        /// <summary>
        /// Gets or sets input blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.input")]
        public object Input { get; set; }

        /// <summary>
        /// Gets or sets output blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.output")]
        public object Output { get; set; }

        /// <summary>
        /// Gets or sets paths to streaming job files. Can be directories.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.filePaths")]
        public IList<object> FilePaths { get; set; }

        /// <summary>
        /// Gets or sets linked service reference where the files are located.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fileLinkedService")]
        public LinkedServiceReference FileLinkedService { get; set; }

        /// <summary>
        /// Gets or sets combiner executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.combiner")]
        public object Combiner { get; set; }

        /// <summary>
        /// Gets or sets command line environment values.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.commandEnvironment")]
        public IList<object> CommandEnvironment { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for streaming job
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Mapper == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mapper");
            }
            if (Reducer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reducer");
            }
            if (Input == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Input");
            }
            if (Output == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Output");
            }
            if (FilePaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePaths");
            }
            if (StorageLinkedServices != null)
            {
                foreach (var element in StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (FileLinkedService != null)
            {
                FileLinkedService.Validate();
            }
        }
    }
}
