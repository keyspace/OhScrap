using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class Settings : GameParameters.CustomParameterNode
    {
        // title is the left side,

        public override string Section { get { return "#OHS-modname"; } }
        public override string DisplaySection { get { return "#OHS-modname"; } }
        public override string Title { get { return "#OHS-set-title-1"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 1; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-set-alt", toolTip = "#OHS-set-alt-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool AlternatorFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-ant", toolTip = "#OHS-set-ant-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool AntennaFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-bat", toolTip = "#OHS-set-bat-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool BatteryFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-cnt", toolTip = "#OHS-set-cnt-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool ControlSurfaceFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-eng", toolTip = "#OHS-set-eng-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool EngineFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-gea", toolTip = "#OHS-set-gea-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool LandingGearFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-par", toolTip = "#OHS-set-par-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool ParachuteFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-rcs", toolTip = "#OHS-set-rcs-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool RCSFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-rws", toolTip = "#OHS-set-rws-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool ReactionWheelFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-tnk", toolTip = "#OHS-set-tnk-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool TankFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-sol", toolTip = "#OHS-set-sol-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool SolarPanelFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-srb", toolTip = "#OHS-set-srb-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool SRBFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-lit", toolTip = "#OHS-set-lit-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool LightFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-dcp", toolTip = "#OHS-set-dcp-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool DecouplerFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-lcp", toolTip = "#OHS-set-lcp-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool LaunchClampFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-set-cool", toolTip = "#OHS-set-cool-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool EngineCoolantModuleAllowed = true;

    }

    class OhScrapSettings : GameParameters.CustomParameterNode
    {
        // title is the section title side,
        public override string Section { get { return "#OHS-modname"; } }
        public override string DisplaySection { get { return "#OHS-modname"; } }
        public override string Title { get { return "#OHS-set-title-2"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 2; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-set-warn", toolTip = "#OHS-set-warn-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool safetyWarning = true;

        [GameParameters.CustomParameterUI("#OHS-set-highlight", toolTip = "#OHS-set-highlight-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool highlightFailures = true;

        [GameParameters.CustomParameterUI("#OHS-set-warp", toolTip = "#OHS-set-warp-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool stopOnFailure = true;

        [GameParameters.CustomParameterUI("#OHS-set-recovery", toolTip = "#OHS-set-recovery-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool overrideStageRecovery = false;

        [GameParameters.CustomParameterUI("#OHS-set-paw", toolTip = "#OHS-set-paw-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool coloredPAW = true;

        [GameParameters.CustomParameterUI("#OHS-set-snd", toolTip = "#OHS-set-snd-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool audibleAlarms = true;

        [GameParameters.CustomIntParameterUI("#OHS-set-snd-clip", minValue = 0, maxValue = 5, stepSize = 1, toolTip = "#OHS-set-snd-clip-tt")]
        public int soundClip = 0;

        [GameParameters.CustomFloatParameterUI("#OHS-set-snd-vol",
                                                toolTip = "#OHS-set-snd-vol-tt",
                                                asPercentage = false,
                                                minValue = 0f,
                                                maxValue = 1f,
                                                displayFormat = "F2",
                                                stepCount = 1)]
        public float soundVolume = 0.75f;

        [GameParameters.CustomParameterUI("#OHS-set-qt", toolTip = "#OHS-set-qt-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool quietMode = false;

        [GameParameters.CustomParameterUI("#OHS-set-Parts", toolTip = "#OHS-set-Parts-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool requireParts = false;
    }
    class DebugSettings : GameParameters.CustomParameterNode
    {
        // title is the section title side,
        public override string Section { get { return "#OHS-modname"; } }
        public override string DisplaySection { get { return "#OHS-modname"; } }
        public override string Title { get { return "#OHS-set-title-3"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 3; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-set-log", toolTip = "#OHS-set-log-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool logging = false;

        [GameParameters.CustomParameterUI("#OHS-set-deb", toolTip = "#OHS-set-deb-tt", newGameOnly = false, unlockedDuringMission = true)]
        public bool debugMenu = true;

        [GameParameters.CustomParameterUI("OhScrap(UPFM) v: " + Version.Text)]
        public bool thrsowaway = false;
    }
    //class DebugSettings2 : GameParameters.CustomParameterNode
    //{
    //    // title is the section title side,
    //    public override string Section { get { return "#OHS-modname"; } }
    //    public override string DisplaySection { get { return "#OHS-modname"; } }
    //    public override string Title { get { return "#OHS-set-title-4"; } }

    //    public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
    //    public override int SectionOrder { get { return 4; } }

    //    public override bool HasPresets { get { return false; } }
    //    public bool autoPersistance = true;

    //}
}
