using KSP.Localization;

namespace OhScrap
{
    class AlternatorFailureModule : BaseFailureModule
    {
        private ModuleAlternator _alternator;
        protected override void Overrides()
        {
            Fields["displayChance"].guiName = Localizer.Format("#OHS-alt-00");
            Fields["safetyRating"].guiName = Localizer.Format("#OHS-alt-01");
            failureType = Localizer.Format("#OHS-alt-02");
            _alternator = part.FindModuleImplementing<ModuleAlternator>();
        }

        //This actually makes the failure happen
        public override void FailPart()
        {
            _alternator.enabled = false;
            if (OhScrap.highlight) OhScrap.SetFailedHighlight();
        }
        //this repairs the part.
        public override void RepairPart()
        {
            _alternator.enabled = true;
        }
        //this should read from the Difficulty Settings.
        public override bool FailureAllowed()
        {
            if (_alternator == null) return false;
            if (_alternator.outputRate < 0.1f) return false;
            return HighLogic.CurrentGame.Parameters.CustomParams<Settings>().AlternatorFailureModuleAllowed;
        }
    }
}