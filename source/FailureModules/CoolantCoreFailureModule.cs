using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OhScrap
{

    class CoolantCoreFailureModule : BaseFailureModule
    {
        // EngineManager engines;

        /// <summary>
        /// Adds sound FX for failures
        /// </summary>
        protected AudioSource Failure;
        protected AudioSource Repair;

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = "Chance of Coolant Line Failure";
            Fields["safetyRating"].guiName = "Coolant Line Safety Rating";
            failureType = "CoolantCore";
        }

        // Failure will drain the battery and stop it from recharging.
        public override void FailPart()
        {
            // this.engines.engines.ForEach(e => e.heatProduction *= 3);
            // this.engines.enginesFX.ForEach(e => e.heatProduction *= 3);

            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            if (hasFailed) return;
            Debug.Log("[OhScrap]: " + SYP.ID + " has suffered a coolant line failure");
            PlaySound();
            //_PlaySound(Failure);
        }

        //Repair allows it to be charged again.
        public override void RepairPart()
        {
            // this.engines.engines.ForEach(e => e.heatProduction /= 3);
            // this.engines.enginesFX.ForEach(e => e.heatProduction /= 3);
            // _PlaySound(Repair);
        }

        public override bool FailureAllowed()
        {
            return HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().EngineCoolantModuleAllowed;
        }

        //    public void Start()
        //    {
        //        if (HighLogic.LoadedSceneIsFlight)
        //        {
        //            // An engine might actually be two engine modules (e.g: SABREs)
        //            this.engines = new EngineManager(this.part);
        //        }

        //        Failure = Camera.main.gameObject.AddComponent<AudioSource>();
        //        Failure.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/battery-failure");
        //        Failure.volume = 0.8f;
        //        Failure.panStereo = 0;
        //        Failure.rolloffMode = AudioRolloffMode.Linear;

        //        Repair = Camera.main.gameObject.AddComponent<AudioSource>();
        //        Repair.clip = GameDatabase.Instance.GetAudioClip("OhScrap/Sounds/battery-repair");
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
        //}
    }
}
