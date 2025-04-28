using UnrealBuildTool;

public class EchoOfTheLambTarget : TargetRules
{
	public EchoOfTheLambTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("EchoOfTheLamb");
	}
}
