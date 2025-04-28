using UnrealBuildTool;

public class EchoOfTheLambServerTarget : TargetRules
{
	public EchoOfTheLambServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("EchoOfTheLamb");
	}
}
