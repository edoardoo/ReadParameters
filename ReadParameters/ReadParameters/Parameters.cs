using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadParameters {
    class Parameters {
        private static string CONFIG_FILE = "PARAMS.CFG";
        private List<ParamsSection> parameters;
        public Parameters() {

        }
        private void readFile() {
            try {

                using (FileStream fsSource = new FileStream(CONFIG_FILE,
                    FileMode.Open, FileAccess.Read)) {

                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];

                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0) {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;
                    parseParams(bytes);
                    
                }
            } catch (FileNotFoundException ioEx) {
                Console.WriteLine(ioEx.Message);
            }
        }
        private void parseParams( byte [] arrayedParamFile ) {

            bool newSection = false;
            bool oldSection = false;
            string newSectionName = "";
            //TODO: got to do it while I'm relaxed.
            for (int i =0; i< arrayedParamFile.Length; i++) {

                if (newSection && !oldSection) {
                    newSectionName += arrayedParamFile[i];
                }
                if (!oldSection) {
                    Console.WriteLine(newSectionName);
                }
                oldSection = newSection;
                newSection = (arrayedParamFile[i].ToString() == "[" || (newSection && arrayedParamFile[i].ToString() != "]")) ? true : false;
                
            }
        }
        public string getFormattedParams() {
            for(int i = 0; i< parameters.Count(); i++) {
                string sectionName = parameters[i].getName();
                List<Parameter> sectionParameters = parameters[i].getAllParameters();
                //TODO: compose formatted string 
            }
            return "";
        }

    }
    
}
