using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Schema;

namespace HolisticWare.XamarinForms.Tools.XamlObjectModelScraper.EXE_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] files_xaml_to_infer =
					System.IO.Directory.GetFiles
					(
					  ".",
					  "*.xaml",
					  System.IO.SearchOption.AllDirectories
					 );


			//http://quickstarts.asp.net/QuickStartv20/util/srcview.aspx?path=~/howto/samples/Xml/XmlSchemaInference/XmlSchemaInference.src&file=CS%5CXmlSchemaInference%5CXmlSchemaInference.cs&lang=C%23+Source

			List<XmlSchemaSet> xml_schamesets = new List<XmlSchemaSet>();
			XmlSchemaSet xml_schemaset_single = null;
			XmlSchemaSet xml_schemaset_inferred = null;
			XmlSchemaInference inference = new XmlSchemaInference();
			XmlWriter xml_writer = null;
			XmlWriterSettings writter_settings = new XmlWriterSettings()
			{
				ConformanceLevel = ConformanceLevel.Auto
			};

			int i = 1;
			foreach(string filename in files_xaml_to_infer)
			{
				Console.WriteLine("filename");
				string filename_schema = @".\xamarin-forms" + i.ToString("d4") + ".xsd";

				XmlReader reader = XmlReader.Create(filename);

				// Use the additional data in xml to get the schema.
				xml_schemaset_single =  new XmlSchemaSet();
				xml_schemaset_single = inference.InferSchema(reader);
				xml_schamesets.Add(xml_schemaset_single);

				//write the new schema to file
				xml_writer = XmlWriter.Create
										(
										new System.IO.StreamWriter(filename_schema),
											writter_settings
										);
				System.IO.TextWriter text_writer = null;
				j = 1;
				foreach (XmlSchema schema in xml_schemaset_single.Schemas())
				{
					schema.Write(xml_writer);

					j++;
					Console.WriteLine("\t\t XSD = " + filename_schema);
				}



				xml_schemaset_inferred = inference.InferSchema(reader, xml_schemaset_inferred);


				xml_writer.Flush();
				xml_writer.Close();

				i++;
			}


			// Display the inferred schema.
			Console.WriteLine("Original schema:\n");

		}
	}
}
