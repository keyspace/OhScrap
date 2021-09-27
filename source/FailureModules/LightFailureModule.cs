using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OhScrap
{
    class LightFailureModule : BaseFailureModule
    {
        ModuleLight light;

        bool lightState = false;

        public override bool FailureAllowed()
        {
            if (light == null) return false;
            if (!vessel.ActionGroups[KSPActionGroup.Light]) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().LightFailureModuleAllowed;
        }

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = "Chance of Light Failure";
            Fields["safetyRating"].guiName = "Light Safety Rating";
            failureType = "Light Failure";
            light = part.FindModuleImplementing<ModuleLight>();
        }

        //turns the Light off.
        public override void FailPart()
        {
            if (light == null) return;
            lightState = light.isOn;
            light.isEnabled = false;
            light.isOn = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            this.part.Modules.Remove(this.light);
            PlaySound();
        }
        //turns it back on again
        public override void RepairPart()
        {
            this.part.Modules.Add(this.light);
            light.isOn = lightState;
            light.isEnabled = true;
        }
    }
}
