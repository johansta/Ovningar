﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5_Data_Access_Layer.Vehicles
{
    public class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Boat(String licence, int numberOfEngines) : base(licence)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override String ToString()
        {
            return base.ToString() + Environment.NewLine + "NumberOfEngines: " + NumberOfEngines;
        }
     
        public new static List<ParameterInfo> GetParameters()
        {
            ParameterInfo parameterInfo = new ParameterInfo();
            parameterInfo.name = "NumberOfEngines";
            parameterInfo.type = typeof(int);

            List<ParameterInfo> parameters = Vehicle.GetParameters();
            parameters.Add(parameterInfo);

            return parameters;
        }
    }
}
