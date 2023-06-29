using System;


namespace R5T.Z0052.Z001
{
    public static class Instances
    {
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static IFileNames FileNames => Z001.FileNames.Instance;
        public static IFilesDirectoryOperator FilesDirectoryOperator => Z001.FilesDirectoryOperator.Instance;
        public static F0091.IFilesDirectoryOperator FilesDirectoryOperator_F0091 => F0091.FilesDirectoryOperator.Instance;
        public static IProjectFileXmlTextOperator ProjectFileXmlTextOperator => Z001.ProjectFileXmlTextOperator.Instance;
    }
}