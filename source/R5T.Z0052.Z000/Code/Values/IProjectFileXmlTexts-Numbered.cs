using System;

using R5T.T0131;
using R5T.T0210;
using R5T.T0210.Extensions;


namespace R5T.Z0052.Z000
{
    public partial interface IProjectFileXmlTexts
    {
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
        public IProjectFileXmlText N_001 =>
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

        /// <summary>
        /// Missing the &lt;NoWarn&gt; property element.
        /// </summary>
        public IProjectFileXmlText N_002 =>
@"
<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup Label=""Main"">
    <TargetFramework>net6.0</TargetFramework>
    <OutputType>Library</OutputType>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>
</Project>
".ToProjectFileXmlText_WithTrim();

        /// <summary>
        /// Has &lt;NoWarn&gt; and &lt;PrivateGitHubRepository&gt; properties.
        /// </summary>
        public IProjectFileXmlText N_003 =>
@"
<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup Label=""Main"">
    <TargetFramework>net6.0</TargetFramework>
    <OutputType>Library</OutputType>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <NoWarn>1573;1587;1591</NoWarn>
  </PropertyGroup>
  <PropertyGroup Label=""Custom"">
    <PrivateGitHubRepository />
  </PropertyGroup>
</Project>
".ToProjectFileXmlText_WithTrim();
    }
}
