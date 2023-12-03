
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamasoft.JsonClassGenerator;
using Xamasoft.JsonClassGenerator.CodeWriterConfiguration;
using Xamasoft.JsonClassGenerator.CodeWriters;
using Xamasoft.JsonClassGenerator.Models;

namespace TESTS_JSON_TO_CSHARP
{

    [TestClass]
    public class Test_1_5_SETTINGS_FIELDS_JSONPROPERTY
    {

        [TestMethod]
        public void Run()
        {
            string path       = Directory.GetCurrentDirectory() + @"Test_1_5_SETTINGS_FIELDS_JSONPROPERTY_INPUT.txt";
            string resultPath = Directory.GetCurrentDirectory() + @"Test_1_5_SETTINGS_FIELDS_JSONPROPERTY_OUTPUT.txt";
            string input      = File.ReadAllText(path);

            CSharpCodeWriterConfig csharpCodeWriterConfig = new CSharpCodeWriterConfig();
            csharpCodeWriterConfig.OutputType = OutputTypes.MutableClass;
            csharpCodeWriterConfig.OutputMembers = OutputMembers.AsPublicFields;
            csharpCodeWriterConfig.AttributeUsage = JsonPropertyAttributeUsage.Always;
            csharpCodeWriterConfig.AttributeLibrary = JsonLibrary.NewtonsoftJson;
            CSharpCodeWriter csharpCodeWriter = new CSharpCodeWriter(csharpCodeWriterConfig, false);

            JsonClassGenerator jsonClassGenerator = new JsonClassGenerator(csharpCodeWriter, new DuplicateOptions() { RemoveDuplicateRoots = false, RemoveSemiDuplicates = false });

            string returnVal = jsonClassGenerator.GenerateClasses(input, true, false, out string errorMessage).ToString();
            string resultsCompare = File.ReadAllText(resultPath);
            Assert.AreEqual(resultsCompare.NormalizeOutput(), returnVal.NormalizeOutput());
        }
    }
}
