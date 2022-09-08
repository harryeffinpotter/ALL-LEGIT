using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_LEGIT
{


    /// <summary>  
    /// ExtensionDeleteToRecycleBin.cs  
    /// </summary>  
    public static class ExtensionDeleteToRecycleBin
    {

        /// <summary>  
        /// Delete File To Recycle Bin  
        /// WARMING: NETWORK FILES DON'T GO TO RECYCLE BIN  
        /// </summary>  
        /// <param name="file"></param>  
        public static void FileRecycle(this string file)
            =>
        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(file,
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);

        /// <summary>  
        /// Delete Path To Recycle Bin  
        /// WARMING: NETWORK PATHS DON'T GO TO RECYCLE BIN  
        /// </summary>  
        /// <param name="path"></param>  
        public static void DirectoryRecycle(this string path)
            =>
        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(path,
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);


    }
}