// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealLearningKitRubeGoldTarget : TargetRules
{
	public UnrealLearningKitRubeGoldTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "UnrealLearningKitRubeGold" } );
	}
}
