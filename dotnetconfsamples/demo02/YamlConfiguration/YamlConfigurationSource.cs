﻿using Microsoft.Extensions.Configuration;

namespace demo02
{
    /// <summary>
    /// yaml配置源
    /// </summary>
    public class YamlConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new YamlConfigurationProvider(this);
        }
    }
}
