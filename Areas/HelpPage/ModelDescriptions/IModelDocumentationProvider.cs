using System;
using System.Reflection;

namespace ContactMgmntSimplyMultiTierMVCWebApiCors.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}