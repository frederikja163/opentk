﻿using GeneratorV2.Data;
using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class Specification
    {
        public Dictionary<string, Api> Apis { get; } = new Dictionary<string, Api>();
        public Dictionary<string, Command> Commands { get; } = new Dictionary<string, Command>();
        public EnumEntryCollection Enums { get; } = new EnumEntryCollection();

        private Api GetOrCreateApi(string apiName)
        {
            if (!Apis.TryGetValue(apiName, out Api? value))
            {
                value = new Api(apiName);
                Apis.Add(apiName, value);
            }
            return value;
        }

        public void AddFeature(Feature feature)
        {
            Api orCreateApi = GetOrCreateApi(feature.Api);
            orCreateApi.AddEnums(feature);
            orCreateApi.Features.Add(feature);
        }

        public void AddExtension(Extension extension)
        {
            Api orCreateApi = GetOrCreateApi(extension.Api);
            orCreateApi.AddEnums(extension);
            orCreateApi.Extensions.AddExtension(extension);
        }
    }
}