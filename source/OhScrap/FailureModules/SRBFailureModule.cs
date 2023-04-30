using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Runtime.CompilerServices;
using KSP.UI.Screens;
using KSP.Localization;

namespace OhScrap
{
    class SRBFailureModule : BaseFailureModule
    {
        ModuleEngines engine;
        bool message;

        //SRBs can fail straight away, and will override the "launched" bool because we need them to fail before the player launches.
        //They will however suppress the messages until the player tries to launch.
        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-srb-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-srb-01");
            failureType = Localizer.Format("#OHS-srb-02");

            engine = part.FindModuleImplementing<ModuleEngines>();
            isSRB = true;
        }

        public override bool FailureAllowed()
        {
            if (engine == null) return false;
            if (KRASHWrapper.simulationActive()) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().SRBFailureModuleAllowed;
        }
        //Part will just shutdown and not be restartable.
        public override void FailPart()
        {
            if (KRASHWrapper.simulationActive()) return;
            if (engine.currentThrottle == 0) return;
            engine.allowShutdown = true;
            engine.allowRestart = false;
            hasFailed = true;
            engine.Shutdown();
            if (!message)
            {
                if (vessel.vesselType != VesselType.Debris)
                    ScreenMessages.PostScreenMessage(Localizer.Format("#OHS-srb-03", part.partInfo.title));
                    //ScreenMessages.PostScreenMessage(part.partInfo.title + " has failed to ignite");
                StringBuilder msg = new StringBuilder();
                msg.AppendLine(part.vessel.vesselName);
                msg.AppendLine("");
                msg.AppendLine(Localizer.Format("#OHS-srb-04", part.partInfo.title, failureType));
                //msg.AppendLine(part.partInfo.title + " has suffered an " + failureType);
                msg.AppendLine("");
                MessageSystem.Message m = new MessageSystem.Message("OhScrap", msg.ToString(),
                    MessageSystemButton.MessageButtonColor.ORANGE, MessageSystemButton.ButtonIcons.ALERT);
                MessageSystem.Instance.AddMessage(m);
                message = true;
            }

            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            CancelInvoke("FailPart");
            Logger.instance.Log("[OhScrap]: " + part.partInfo.title + " has failed to ignite");
            //PlaySound();
        }

        //SRBs cant be repaired.
        public override void RepairPart()
        {
            ScreenMessages.PostScreenMessage(Localizer.Format("#OHS-srb-05"));
            ModuleUPFMEvents UPFM = part.FindModuleImplementing<ModuleUPFMEvents>();
            UPFM.customFailureEvent = true;
        }
    }
}
