﻿using System;
namespace Test
{
    public class UserEntry
    {
        public string Vorname = "";
        public string Nachname = "";
        public string Strasse = "";
        public string Hausnummer = "";
        public string Telefon = "";
        public string Email = "";
        public string OrtID = "";
        public string OrtName = "";
        public string Plz = "";
        public UserEntry(string Vorname, string Nachname, string Strasse, string Hausnummer, string Telefon, string Email, string OrtID, string OrtName, string Plz)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Strasse = Strasse;
            this.Hausnummer = Hausnummer;
            this.Telefon = Telefon;
            this.Email = Email;
            this.OrtID = OrtID;
            this.OrtName = OrtName;
            this.Plz = Plz;
        }
    }
}

