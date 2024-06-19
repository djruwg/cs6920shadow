using BBB.DAL;
using BBB.Models;

namespace BBB.Controllers
{
    internal class SettingsController
    {
        public string startupURL { get; private set; }

        public SettingsController()
        {
            SettingsDAL settingsDAL = new SettingsDAL();
            Settings settings = settingsDAL.GetSettings();
            this.startupURL = settings.starturl;
        }
    }
}
