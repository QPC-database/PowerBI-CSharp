// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The identity the generated token should reflect
    /// </summary>
    public partial class EffectiveIdentity
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveIdentity class.
        /// </summary>
        public EffectiveIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveIdentity class.
        /// </summary>
        /// <param name="username">The effective username reflected by a token
        /// for applying RLS rules (username can be composed of alpha-numerical
        /// characters or any of the following characters  '.', '-', '_', '!',
        /// '#', '^', '~', '\', '@', username cannot contain spaces and must be
        /// up to 256 characters)</param>
        /// <param name="datasets">An array of datasets for which this identity
        /// applies</param>
        /// <param name="roles">An array of roles reflected by a token when
        /// applying RLS rules (identity can contain up to 50 roles, role can
        /// be composed of any character besides ',' and must be up to 50
        /// characters)</param>
        /// <param name="customData">The value of customdata to be used for
        /// applying RLS rules. Only supported for live connections to Azure
        /// Analysis Services.</param>
        public EffectiveIdentity(string username, IList<string> datasets, IList<string> roles = default(IList<string>), string customData = default(string))
        {
            Username = username;
            Roles = roles;
            Datasets = datasets;
            CustomData = customData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the effective username reflected by a token for
        /// applying RLS rules (username can be composed of alpha-numerical
        /// characters or any of the following characters  '.', '-', '_', '!',
        /// '#', '^', '~', '\', '@', username cannot contain spaces and must be
        /// up to 256 characters)
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets an array of roles reflected by a token when applying
        /// RLS rules (identity can contain up to 50 roles, role can be
        /// composed of any character besides ',' and must be up to 50
        /// characters)
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Gets or sets an array of datasets for which this identity applies
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<string> Datasets { get; set; }

        /// <summary>
        /// Gets or sets the value of customdata to be used for applying RLS
        /// rules. Only supported for live connections to Azure Analysis
        /// Services.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (Datasets == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Datasets");
            }
        }
    }
}
