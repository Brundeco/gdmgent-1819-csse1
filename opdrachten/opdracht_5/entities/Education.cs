namespace entities
{
    public class Education
    {
        private string campusAbbr;
        protected int campusNr;
        public string Campus
        {
            get;
            set;
        }

        public string EducationName
        {
            get;
            set;
        }
        public string GetWifiCode()
        {
            return "Wifi code";
        }

        public Education()
        {
            this.campusAbbr = "AHS";
            this.campusNr = 14;
        }
    }
}