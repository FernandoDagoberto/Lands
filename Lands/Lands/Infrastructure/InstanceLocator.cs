namespace Lands.Infrastructure
{
    using ViewModels;
    
    public class InstanceLocator
    {

        #region Property
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion



    }
}
