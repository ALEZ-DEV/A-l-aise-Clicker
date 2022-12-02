using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class Lang
    {
        public string showConsole = "Show Console";
        public string hideConsole = "Hide Console";

        public string stateEnable = "State : Enable";
        public string stateDisable = "State : Disable";

        public string enableKeyLabel = "Enable key";

        public string themeLabel = "Theme";

        public string languageLabel = "Language";

        public Lang(string language)
        {

            SetLanguage(language);

        }

        public void SetLanguage(string language)
        {

            if (language == "en")
            {
                SetForEN();
            } 
            else if (language == "fr")
            {
                SetForFR();
            }

        }

        public void SetForEN()
        {
            showConsole = "Show Console";
            hideConsole = "Hide Console";

            stateEnable = "State : Enable";
            stateDisable = "State : Disable";

            enableKeyLabel = "Enable key";

            themeLabel = "Theme";

            languageLabel = "Language";
        }

        public void SetForFR()
        {
            showConsole = "Ouvrir la Console";
            hideConsole = "Fermer la Console";

            stateEnable = "Etat : Activé";
            stateDisable = "Etat : Desactivé";

            enableKeyLabel = "Touche d'activation";

            themeLabel = "Thème";

            languageLabel = "Langue";
        }

    }
}
