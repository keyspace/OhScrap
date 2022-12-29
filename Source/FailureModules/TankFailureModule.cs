using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace OhScrap
{
    class TankFailureModule : BaseFailureModule
    {
        PartResource leaking;
        [KSPField(isPersistant = true, guiActive = false)]
        public string leakingName = "None";
        bool cantLeak = false;

        protected override void Overrides()
        {

            Fields["displayChance"].guiName = Localizer.Format("#OHS-tank-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-tank-01");

            List<PartResource> potentialLeakCache = part.Resources.ToList();
            List<PartResource> potentialLeaks = part.Resources.ToList();
            //Check if we have any parts that can leak (not on the blacklist)
            if (potentialLeaks.Count == 0)
            {
                Fields["safetyRating"].guiActiveEditor = false;
                Fields["safetyRating"].guiActive = false;
            }
            ConfigNode[] blackListNode = GameDatabase.Instance.GetConfigNodes("OHSCRAP_RESOURCE_BLACKLIST");
            if (blackListNode.Count() > 0)
            {
                for (int i = 0; i < blackListNode.Count(); i++)
                {
                    ConfigNode node = blackListNode.ElementAt(i);
                    for (int p = 0; p < potentialLeakCache.Count(); p++)
                    {
                        PartResource pr = potentialLeakCache.ElementAt(p);
                        if (pr.resourceName == node.GetValue("name")) potentialLeaks.Remove(pr);
                    }
                }
                //if not then turn the module off in the GUI because it will never fail
                if (potentialLeaks.Count == 0)
                {
                    Fields["safetyRating"].guiActiveEditor = false;
                    Fields["safetyRating"].guiActive = false;
                    cantLeak = true;
                }
            }
        }
        public override bool FailureAllowed()
        {
            if (cantLeak) return false;
            if (part.vesselType == VesselType.EVA) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().TankFailureModuleAllowed;
        }
        //Assuming that part has a resource that is not on the blacklist, it will leak.
        public override void FailPart()
        {
            if (leaking == null)
            {
                if (leakingName != "None")
                {
                    leaking = part.Resources[leakingName];
                    failureType = Localizer.Format("#OHS-tank-02", leaking.resourceName);
                    return;
                }
                List<PartResource> potentialLeakCache = part.Resources.ToList();
                List<PartResource> potentialLeaks = part.Resources.ToList();
                if (potentialLeaks.Count == 0) return;
                ConfigNode[] blackListNode = GameDatabase.Instance.GetConfigNodes("OHSCRAP_RESOURCE_BLACKLIST");
                if (blackListNode.Count() > 0)
                {
                    for (int i = 0; i < blackListNode.Count(); i++)
                    {
                        ConfigNode node = blackListNode.ElementAt(i);
#if DEBUG

                        Debug.Log("[UPFM]: Checking " + node.GetValue("name") + " for blacklist");
#endif
                        for (int p = 0; p < potentialLeakCache.Count(); p++)
                        {
                            PartResource pr = potentialLeakCache.ElementAt(p);
                            if (pr.resourceName == node.GetValue("name")) potentialLeaks.Remove(pr);
                        }
                    }
                    if (potentialLeaks.Count == 0)
                    {
                        leaking = null;
                        leakingName = Localizer.Format("#autoLOC_258911");
                        cantLeak = true;
                        Debug.Log("[OhScrap]: " + SYP.ID + "has no resources that could fail. Failure aborted");
                        return;
                    }
                }
                leaking = potentialLeaks.ElementAt(Utils.instance._randomiser.Next(0, potentialLeaks.Count()));
                leakingName = leaking.resourceName;
                failureType = Localizer.Format("#OHS-tank-02", leaking.resourceName);
            }
            leaking.amount = leaking.amount * 0.999f;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            //PlaySound();
        }
    }
}