using System;


namespace R5T.Z0052.Z000
{
    public class ProjectFileXmlTexts : IProjectFileXmlTexts
    {
        #region Infrastructure

        public static IProjectFileXmlTexts Instance { get; } = new ProjectFileXmlTexts();


        private ProjectFileXmlTexts()
        {
        }

        #endregion
    }
}
