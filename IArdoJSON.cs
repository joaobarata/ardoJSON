using OutSystems.ExternalLibraries.SDK;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ardo.ArdoJSON
{
    /// <summary>
    /// Version 1.0
    /// Helper extension for JSON. Allows you to manipulate and parse JSON using JSONPath.
    /// Uses the Newtonsoft.Json library (https://www.newtonsoft.com/json)
    /// </summary>
    [OSInterface(Description = "Version 0.1.0\r\n\r\nHelper extension for JSON. Allows you to manipulate and parse JSON using JSONPath.\r\n\r\nUses the Newtonsoft.Json library (https://www.newtonsoft.com/json)", IconResourceName = "ArdoJSON.resources.logo.png", Name = "ArdoJSON")]
    public interface IArdoJSON
    {
        /// <summary>
        /// Attempts to parse an IBAN, returning a boolean success indicator and a
        /// new Iban structure. This method is exposed as a server action to your
        /// ODC apps and libraries.
        /// </summary>
        [OSAction(Description = "Replaces an object identified by Path with a list of name/value pairs.\r\n\r\nThis is helpful to pre-process JSON with \"dynamic\" property names to something that can be translated into the OutSystems Platform types", IconResourceName = "ArdoJSON.resources.logo.png", ReturnName = "JSONOut")]
        public string JSON_Listify(
            [OSParameter(Description = "The JSON to be parsed")]
            string JSONIn,
            [OSParameter(Description = "Path to the point where processing should happen (where your object is)")]
            string? Path="");

        /// <summary>
        /// Attempts to parse an IBAN, returning a boolean success indicator and a
        /// new Iban structure. This method is exposed as a server action to your
        /// ODC apps and libraries.
        /// </summary>
        [OSAction(Description = "Replaces an list of key/value pairs identified by Path with an object.\r\n\r\nThis is helpful to pre-process JSON with \"dynamic\" property names to something that can be translated into the OutSystems Platform types", IconResourceName = "ArdoJSON.resources.logo.png", ReturnName = "JSONOut")]
        public string JSON_Objectify(
            [OSParameter(Description = "The JSON to be parsed")]
            string JSONIn,
            [OSParameter(Description = "Path to the point where processing should happen (where your list of key/value pairs is)")]
            string? Path= "");


        /// <summary>
        /// Attempts to parse an IBAN, returning a boolean success indicator and a
        /// new Iban structure. This method is exposed as a server action to your
        /// ODC apps and libraries.
        /// </summary>
        [OSAction(Description = "Allows simple path selection of an element in the JSON", IconResourceName = "ArdoJSON.resources.logo.png", ReturnName = "JSONOut")]
        public string JSONSelect(
            [OSParameter(Description = "The JSON to be parsed")]
            string JSONIn,
            [OSParameter(Description = "Path to select")]
            string? Path=null,
            [OSParameter(DataType = OSDataType.Boolean, Description = "If true, when the JSON path returns a single element, force the content to return as JSON ( enclosed in double quotes). If false, return the value without the enclosing quotes. Defaults to false")]
            bool? AlwaysReturnAsJSON =false);
    }
}