using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SystemTextJson
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<QueryAutocompleteResponse>(myJsonResponse);
    public class QueryAutocompleteResponse
    {
        public List<Predictions> Predictions { get; set; }
        public string Status { get; set; }
    }

    public class Predictions
    {
        public string Description { get; set; }
        public List<MainTextMatchedSubstrings> MatchedSubstrings { get; set; }
        public StructuredFormatting StructuredFormatting { get; set; }
        public List<Terms> Terms { get; set; }
    }

    public class StructuredFormatting
    {
        public string MainText { get; set; }
        public List<MainTextMatchedSubstrings> MainTextMatchedSubstrings { get; set; }
        public string SecondaryText { get; set; }
        public List<MainTextMatchedSubstrings> SecondaryTextMatchedSubstrings { get; set; }
    }

    public class MainTextMatchedSubstrings
    {
        public int Length { get; set; }
        public int Offset { get; set; }
    }

    public class Terms
    {
        public int Offset { get; set; }
        public string Value { get; set; }
    }
}