// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class FirewallRuleListResult
    {
        internal static FirewallRuleListResult DeserializeFirewallRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<FirewallRule>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FirewallRule> array = new List<FirewallRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallRule.DeserializeFirewallRule(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new FirewallRuleListResult(Optional.ToList(value));
        }
    }
}
