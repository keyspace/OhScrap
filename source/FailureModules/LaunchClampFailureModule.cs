using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OhScrap
{
    //class LaunchClampFailureModule : BaseFailureModule
    //{
    //    LaunchClamp clamp;

    //    public override bool FailureAllowed()
    //    {
    //        if (clamp == null) return false;
    //        //if (!vessel.ActionGroups[KSPActionGroup.Light]) return false;
    //        return HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().LaunchClampFailureModuleAllowed;
    //    }

    //    protected override void Overrides()
    //    {
    //        Fields["displayChance"].guiName = "Chance of LaunchClamp Failure";
    //        Fields["safetyRating"].guiName = "LaunchClamp Safety Rating";
    //        failureType = "LaunchClamp Failure";
    //        clamp = part.FindModuleImplementing<LaunchClamp>();
    //    }

    //    //turns the Light off.
    //    public override void FailPart()
    //    {
    //        if (clamp == null) return;
    //        clamp.moduleIsEnabled = false;
    //        clamp.isEnabled = false;
    //        clamp.LaunchClamp.isEnabled = false;
    //        clamp.ModuleGenerator.isEnabled = false;
    //        if (OhScrap.highlight) OhScrap.SetFailedHighlight();
    //        // this.part.Modules.Remove(Release());
    //        // this.part.Release() = false;
    //        PlaySound();
    //    }
    //    //turns it back on again
    //    public override void RepairPart()
    //    {
    //        clamp.moduleIsEnabled = true;
    //        clamp.ModuleGenerator.isEnabled = true;
    //        // this.part.Modules.Add(this.light);
    //        clamp.LaunchClamp.isEnabled = true;
    //        clamp.isEnabled = true;
    //    }
    //}
}
