using GroupDocs.Conversion.Cloud.Sdk.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Conversion.Cloud.Examples
{
    class Common
    {
        public static string MyAppSid = Common.MyAppSid;
        public static string MyAppKey = Common.MyAppKey;

        public static void UploadSampleTestFiles()
        {
            var storageConfig = new Configuration
            {
                AppSid = MyAppSid,
                AppKey = MyAppKey,
            };

            StorageApi storageApi = new StorageApi(storageConfig);
            var path = "..\\..\\Resources";

            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = storageApi.IsExist(relativeDirPath);
                if (!response.FileExist.IsExist)
                    storageApi.CreateFolder(relativeDirPath);
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = storageApi.IsExist(relativeFilePath);
                if (!response.FileExist.IsExist)
                {
                    var fileName = Path.GetFileName(file);
                    var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
                    var bytes = File.ReadAllBytes(file);

                    storageApi.CreateFile(fileName, relativeDirPath, bytes);
                }
            }
        }
    }


}
