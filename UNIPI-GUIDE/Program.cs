using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    internal static class Program
    {
        private static Boolean isLoggedInUser;
        private static String loggedInUsername;
        private static string db = "Data source=unipi_guide.db;Version=3";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroForm());
        }

        public static void setLoggedInUser(Boolean userHasLoggedIn)
        {
            isLoggedInUser = userHasLoggedIn;
        }

        public static Boolean getLoggedInUser()
        {
            return isLoggedInUser;
        }

        public static void setActiveUsername(String username)
        {
            loggedInUsername = username;
        }

        public static String getActiveUsername()
        {
            if (isLoggedInUser)
            {
                if (loggedInUsername != null)
                {
                    return loggedInUsername;
                } else
                {
                    return "user1234";
                }
                
            } else
            {
                return "guestUser";
            }
        }

        public static String getUserPhoto()
        {
            if (isLoggedInUser)
            {
                return "logged_user_photo.png";
            }
            else
            {
                return "user_icon.png";
            }
        }

        /**
         * Returns dbInfo, so its easier for db migrations
         */

        public static String getDbInfo()
        {
            return db;
        }
    }
}
