namespace RefactoringToPatterns.CreationMethods
{
    public class ProductPackage
    {
        private readonly string internetLabel;
        private readonly int? telephoneNumber;
        private readonly string[] tvChannels;

        public ProductPackage(string internetLabel)
        {
            this.internetLabel = internetLabel;
        }

        public ProductPackage(string internetLabel, int telephoneNumber)
        {
            this.internetLabel = internetLabel;
            this.telephoneNumber = telephoneNumber;
        }

        public ProductPackage(string internetLabel, string[] tvChannels)
        {
            this.internetLabel = internetLabel;
            this.tvChannels = tvChannels;
        }

        public ProductPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            this.internetLabel = internetLabel;
            this.telephoneNumber = telephoneNumber;
            this.tvChannels = tvChannels;
        }

        public bool HasInternet()
        {
            return internetLabel != null;
        }


        public bool HasVoip()
        {
            return telephoneNumber != null;
        }

        public bool HasTv()
        {
            return tvChannels != null;
        }
    }
}