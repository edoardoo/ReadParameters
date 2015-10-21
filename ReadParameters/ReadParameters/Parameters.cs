using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadParameters {
    class Parameters {
        private static string CONFIG_FILE = "..\\..\\..\\..\\PARAMS.CFG";
        private List<ParamsSection> parameters = new List<ParamsSection>();
        public Parameters() {

        }
        private void readFile() {
            try {
                using (StreamReader sr = new StreamReader(CONFIG_FILE)) {
                    //Leemos el Stream del fichero

                    int counter = 0;
                    string line;
                    List<string> listOfLines = new List<string>();
                   
                    while ((line = sr.ReadLine()) != null) {
                        listOfLines.Add(line);
                        counter++;
                    }

                    sr.Close();                   
                    parseParams(listOfLines);
                    
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }
            
        }
     
        private void parseParams(List<string> paramFileLines) {


            int counterSection = 0;
            //TODO: yes, if it has a line with just a comment it crashes.

            for (int i = 0; i < paramFileLines.Count(); i++) {
                string stringedName = paramFileLines[i].ToString();
                
                if (stringedName.Contains("[") || stringedName.Contains("]")) {
                    string name = cleanSectionName( stringedName );
                    ParamsSection ps = new ParamsSection(name);

                    parameters.Add(ps);
                    
                } else if(stringedName.Split(';')[0].Contains('=')  ) {
                    string [] paramKeyValue = getKeyValueParameter(stringedName);
                    int sectionIndex = parameters.Count();
                    parameters[sectionIndex-1].addParameter(paramKeyValue[0], paramKeyValue[1]);
                }
                


            }

    //            
            
        }
        private string cleanSectionName( string dirtyName ) {
            dirtyName = dirtyName.Replace("[", "");
            dirtyName = dirtyName.Replace("]", "");
            dirtyName = dirtyName.Replace("_", " ");

            return dirtyName;
        
        }

        private string [] getKeyValueParameter( string wholeParameter) {
            string[] splitted = wholeParameter.Split('=');
            splitted[1] = splitted[1].Split(';')[0];
            return splitted;
        }
        public string getFormattedParams() {
            readFile();
          
            string parametersText = "";
            string newLine = Environment.NewLine;
            for( int j = 0; j< parameters.Count(); j++) {
                parametersText += newLine + parameters[j].getName() + newLine;
                parametersText += "----------------------------------" + newLine;

                for (int i = 0; i < parameters[j].getAllParameters().Count(); i++) {
                    string name = parameters[j].getAllParameters()[i].getKey();
                    string value = parameters[j].getAllParameters()[i].getValue();
                    parametersText += name + " : " + value + newLine;

                }
            }
            return parametersText;
        }

    }
    
}
