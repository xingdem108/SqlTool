using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlTool
{
    class CommonHelper
    {
        public static void ChangeConfiguration(string name, string value)
        {

            //读取程序集的配置文件
            string assemblyConfigFile = Assembly.GetEntryAssembly().Location;
            string appDomainConfigFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //获取appSettings节点
            AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");

            //删除name，然后添加新值
            appSettings.Settings.Remove(name);
            appSettings.Settings.Add(name, value);

            //保存配置文件
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
