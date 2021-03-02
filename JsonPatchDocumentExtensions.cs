using Microsoft.AspNetCore.JsonPatch;
using System.Reflection;

namespace CustomExtensions
{
    public static class JsonPatchDocumentExtensions
    {
        public static JsonPatchDocument ReplacePatchGenerator(this JsonPatchDocument patch, object input)
        {
            return RecursiveReplacementPatch(patch, input, "");
        }

        private static RecursiveReplacementPatch(this JsonPatchDocument patch, object input, string patchPrefix)
        {
            foreach (PropertyInfo prop in input.GetType().GetProperties())
            {
                if (prop.PropertyType.ToString().StartsWith("System."))
                {
                    patch.Replace(string.Format("", pathPrefix, prop.Name), prop.GetValue(input, null));
                }
                else
                {
                    RecursiveReplacementPatch(patch, prop.GetValue(input, null), string.Format("{0}{1}", prop.Name, patchPrefix));
                }
            }

            return patch;
        }
    }
}