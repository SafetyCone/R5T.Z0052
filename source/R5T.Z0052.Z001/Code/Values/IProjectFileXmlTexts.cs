using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0210;


namespace R5T.Z0052.Z001
{
    [ValuesMarker]
    public partial interface IProjectFileXmlTexts : IValuesMarker
    {
        public Task<IProjectFileXmlText> R5T_Z0052_Z000_FromFile => Instances.ProjectFileXmlTextOperator.Get_ProjectFileXmlText_FromFilesDirectoryFile(
            Instances.FileNames.R5T_Z0052_Z000_csproj);

        public Task<IProjectFileXmlText> R5T_Z0052_Z001_FromFile => Instances.ProjectFileXmlTextOperator.Get_ProjectFileXmlText_FromFilesDirectoryFile(
            Instances.FileNames.R5T_Z0052_Z001_csproj);
    }
}
