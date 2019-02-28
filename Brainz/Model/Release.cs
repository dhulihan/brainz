﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var releaseResponse = ReleaseResponse.FromJson(jsonString);

namespace Brainz.Release
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ReleaseResponse
    {
        [JsonProperty("release-offset")]
        public long ReleaseOffset { get; set; }

        [JsonProperty("releases")]
        public Release[] Releases { get; set; }

        [JsonProperty("release-count")]
        public long ReleaseCount { get; set; }
    }

    public partial class Release
    {
        [JsonProperty("packaging-id")]
        public Guid? PackagingId { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("status-id")]
        public Guid? StatusId { get; set; }

        [JsonProperty("disambiguation")]
        public string Disambiguation { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("packaging")]
        public string Packaging { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("release-events")]
        public ReleaseEvent[] ReleaseEvents { get; set; }

        [JsonProperty("cover-art-archive")]
        public CoverArtArchive CoverArtArchive { get; set; }

        [JsonProperty("text-representation")]
        public TextRepresentation TextRepresentation { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("media")]
        public Media[] Media { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public partial class CoverArtArchive
    {
        [JsonProperty("artwork")]
        public bool Artwork { get; set; }

        [JsonProperty("front")]
        public bool Front { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("back")]
        public bool Back { get; set; }

        [JsonProperty("darkened")]
        public bool Darkened { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("format-id")]
        public Guid? FormatId { get; set; }

        [JsonProperty("track-count")]
        public long TrackCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public partial class ReleaseEvent
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("area")]
        public Area Area { get; set; }
    }

    public partial class Area
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sort-name")]
        public string SortName { get; set; }

        [JsonProperty("iso-3166-1-codes")]
        public string[] Iso31661Codes { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("disambiguation")]
        public string Disambiguation { get; set; }
    }

    public partial class TextRepresentation
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }
    }
}