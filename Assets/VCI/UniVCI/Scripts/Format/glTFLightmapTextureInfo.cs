﻿using System;
using VCIGLTF;

namespace VCI
{
    [Serializable]
    public sealed class glTFLightmapTextureInfo : glTFTextureInfo
    {
        public override glTFTextureTypes TextureType => glTFTextureTypes.Unknown;

        public glTFLightmapTextureInfo()
        {
            base.texCoord = 1;
        }
    }
}
