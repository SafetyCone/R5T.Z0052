using System;

using R5T.T0132;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0052.Z001
{
    [FunctionalityMarker]
    public partial interface IFilesDirectoryOperator : IFunctionalityMarker
    {
        public IFilePath Get_FilesDirectoryPath(IFileName filesDirectoryFileName)
        {
            var output = Instances.FilesDirectoryOperator_F0091.GetFilesDirectoryFilePath_UsingProjectNameDirectory(
                "R5T.Z0052.Z001",
                filesDirectoryFileName.Value)
                .ToFilePath();

            return output;
        }
    }
}
