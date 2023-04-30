﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    //Allows For failures on Antennas when remote tech is installed. Can fail Parts with ModuleRTAntenna.
    class RTAntennaFailureModule : BaseFailureModule
    {
        private PartModule antenna;
        [KSPField(isPersistant = true, guiActive = false)]
        bool RTAvailable = ModWrapper.RemoteTechWrapper.available;

        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-ant-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-ant-01");
            failureType = Localizer.Format("#OHS-ant-02");

            if (!antenna)
            {
                foreach (PartModule pm in part.Modules)
                {
                    if (pm.moduleName.Equals("ModuleRTAntenna"))
                    {
                        antenna = pm;
                    }
                }
            }
            remoteRepairable = true;
        }

        public override bool FailureAllowed()
        {
            if (!antenna) return false;
            if (!RTAvailable) return false;
            if (!ModWrapper.RemoteTechWrapper.GetAntennaDeployed(antenna)) return false; //Do not fail antennas that are deployed. Returns true if it cant be animated.
            return (HighLogic.CurrentGame.Parameters.CustomParams<Settings>().AntennaFailureModuleAllowed);
        }

        public override void FailPart()
        {
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            ModWrapper.RemoteTechWrapper.SetRTBrokenStatus(antenna, true);
            if (hasFailed) return;
            Debug.Log("[OhScrap](RemoteTech): " + SYP.ID + " has stopped transmitting");
            //PlaySound();
        }

        public override void RepairPart()
        {
            if (antenna)
            {
                ModWrapper.RemoteTechWrapper.SetRTBrokenStatus(antenna, false);
            }
        }


    }
}