using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0180;
using R5T.T0210;
using R5T.T0210.Extensions;


namespace R5T.Z0052.Z001
{
    [FunctionalityMarker]
    public partial interface IProjectFileXmlTextOperator : IFunctionalityMarker
    {
        public Task<IProjectFileXmlText> Get_ProjectFileXmlText_FromFilesDirectoryFile(IFileName filesDirectoryFileName)
        {
            var filePath = Instances.FilesDirectoryOperator.Get_FilesDirectoryPath(filesDirectoryFileName);

            var output = this.Get_ProjectFileXmlText_FromFilePath(filePath);
            return output;
        }

        public async Task<IProjectFileXmlText> Get_ProjectFileXmlText_FromFilePath(IFilePath textFilePath)
        {
            var text = await Instances.FileOperator.Read_Text(textFilePath.Value);

            var output = text.ToProjectFileXmlText();
            return output;
        }
    }
}
