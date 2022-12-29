using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class ReactionWheelFailureModule : BaseFailureModule
    {
        ModuleReactionWheel rw;

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-rw-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-rw-01");
            failureType = Localizer.Format("#OHS-rw-02");

            remoteRepairable = true;
            rw = part.FindModuleImplementing<ModuleReactionWheel>();
        }

        public override bool FailureAllowed()
        {
            if (rw == null) return false;
            if (!rw.isEnabled && rw.wheelState != ModuleReactionWheel.WheelState.Active) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().ReactionWheelFailureModuleAllowed;
        }

        // Reaction wheel stops working
        public override void FailPart()
        {
            if (!rw) return;
            rw.isEnabled = false;
            rw.wheelState = ModuleReactionWheel.WheelState.Broken;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            hasFailed = true;
            //PlaySound();
        }
        //Turns it back on again,
        public override void RepairPart()
        {
            if (!rw) return;
            rw.isEnabled = true;
            rw.wheelState = ModuleReactionWheel.WheelState.Active;
        }
    }
}
