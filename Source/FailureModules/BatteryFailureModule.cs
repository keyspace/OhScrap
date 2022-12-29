using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class BatteryFailureModule : BaseFailureModule
    {
        /// <summary>
        /// Adds sound FX for failures
        /// </summary>
        //protected AudioSource Failure;
        //protected AudioSource Repair;

        PartResource battery;

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-bat-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-bat-01");
            failureType = Localizer.Format("#OHS-bat-02");
            battery = part.Resources["ElectricCharge"];
        }

        // Failure will drain the battery and stop it from recharging.
        public override void FailPart()
        {
            battery.amount = 0;
            battery.flowState = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            if (hasFailed) return;
            Debug.Log("[OhScrap]: " + SYP.ID + " has suffered a short circuit failure");
            //PlaySound();
            //PlaySound();
        }

        //Repair allows it to be charged again.
        public override void RepairPart()
        {
            battery.flowState = true;
            // allows for saving the vessel if only battery
            battery.amount = 1;
            // PlaySound(Repair);
        }

        public override bool FailureAllowed()
        {
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().BatteryFailureModuleAllowed;
        }

        //public void Start()
        //{
        //    Failure = Camera.main.gameObject.AddComponent<AudioSource>();
        //    Failure.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/battery-failure");
        //    Failure.volume = 0.8f;
        //    Failure.panStereo = 0;
        //    Failure.rolloffMode = AudioRolloffMode.Linear;

        //    Repair = Camera.main.gameObject.AddComponent<AudioSource>();
        //    Repair.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/battery-repair");
        //    Repair.volume = 0.8f;
        //    Repair.panStereo = 0;
        //    Repair.rolloffMode = AudioRolloffMode.Linear;

        //}

        //private void _PlaySound(AudioSource SoundType)
        //{
        //    if (HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().audibleAlarms)
        //    {
        //        SoundType.volume = HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().soundVolume;
        //        SoundType.Play();
        //    }
        //}
    }
}
