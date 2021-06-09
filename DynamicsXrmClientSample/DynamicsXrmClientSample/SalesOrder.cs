using DynamicsXrmClient.Attributes;
using System;
using System.Text.Json.Serialization;

namespace DynamicsXrmClientSample
{
    [DataverseTable("salesorder", "salesorders")]
    public class SalesOrder
    {
        [DataverseRowId]
        [JsonPropertyName("salesorderid")]
        public Guid Id { get; set; }

        [JsonPropertyName("new_estimatedeffort_number")]
        public int EstimatedEffort { get; set; }
    }
}
