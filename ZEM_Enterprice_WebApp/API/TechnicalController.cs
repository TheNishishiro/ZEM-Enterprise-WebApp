﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZEM_Enterprice_WebApp.Data;
using ZEM_Enterprice_WebApp.Data.Tables;
using ZEM_Enterprice_WebApp.Pages.Department.Scanner;
using ZEM_Enterprice_WebApp.Scanning;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZEM_Enterprice_WebApp.API
{
    [Route("api/scannerInfo")]
    [ApiController]
    public class TechnicalController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public TechnicalController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Returns all records for technical department table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Technical>>> GetTech()
        {
            return await _db.Technical.ToListAsync();
        }

        /// <summary>
        /// Returns BIN for given cut-code
        /// </summary>
        /// <param name="przewod">Cable cut-code</param>
        /// <returns></returns>
        [HttpGet("{przewod}")]
        public async Task<ActionResult<PacketToSend>> GetTech(string przewod)
        {
            var result = await _db.Technical.FirstOrDefaultAsync(c => c.PrzewodCiety == przewod);

            PacketToSend pts = new PacketToSend
            {
                StatusCode = 1,
            };

            if (result == null)
            { 
                pts.StatusCode = 0;
                return pts;
            }

            pts.BIN = result.BIN;

            return pts;
        }


        /// <summary>
        /// Manages scanning for web application
        /// </summary>
        /// <param name="kodWiazkiTextbox">Cable cut-code</param>
        /// <param name="forcedQuantity">Amount manualy inserted by user scanning</param>
        /// <param name="isLookingBack">Flag to control lookback for scans</param>
        /// <param name="dostDay">Day of delivery</param>
        /// <param name="dostMonth">Month of delivery</param>
        /// <param name="dostYear">Year of delivery</param>
        /// <param name="dokDostawy">Delivery document number</param>
        /// <param name="isForcedQuantity"></param>
        /// <param name="isForcedOverLimit"></param>
        /// <param name="isForcedBackAck"></param>
        /// <param name="isForcedBack"></param>
        /// <param name="isForcedInsert"></param>
        /// <param name="isForcedUndeclared"></param>
        /// <param name="User"></param>
        /// <returns></returns>
        [HttpGet("{kodWiazkiTextbox},{forcedQuantity},{isLookingBack},{dostYear}-{dostMonth}-{dostDay},{dokDostawy}," +
            "{isForcedQuantity},{isForcedOverLimit}," +
            "{isForcedBackAck},{isForcedBack},{isForcedInsert},{isForcedUndeclared}," +
            "{User}")]
        public async Task<ActionResult<ScannedResponse>> GetTech(
            string kodWiazkiTextbox,
            int forcedQuantity,
            bool isLookingBack,
            int dostDay, int dostMonth, int dostYear,
            string dokDostawy,
            bool isForcedQuantity,
            bool isForcedOverLimit,
            bool isForcedBackAck,
            bool isForcedBack,
            bool isForcedInsert,
            bool isForcedUndeclared,
            string User
            )
        {
            VTInsertFunctions VTFuncs = new VTInsertFunctions(_db);
            ScannedResponse response = new ScannedResponse();
            ScannedCode sc = new ScannedCode();
            sc.kodCiety = kodWiazkiTextbox.Replace("PLC", "").ToUpper().Trim().Substring(0,8);
            if(forcedQuantity == 0)
                sc.sztukiSkanowane = int.Parse(kodWiazkiTextbox.Replace("PLC", "").ToUpper().Trim().Substring(8));
            else
                sc.sztukiSkanowane = forcedQuantity;
            sc.isLookingBack = isLookingBack;
            sc.dataDostawy = new DateTime(dostYear, dostMonth, dostDay);
            sc.DokDostawy = dokDostawy;
            sc.isForcedQuantity = isForcedQuantity;
            sc.isForcedOverLimit = isForcedOverLimit;
            sc.isForcedBackAck = isForcedBackAck;
            sc.isForcedBack = isForcedBack;
            sc.isForcedInsert = isForcedInsert;
            sc.isForcedUndeclared = isForcedUndeclared;
            sc.User = User;
            sc.Declared = false;
            sc.complete = false;
            sc.isFullSet = false;
            sc.addedBefore = false;
            sc.dataDostawyOld = DateTime.MinValue;
            sc.dataDoskanowania = DateTime.Now;
            sc.dataUtworzenia = DateTime.Now;
            response.Args = new List<string>();
            response.sztukiSkanowane = sc.sztukiSkanowane;

            var techEntry = _db.Technical.IgnoreQueryFilters().FirstOrDefault(c => c.PrzewodCiety == sc.kodCiety);
            if (techEntry == null)
            {
                if (_db.MissingFromTech.Find(sc.kodCiety) == null)
                {
                    _db.MissingFromTech.Add(new MissingFromTech { DataDodania = sc.dataDoskanowania, Kod = sc.kodCiety, User = sc.User });
                    _db.SaveChanges();
                }
                response.Header = HeaderTypes.error;
                response.Flag = FlagType.notInTech;
                return response;
            }
            else if (techEntry.Deleted == true)
            {
                response.Header = HeaderTypes.error;
                response.Flag = FlagType.isDeleted;
                return response;

            }
            else if (techEntry.KanBan == true)
            {
                response.Header = HeaderTypes.error;
                response.Flag = FlagType.isKanban;
                return response;
            }

            sc.Wiazka = techEntry.Wiazka;
            sc.Rodzina = techEntry.Rodzina;

            response.PrzewodCiety = techEntry.PrzewodCiety;
            response.BIN = techEntry.BIN;
            response.KodWiazki = techEntry.KodWiazki;
            response.LiteraRodziny = techEntry.LiterRodziny;
            response.IlePrzewodow = techEntry.IlePrzewodow;

            var dostawaEntry = _db.Dostawa.FirstOrDefault(c => c.Data.Date == sc.dataDostawy.Date && c.Kod == "PLC" + sc.kodCiety);
            if (dostawaEntry != null)
            {
                sc.dataDostawy = dostawaEntry.Data;
                sc.dataDostawyOld = dostawaEntry.Data;
                sc.isFullSet = VTFuncs.CheckIfFullSetOfSupply(sc);
                sc.sztukiDeklarowane = dostawaEntry.Ilosc;
                sc.Declared = true;
                // Delivery doesn't contain any extras
                if (sc.isFullSet)
                {
                    // if codes to complete set are missing check back
                    if (sc.sztukiSkanowane == sc.sztukiDeklarowane)
                    {
                        if (!VTFuncs.CheckBackOrAdd(response, techEntry, sc, dostawaEntry))
                            return response;
                    }
                    else if (sc.sztukiSkanowane != sc.sztukiDeklarowane)
                    {
                        if (!VTFuncs.CheckBackOrAddQuantityIncorrect(response, techEntry, sc, dostawaEntry))
                            return response;
                    }
                }
                else // Delivery does contain extras
                {
                    if (sc.sztukiSkanowane == sc.sztukiDeklarowane)
                    {
                        if (!VTFuncs.CheckBackOrAdd(response, techEntry, sc, dostawaEntry))
                            return response;
                    }
                    else if (sc.sztukiSkanowane != sc.sztukiDeklarowane)
                    {
                        if (!VTFuncs.CheckBackOrAddQuantityIncorrect(response, techEntry, sc, dostawaEntry))
                            return response;
                    }
                }
            }
            else
            {
                sc.dataDostawyOld = sc.dataDostawy;
                if (!sc.isForcedUndeclared)
                {
                    response.Header = HeaderTypes.error;
                    response.Flag = FlagType.notInDeclared;
                    return response;
                }
                else
                {
                    if (!sc.isForcedQuantity)
                    {
                        response.Header = HeaderTypes.error;
                        response.Flag = FlagType.quantityIncorrect;
                        response.Args.Add("0");
                        var vt = VTFuncs.ExistsInVT(sc);
                        if (vt != null)
                            response.Args.Add(vt.SztukiZeskanowane.ToString());
                        else
                            response.Args.Add("0");
                        return response;
                    }
                    else
                    {
                        if (!VTFuncs.CheckBackOrAddQuantityIncorrect(response, techEntry, sc, dostawaEntry))
                            return response;
                    }
                }
            }

            _db.SaveChanges();

            bool isComplete = VTFuncs.checkComplete(sc, out int numToComplete, out int numScanned, out int numScannedToComplete);

            response.DataDostawy = sc.dataDostawy;
            response.DataDostawyOld = sc.dataDostawyOld;
            response.numToComplete = numToComplete;
            response.numScanned = numScanned;
            response.numScannedToComplete = numScannedToComplete;
            response.isComplete = isComplete;
            response.sztukiDeklatowane = sc.sztukiDeklarowane;
            response.numerKompletu = sc.NumerKompletu;
            response.Wiazka = sc.Wiazka;
            response.Rodzina = sc.Rodzina;
            response.sztukiSkanowane = sc.sztukiSkanowane;


            return response;
        }

        public class PacketToSend
        {
            public int StatusCode { get; set; }
            public string PrzewodCiety { get; set; }
            public string BIN { get; set; }
            public string KodWiazki { get; set; }
            public string LiterRodziny { get; set; }
            public string IlePrzewodow { get; set; }
        }
    }
}