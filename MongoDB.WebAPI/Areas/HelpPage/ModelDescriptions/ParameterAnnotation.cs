using System;

namespace MongoDB.WebAPI.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// ParameterAnnotation
    /// </summary>
    public class ParameterAnnotation
    {
        /// <summary>
        /// AnnotationAttribute
        /// </summary>
        public Attribute AnnotationAttribute { get; set; }

        /// <summary>
        /// Documentation
        /// </summary>
        public string Documentation { get; set; }
    }
}