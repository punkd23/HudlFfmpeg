﻿using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.Resources.BaseTypes;
using Hudl.Ffmpeg.Settings.BaseTypes;

namespace Hudl.Ffmpeg.Settings
{
    [AppliesToResource(Type = typeof(IVideo))]
    [AppliesToResource(Type = typeof(IAudio))]
    [SettingsApplication(PreDeclaration = true, ResourceType = SettingsCollectionResourceType.Output)]
    public class MapChapters : BaseSetting
    {
        private const string SettingType = "-map_chapters";

        public MapChapters(int index)
            : base(SettingType)
        {
            Index = index;
        }

        public int Index { get; set; }

        public override string ToString()
        {
            return string.Concat(Type, " ", Index);
        }
    }
}