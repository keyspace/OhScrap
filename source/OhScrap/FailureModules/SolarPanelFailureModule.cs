using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class SolarPanelFailureModule : BaseFailureModule
    {
        ModuleDeployableSolarPanel panel;
        bool originallyRetractable;
        bool trackingFailure;
        bool trackingSet = false;

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-sol-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-sol-01");

            remoteRepairable = true;
            panel = part.FindModuleImplementing<ModuleDeployableSolarPanel>();
        }
        public override bool FailureAllowed()
        {
            if (panel == null) return false;
            if (!panel.isTracking) return false;
            if (panel.deployState != ModuleDeployablePart.DeployState.EXTENDED) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().SolarPanelFailureModuleAllowed;
        }
        public override void FailPart()
        {
            //If the part can't retract will always get a sun tracking error, otherwise it will get a retraction or sun tracking at random.
            if (panel == null) return;
            if (!trackingSet)
            {
                if (Utils.instance._randomiser.NextDouble() < 0.5) trackingFailure = true;
                else trackingFailure = false;
                trackingSet = true;
            }
            if (panel.isTracking && panel.retractable && panel.deployState == ModuleDeployablePart.DeployState.EXTENDED && !trackingFailure)
            {
                panel.retractable = false;
                originallyRetractable = true;
                if (!hasFailed)
                {
                    failureType = Localizer.Format("#OHS-sol-02");
                }
                if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            }
            else if (panel.isTracking && panel.deployState == ModuleDeployablePart.DeployState.EXTENDED && !originallyRetractable)
            {
                panel.isTracking = false;
                failureType = Localizer.Format("#OHS-sol-03");
                if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            }
            //PlaySound();
        }
        //returns to original state.
        public override void RepairPart()
        {
            if (!panel) return;
            if (originallyRetractable) panel.retractable = true;
            panel.isTracking = true;
        }
    }
}