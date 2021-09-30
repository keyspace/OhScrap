using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class UPFMSettings : GameParameters.CustomParameterNode
    {
        // title is the left side,

        public override string Section { get { return "#OHS_modname"; } }
        public override string DisplaySection { get { return "#OHS_modname"; } }
        public override string Title { get { return "#OHS-Settings-Title-1"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 1; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-alt", toolTip = "#OHS-Settings-alt-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool AlternatorFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-ant", toolTip = "#OHS-Settings-ant-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool AntennaFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-bat", toolTip = "#OHS-Settings-bat-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool BatteryFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-cnt", toolTip = "#OHS-Settings-cnt-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool ControlSurfaceFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-eng", toolTip = "#OHS-Settings-eng-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool EngineFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-gea", toolTip = "#OHS-Settings-gea-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool LandingGearFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-par", toolTip = "#OHS-Settings-par-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool ParachuteFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-rcs", toolTip = "#OHS-Settings-rcs-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool RCSFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-rws", toolTip = "#OHS-Settings-rws-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool ReactionWheelFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-tnk", toolTip = "#OHS-Settings-tnk-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool TankFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-sol", toolTip = "#OHS-Settings-sol-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool SolarPanelFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-srb", toolTip = "#OHS-Settings-srb-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool SRBFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-lit", toolTip = "#OHS-Settings-lit-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool LightFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-dcp", toolTip = "#OHS-Settings-dcp-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool DecouplerFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-lcp", toolTip = "#OHS-Settings-lcp-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool LaunchClampFailureModuleAllowed = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-cool", toolTip = "#OHS-Settings-cool-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool EngineCoolantModuleAllowed = true;

    }

    class OhScrapSettings : GameParameters.CustomParameterNode
    {
        // title is the section title side,
        public override string Section { get { return "#OHS_modname"; } }
        public override string DisplaySection { get { return "#OHS_modname"; } }
        public override string Title { get { return "#OHS-Settings-Title-2"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 2; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-warn", toolTip = "#OHS-Settings-warn-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool safetyWarning = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-highlight", toolTip = "#OHS-Settings-highlight-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool highlightFailures = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-warp", toolTip = "#OHS-Settings-warp-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool stopOnFailure = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-recovery", toolTip = "#OHS-Settings-recovery-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool overrideStageRecovery = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-paw", toolTip = "#OHS-Settings-paw-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool coloredPAW = true;

        [GameParameters.CustomParameterUI("#OHS-Settings-snd", toolTip = "#OHS-Settings-snd-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool audibleAlarms = true;

        [GameParameters.CustomIntParameterUI("#OHS-Settings-soundClip", minValue = 0, maxValue = 5, stepSize = 1, toolTip = "#OHS-Settings-soundClip-Tip")]
        public int soundClip = 0;

        [GameParameters.CustomFloatParameterUI("#OHS-Settings-soundVolume",
                                                toolTip = "#OHS-Settings-soundVolume-Tip",
                                                asPercentage = false,
                                                minValue = 0f,
                                                maxValue = 1f,
                                                displayFormat = "F2",
                                                stepCount = 1)]
        public float soundVolume = 0.75f;

        [GameParameters.CustomParameterUI("#OHS-Settings-qt", toolTip = "#OHS-Settings-qt-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool quietMode = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-Parts", toolTip = "#OHS-Settings-Parts-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool requireParts = false;
    }
    class DebugSettings : GameParameters.CustomParameterNode
    {
        // title is the section title side,
        public override string Section { get { return "#OHS_modname"; } }
        public override string DisplaySection { get { return "#OHS_modname"; } }
        public override string Title { get { return "#OHS-Settings-Title-3"; } }

        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override int SectionOrder { get { return 3; } }

        public override bool HasPresets { get { return false; } }
        public bool autoPersistance = true;
        public bool newGameOnly = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-log", toolTip = "#OHS-Settings-log-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool logging = false;

        [GameParameters.CustomParameterUI("#OHS-Settings-deb", toolTip = "#OHS-Settings-deb-Tip", newGameOnly = false, unlockedDuringMission = true)]
        public bool debugMenu = true;

        [GameParameters.CustomParameterUI("OhScrap(UPFM) v: " + Version.Text)]
        public bool thrsowaway = false;
    }
    //class DebugSettings2 : GameParameters.CustomParameterNode
    //{
    //    // title is the section title side,
    //    public override string Section { get { return "#OHS_modname"; } }
    //    public override string DisplaySection { get { return "#OHS_modname"; } }
    //    public override string Title { get { return "#OHS-Settings-Title-4"; } }

    //    public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
    //    public override int SectionOrder { get { return 4; } }

    //    public override bool HasPresets { get { return false; } }
    //    public bool autoPersistance = true;

    //}
}
