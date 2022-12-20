using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class LightFailureModule : BaseFailureModule
    {
        ModuleLight light;

        ///// <summary>
        ///// Adds sound FX for failures
        ///// </summary>
        //protected AudioSource Failure;
        //protected AudioSource Repair;

        bool lightState = false;

        public override bool FailureAllowed()
        {
            if (light == null) return false;
            if (!vessel.ActionGroups[KSPActionGroup.Light]) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().LightFailureModuleAllowed;
        }

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-lit-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-lit-01");
            failureType = Localizer.Format("#OHS-lit-02");
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
            //_PlaySound(Repair);
            this.part.Modules.Add(this.light);
            light.isOn = lightState;
            light.isEnabled = true;
        }

        //    public void Start()
        //    {
        //        Failure = Camera.main.gameObject.AddComponent<AudioSource>();
        //        Failure.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/light-failure");
        //        Failure.volume = 0.8f;
        //        Failure.panStereo = 0;
        //        Failure.rolloffMode = AudioRolloffMode.Linear;

        //        Repair = Camera.main.gameObject.AddComponent<AudioSource>();
        //        Repair.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/light-repair");
        //        Repair.volume = 0.8f;
        //        Repair.panStereo = 0;
        //        Repair.rolloffMode = AudioRolloffMode.Linear;

        //    }

        //    private void _PlaySound(AudioSource SoundType)
        //    {
        //        if (HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().audibleAlarms)
        //        {
        //            SoundType.volume = HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().soundVolume;
        //            SoundType.Play();
        //        }
        //    }
    }
}

