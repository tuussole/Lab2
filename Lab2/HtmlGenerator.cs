using Lab2.Models;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class HtmlGenerator
    {
        private static string Key = Guid.NewGuid().ToString();

        public string Generate(IEnumerable<ScientificWork> works)
        {
            var template = ReadTemplate();
            var result = Engine.Razor.RunCompile(template, Key, typeof(List<ScientificWork>), works);

            return result;
        }

        private string ReadTemplate()
        {
            return File.ReadAllText(Consts.HtmlTemplateLocation);
        }
    }
}
