﻿using System.Collections.Generic;
using DragonLib.CLI;
using JetBrains.Annotations;
using UObject.Asset;
using UObject.Enum;

namespace UObject2JSON
{
    [PublicAPI]
    public class ProgramFlags : ICLIFlags
    {
        [UsedImplicitly]
        [CLIFlag("paths", Positional = 0, Category = "Program Arguments", Help = "Paths to load")]
        public List<string> Paths { get; set; } = new List<string>();

        [CLIFlag("output", Aliases = new[] { "o" }, Category = "Program Arguments", Help = "Folder to output JSON files to")]
        public string? OutputFolder { get; set; }

        [CLIFlag("workaround", Default = UnrealGame.None, Aliases = new[] { "w" }, Category = "Program Arguments", Help = "Game-specific workaround")]
        public UnrealGame Workaround { get; set; }

        [CLIFlag("changeset", Default = AssetFileOptions.LATEST_UNREAL_VERSION, Aliases = new[] { "c" }, Category = "Program Arguments", Help = "Unreal changeset to parse with if unspecified by the asset")]
        public int UnrealVersion { get; set; }
    }
}
