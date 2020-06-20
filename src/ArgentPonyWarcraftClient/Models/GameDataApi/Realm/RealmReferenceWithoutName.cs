﻿using Newtonsoft.Json;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to a realm.
    /// </summary>
    public class RealmReferenceWithoutName
    {
        /// <summary>
        /// Gets the key for the realm.
        /// </summary>
        [JsonProperty("key")]
        public Self Key { get; set; }

        /// <summary>
        /// Gets the ID of the realm.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets a slug for the realm.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}