using UnrealBuildTool;

public class EchoOfTheLambClientTarget : TargetRules
{
	public EchoOfTheLambClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("EchoOfTheLamb");
	}
}
