using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0052.Z001
{
    [ValuesMarker]
    public partial interface IFileNames : IValuesMarker
    {
        public IFileName R5T_Z0052_Z000_csproj => "R5T.Z0052.Z000.csproj".ToFileName();
        public IFileName R5T_Z0052_Z001_csproj => "R5T.Z0052.Z001.csproj".ToFileName();
    }
}
