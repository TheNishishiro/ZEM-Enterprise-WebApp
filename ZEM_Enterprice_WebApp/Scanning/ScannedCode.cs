﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZEM_Enterprice_WebApp.Scanning
{
    /// <summary>
    /// Class to contain most informations during scanning process
    /// </summary>
    public class ScannedCode
    {
        public bool Declared { get; set; }
        public string User { get; set; }
        public string BIN { get; set; }
        public string kodDostawy { get; set; }
        public string kodCiety { get; set; }
        public string kodCietyFull { get; set; }
        public string Wiazka { get; set; }
        public string Rodzina { get; set; }
        public int sztukiSkanowane { get; set; }
        public int sztukiDeklarowane { get; set; }
        public DateTime dataDostawy { get; set; }
        public DateTime dataUtworzenia { get; set; }
        public DateTime dataDostawyOld { get; set; }
        public DateTime dataDoskanowania { get; set; }
        public bool complete { get; set; }
        public DateTime? DataDopisu { get; set; }
        public int DopisanaIlosc { get; set; }
        public string DostawaDopis { get; set; }
        public string Uwagi { get; set; }
        public string DokDostawy { get; set; }
        public int NumerKompletu { get; set; }
        public bool isForcedDeclaredQuantity { get; set; }
        public bool isFullSet { get; set; }
        public bool isForcedQuantity { get; set; }
        public bool isForcedOverLimit { get; set; }
        public bool isForcedBackAck { get; set; }
        public bool isForcedBack { get; set; }
        public bool isForcedInsert { get; set; }
        public bool isForcedUndeclared { get; set; }
        public bool isForcedOverDeclared { get; set; }
        public bool addedBefore { get; set; }
        public bool isLookingBack { get; set; }
    }
}
