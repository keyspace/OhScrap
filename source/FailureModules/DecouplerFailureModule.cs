using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OhScrap
{
    class DecouplerFailureModule : BaseFailureModule
    {
        ModuleDecouple decoupler;
        float origForcePercent = -1f;

        public override bool FailureAllowed()
        {
            if (decoupler == null) return false;
            //if (!vessel.ActionGroups[KSPActionGroup.Stage]) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().DecouplerFailureModuleAllowed;
        }

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = "Chance of Decoupler Failure";
            Fields["safetyRating"].guiName = "Decoupler Safety Rating";
            failureType = "Decoupler Failure";
            decoupler = part.FindModuleImplementing<ModuleDecouple>();
        }

        //turns the Light off.
        public override void FailPart()
        {
            if (decoupler == null) return;
            decoupler.isEnabled = false;
            decoupler.moduleIsEnabled = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();

            this.origForcePercent = decoupler.ejectionForcePercent;
            decoupler.ejectionForcePercent = 0;

            PlaySound();
        }
        //turns it back on again
        public override void RepairPart()
        {
            decoupler.moduleIsEnabled = true;
            decoupler.ejectionForcePercent = this.origForcePercent;
            decoupler.isEnabled = true;
        }
    }
}
