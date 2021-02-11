using System;

namespace Utility_Library
{
    public class WorkingEnvioroment
    {
        public string OsVersion { get; set; }
        public string CurrentDirectory { get; set; }
        public string MachineName { get; set; }
        public string UserDomainName { get; set; }
        public string UserName { get; set; }

        /// <summary>
        /// Returns various properties for environment the application is running in.
        /// </summary>
        /// <returns>WorkingEnvioroment class</returns>
        public WorkingEnvioroment EnviromentInfo()
        {
            WorkingEnvioroment dataReturn = new WorkingEnvioroment();

            dataReturn.OsVersion = Convert.ToString(Environment.OSVersion);
            dataReturn.CurrentDirectory = Convert.ToString(Environment.CurrentDirectory);
            dataReturn.MachineName = Convert.ToString(Environment.MachineName);
            dataReturn.UserDomainName = Convert.ToString(Environment.UserDomainName);
            dataReturn.UserName = Convert.ToString(Environment.UserName);

            return dataReturn;
        }
    }
}
