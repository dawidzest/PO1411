﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class FormularzPracyDypModel
    {
        /// <summary>
        /// unique identifier for a given form 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// path to a txt/pdf file 
        /// </summary>
        public string path { get; set; }
    }
}
