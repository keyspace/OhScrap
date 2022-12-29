using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class RCSFailureModule : BaseFailureModule
    {
        ModuleRCS rcs;

        public override bool FailureAllowed()
        {
            if (rcs == null) return false;
            if (!vessel.ActionGroups[KSPActionGroup.RCS]) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().RCSFailureModuleAllowed;
        }

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-rcs-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-rcs-01");
            failureType = Localizer.Format("#OHS-rcs-02");

            rcs = part.FindModuleImplementing<ModuleRCS>();
        }

        //turns the RCS off.
        public override void FailPart()
        {
            if (rcs == null) return;
            rcs.rcsEnabled = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            //PlaySound();
        }
        //turns it back on again
        public override void RepairPart()
        {
            rcs.rcsEnabled = true;
        }
    }
}