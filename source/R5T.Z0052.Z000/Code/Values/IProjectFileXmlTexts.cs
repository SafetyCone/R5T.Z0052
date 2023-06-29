using System;

using R5T.T0131;
using R5T.T0210;
using R5T.T0210.Extensions;


namespace R5T.Z0052.Z000
{
    [ValuesMarker]
    public partial interface IProjectFileXmlTexts : IValuesMarker
    {
        /// <inheritdoc cref="N_002"/>
        public IProjectFileXmlText Missing_NoWarn => this.N_002;

        /// <summary>
        /// <para>Has:</para>
        /// <list type="bullet">
        /// <item>Custom labeled main property group.</item>
        /// <item>Custom labeled package property group.</item>
        /// <item>Correct no-warn warning numbers.</item>
        /// </list>
        /// <para>Needs:</para>
        /// <list type="bullet">
        /// <item>Project references item group custom labeled.</item>
        /// </list>
        /// </summary>
        public IProjectFileXmlText R5T_Z0052_Z000_FromString =>
@"
<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup Label=""Main"">
    <TargetFramework>net6.0</TargetFramework>
    <OutputType>Library</OutputType>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <NoWarn>1573;1587;1591</NoWarn>
  </PropertyGroup>
  <PropertyGroup Label=""Package"">
    <Version>1.0.0</Version>
    <Authors>DCoats</Authors>
    <Company>Rivet</Company>
    <Copyright>Copyright © Rivet 2023</Copyright>
    <Description>String-based project file XML text values.</Description>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageRequireLicenseAcceptance>true</PackageRequireLicenseAcceptance>
  </PropertyGroup>
  <ItemGroup>
    <ProjectReference Include=""..\..\..\R5T.T0131\source\R5T.T0131\R5T.T0131.csproj"" />
    <ProjectReference Include=""..\..\..\R5T.T0210\source\R5T.T0210\R5T.T0210.csproj"" />
  </ItemGroup>
</Project>
".ToProjectFileXmlText_WithTrim();


    }
}
