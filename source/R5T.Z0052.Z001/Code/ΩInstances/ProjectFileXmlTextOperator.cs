using System;


namespace R5T.Z0052.Z001
{
    public class ProjectFileXmlTextOperator : IProjectFileXmlTextOperator
    {
        #region Infrastructure

        public static IProjectFileXmlTextOperator Instance { get; } = new ProjectFileXmlTextOperator();


        private ProjectFileXmlTextOperator()
        {
        }

        #endregion
    }
}
