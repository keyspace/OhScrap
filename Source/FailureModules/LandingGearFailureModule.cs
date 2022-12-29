using ModuleWheels;
using KSP.Localization;

namespace OhScrap
{
    class LandingGearFailureModule : BaseFailureModule
    {
        private ModuleWheelDeployment _wheel;
        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-gear-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-gear-01");
            failureType = Localizer.Format("#OHS-gear-02");

            _wheel = part.FindModuleImplementing<ModuleWheelDeployment>();
        }

        //This actually makes the failure happen
        public override void FailPart()
        {
            _wheel.enabled = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
            //PlaySound();
        }
        //this repairs the part.
        public override void RepairPart()
        {
            _wheel.enabled = true;
        }
        //this should read from the Difficulty Settings.
        public override bool FailureAllowed()
        {
            if (_wheel == null) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().LandingGearFailureModuleAllowed;
        }
    }
}