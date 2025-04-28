using UnrealBuildTool;

public class EchoOfTheLambEditorTarget : TargetRules
{
	public EchoOfTheLambEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("EchoOfTheLamb");
	}
}
