using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace SPMeta2.VS.Visualizers.Impl
{
    public class M2ModelDialogDebuggerVisualizerService
    {
        public static bool ShouldThrowException { get; set; }
        public static bool HadException { get; set; }

        public void SerializeDataToStream(object target, Stream outgoingData)
        {
            try
            {
                if (target != null)
                {
                    var xml = SPMeta2Model.ToXML(((ModelNode)target));

                    var writer = new StreamWriter(outgoingData);
                    writer.WriteLine(xml);
                    writer.Flush();
                }

                if (ShouldThrowException)
                {
                    HadException = true;
                    throw new ApplicationException("ShouldThrowException = true");
                }
            }
            catch (Exception)
            {
                throw;
                // TODO
            }
        }

        public T DeserializeDataFromStream<T>(Stream stream)
            where T : class, new()
        {
            try
            {
                if (stream != null)
                {
                    var modelXml = new StreamReader(stream).ReadToEnd();

                    if (!string.IsNullOrEmpty(modelXml))
                    {
                        return SPMeta2Model.FromXML(modelXml) as T;
                    }
                }

                if (ShouldThrowException)
                {
                    HadException = true;
                    throw new ApplicationException("ShouldThrowException = true");
                }
            }
            catch (Exception)
            {
                // TODO

                return null;
            }

            return null;
        }
    }
}
