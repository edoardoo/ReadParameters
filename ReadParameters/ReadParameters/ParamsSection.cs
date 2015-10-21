﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadParameters {
    class ParamsSection {

        private string name;
        private List<Parameter> sectionParameters = new List<Parameter>();
        public ParamsSection( string name ) {
            this.name = name;
        }
        
        public void addParameter( string key, string value) {

            Parameter newParam = new Parameter(key, value);
            sectionParameters.Add(newParam);
        }
        public void removeParameter( string key) {

            sectionParameters.RemoveAt(getParameterIndex( key ));

        }
        private int getParameterIndex( string key) {

            return sectionParameters.FindIndex(a => a.getKey() == key);
        }
        public string getName() {
            return this.name;
        }
        public List <Parameter> getAllParameters() {
            return this.sectionParameters;
        }
       


    }
}
