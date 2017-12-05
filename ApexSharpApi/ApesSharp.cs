﻿using System;
using System.IO;

namespace ApexSharpApi
{
    public class ApexSharp
    {
        private readonly ApexSharpConfig _apexSharpConfigSettings = new ApexSharpConfig();

        // Double Check For All These Values
        public ApexSharpConfig CreateSession()
        {
            DirectoryInfo vsProjectLocation = new DirectoryInfo(_apexSharpConfigSettings.VsProjectLocation);
            Console.WriteLine(vsProjectLocation.Exists);

            DirectoryInfo salesForceLocation = new DirectoryInfo(_apexSharpConfigSettings.SalesForceLocation);
            Console.WriteLine(salesForceLocation.Exists);

            FileInfo configLocation = new FileInfo(_apexSharpConfigSettings.ConfigLocation);
            DirectoryInfo configDirectory = configLocation.Directory;
            Console.WriteLine(configDirectory.Exists);

            Directory.CreateDirectory(_apexSharpConfigSettings.VsProjectLocation + "CSharpClasses");
            Directory.CreateDirectory(_apexSharpConfigSettings.VsProjectLocation + "NoApex");
            Directory.CreateDirectory(_apexSharpConfigSettings.VsProjectLocation + "Cache");
            Directory.CreateDirectory(_apexSharpConfigSettings.VsProjectLocation + "SObjects");
            return ConnectionUtil.CreateSession(_apexSharpConfigSettings);
        }

        public ApexSharp SalesForceUrl(string salesForceUrl)
        {
            _apexSharpConfigSettings.SalesForceUrl = salesForceUrl;
            return this;
        }

        public ApexSharp WithUserId(string salesForceUserId)
        {
            _apexSharpConfigSettings.SalesForceUserId = salesForceUserId;
            return this;
        }

        public ApexSharp AndPassword(string salesForcePassword)
        {
            _apexSharpConfigSettings.SalesForcePassword = salesForcePassword;
            return this;
        }

        public ApexSharp AndToken(string salesForcePasswordToken)
        {
            _apexSharpConfigSettings.SalesForcePasswordToken = salesForcePasswordToken;
            return this;
        }
        public ApexSharp AndSalesForceApiVersion(int apiVersion)
        {
            _apexSharpConfigSettings.SalesForceApiVersion = apiVersion;
            return this;
        }
        public ApexSharp AddHttpProxy(string httpProxy)
        {
            _apexSharpConfigSettings.HttpProxy = httpProxy;
            return this;
        }

        public ApexSharp VsProjectLocation(string dirLocation)
        {
            _apexSharpConfigSettings.VsProjectLocation = dirLocation;
            return this;
        }

        public ApexSharp SalesForceLocation(string dirLocation)
        {
            _apexSharpConfigSettings.SalesForceLocation = dirLocation;
            return this;
        }


        public ApexSharp SaveConfigAt(string configFile)
        {
            _apexSharpConfigSettings.ConfigLocation = configFile;
            return this;
        }
    }
}