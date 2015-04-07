﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BackupAddInCommon
{
    /// <summary>
    ///  Class holding the configuration options
    /// </summary>
    [Serializable()]
    public class BackupSettings
    {
        /// <summary>
        ///  Default constructor
        /// </summary>
        public BackupSettings()
        {
            Items = new StringCollection();
            IgnoreEncryption = false;
            CountdownSeconds = 0;
        }

        /// <summary>
        ///  Destination path for the backup files
        /// </summary>
        public string DestinationPath { get; set; }

        /// <summary>
        ///  Program to run after exiting outlook
        /// </summary>
        public string BackupProgram { get; set; }

        /// <summary>
        ///  Interval in days when to run the backup program again
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        ///  Date of the last run of backup
        /// </summary>
        public DateTime LastRun { get; set; }

        /// <summary>
        ///  List of files to backup
        /// </summary>
        public StringCollection Items;

        /// <summary>
        ///  Wait time when file is locked
        /// </summary>
        public int WaitTimeFileLock = 500;

        /// <summary>
        ///  Prefix for filename of backup
        /// </summary>
        public string BackupPrefix  { get; set; }

        /// <summary>
        ///  Suffix for filename of backup
        /// </summary>
        public string BackupSuffix  { get; set; }

        /// <summary>
        ///  Flag whether to backup all psd-files
        /// </summary>
        public bool BackupAll { get; set; }

        /// <summary>
        ///  Command to run after backup finished
        /// </summary>
        public string PostBackupCmd { get; set; }

        /// <summary>
        ///  Try to decode path to OST-files
        /// </summary>
        public bool ShowOSTFiles { get; set; }

        /// <summary>
        ///  Flag whether encrypted files might get decrypted
        /// </summary>
        public bool IgnoreEncryption { get; set; }

        /// <summary>
        ///  Counter to give user opportunity to close window before backup starts
        /// </summary>
        private int countdownSeconds;

        /// <summary>
        ///  Counter to give user opportunity to close window before backup starts
        /// </summary>
        public int CountdownSeconds
        {  
            get
            {
                return countdownSeconds;
            } 
            set
            {
                if (value >= 0 && value <= 100)
                     countdownSeconds = value;
                else countdownSeconds = 0;
            } 
        }
    }
}
