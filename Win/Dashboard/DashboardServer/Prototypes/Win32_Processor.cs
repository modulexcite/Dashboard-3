// <auto-generated>
// This code was generated by a tool.
// LinqToWmi.ClassGenerator Version: 1.0.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if  the code is regenerated.
//</auto-generated>
namespace WmiEntities {
    using System;
    using System.Linq;
    using LinqToWmi.Core.WMI;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("LinqToWmi.ClassGenerator", "1.0.0.0")]
    public class Win32_Processor {
        
        private ushort _addresswidth;
        
        private ushort _architecture;
        
        private ushort _availability;
        
        private string _caption;
        
        private uint _configmanagererrorcode;
        
        private bool _configmanageruserconfig;
        
        private ushort _cpustatus;
        
        private string _creationclassname;
        
        private uint _currentclockspeed;
        
        private ushort _currentvoltage;
        
        private ushort _datawidth;
        
        private string _description;
        
        private string _deviceid;
        
        private bool _errorcleared;
        
        private string _errordescription;
        
        private uint _extclock;
        
        private ushort _family;
        
        private System.DateTime _installdate;
        
        private uint _l2cachesize;
        
        private uint _l2cachespeed;
        
        private uint _lasterrorcode;
        
        private ushort _level;
        
        private ushort _loadpercentage;
        
        private string _manufacturer;
        
        private uint _maxclockspeed;
        
        private string _name;
        
        private string _otherfamilydescription;
        
        private string _pnpdeviceid;
        
        private ushort[] _powermanagementcapabilities;
        
        private bool _powermanagementsupported;
        
        private string _processorid;
        
        private ushort _processortype;
        
        private ushort _revision;
        
        private string _role;
        
        private string _socketdesignation;
        
        private string _status;
        
        private ushort _statusinfo;
        
        private string _stepping;
        
        private string _systemcreationclassname;
        
        private string _systemname;
        
        private string _uniqueid;
        
        private ushort _upgrademethod;
        
        private string _version;
        
        private uint _voltagecaps;
        
        /// <summary>
        /// Represents the property AddressWidth
        /// </summary>
        public virtual ushort AddressWidth {
            get {
                return this._addresswidth;
            }
            set {
                this._addresswidth = value;
            }
        }
        
        /// <summary>
        /// Represents the property Architecture
        /// </summary>
        public virtual ushort Architecture {
            get {
                return this._architecture;
            }
            set {
                this._architecture = value;
            }
        }
        
        /// <summary>
        /// Represents the property Availability
        /// </summary>
        public virtual ushort Availability {
            get {
                return this._availability;
            }
            set {
                this._availability = value;
            }
        }
        
        /// <summary>
        /// Represents the property Caption
        /// </summary>
        public virtual string Caption {
            get {
                return this._caption;
            }
            set {
                this._caption = value;
            }
        }
        
        /// <summary>
        /// Represents the property ConfigManagerErrorCode
        /// </summary>
        public virtual uint ConfigManagerErrorCode {
            get {
                return this._configmanagererrorcode;
            }
            set {
                this._configmanagererrorcode = value;
            }
        }
        
        /// <summary>
        /// Represents the property ConfigManagerUserConfig
        /// </summary>
        public virtual bool ConfigManagerUserConfig {
            get {
                return this._configmanageruserconfig;
            }
            set {
                this._configmanageruserconfig = value;
            }
        }
        
        /// <summary>
        /// Represents the property CpuStatus
        /// </summary>
        public virtual ushort CpuStatus {
            get {
                return this._cpustatus;
            }
            set {
                this._cpustatus = value;
            }
        }
        
        /// <summary>
        /// Represents the property CreationClassName
        /// </summary>
        public virtual string CreationClassName {
            get {
                return this._creationclassname;
            }
            set {
                this._creationclassname = value;
            }
        }
        
        /// <summary>
        /// Represents the property CurrentClockSpeed
        /// </summary>
        public virtual uint CurrentClockSpeed {
            get {
                return this._currentclockspeed;
            }
            set {
                this._currentclockspeed = value;
            }
        }
        
        /// <summary>
        /// Represents the property CurrentVoltage
        /// </summary>
        public virtual ushort CurrentVoltage {
            get {
                return this._currentvoltage;
            }
            set {
                this._currentvoltage = value;
            }
        }
        
        /// <summary>
        /// Represents the property DataWidth
        /// </summary>
        public virtual ushort DataWidth {
            get {
                return this._datawidth;
            }
            set {
                this._datawidth = value;
            }
        }
        
        /// <summary>
        /// Represents the property Description
        /// </summary>
        public virtual string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        /// <summary>
        /// Represents the property DeviceID
        /// </summary>
        public virtual string DeviceID {
            get {
                return this._deviceid;
            }
            set {
                this._deviceid = value;
            }
        }
        
        /// <summary>
        /// Represents the property ErrorCleared
        /// </summary>
        public virtual bool ErrorCleared {
            get {
                return this._errorcleared;
            }
            set {
                this._errorcleared = value;
            }
        }
        
        /// <summary>
        /// Represents the property ErrorDescription
        /// </summary>
        public virtual string ErrorDescription {
            get {
                return this._errordescription;
            }
            set {
                this._errordescription = value;
            }
        }
        
        /// <summary>
        /// Represents the property ExtClock
        /// </summary>
        public virtual uint ExtClock {
            get {
                return this._extclock;
            }
            set {
                this._extclock = value;
            }
        }
        
        /// <summary>
        /// Represents the property Family
        /// </summary>
        public virtual ushort Family {
            get {
                return this._family;
            }
            set {
                this._family = value;
            }
        }
        
        /// <summary>
        /// Represents the property InstallDate
        /// </summary>
        public virtual System.DateTime InstallDate {
            get {
                return this._installdate;
            }
            set {
                this._installdate = value;
            }
        }
        
        /// <summary>
        /// Represents the property L2CacheSize
        /// </summary>
        public virtual uint L2CacheSize {
            get {
                return this._l2cachesize;
            }
            set {
                this._l2cachesize = value;
            }
        }
        
        /// <summary>
        /// Represents the property L2CacheSpeed
        /// </summary>
        public virtual uint L2CacheSpeed {
            get {
                return this._l2cachespeed;
            }
            set {
                this._l2cachespeed = value;
            }
        }
        
        /// <summary>
        /// Represents the property LastErrorCode
        /// </summary>
        public virtual uint LastErrorCode {
            get {
                return this._lasterrorcode;
            }
            set {
                this._lasterrorcode = value;
            }
        }
        
        /// <summary>
        /// Represents the property Level
        /// </summary>
        public virtual ushort Level {
            get {
                return this._level;
            }
            set {
                this._level = value;
            }
        }
        
        /// <summary>
        /// Represents the property LoadPercentage
        /// </summary>
        public virtual ushort LoadPercentage {
            get {
                return this._loadpercentage;
            }
            set {
                this._loadpercentage = value;
            }
        }
        
        /// <summary>
        /// Represents the property Manufacturer
        /// </summary>
        public virtual string Manufacturer {
            get {
                return this._manufacturer;
            }
            set {
                this._manufacturer = value;
            }
        }
        
        /// <summary>
        /// Represents the property MaxClockSpeed
        /// </summary>
        public virtual uint MaxClockSpeed {
            get {
                return this._maxclockspeed;
            }
            set {
                this._maxclockspeed = value;
            }
        }
        
        /// <summary>
        /// Represents the property Name
        /// </summary>
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        /// <summary>
        /// Represents the property OtherFamilyDescription
        /// </summary>
        public virtual string OtherFamilyDescription {
            get {
                return this._otherfamilydescription;
            }
            set {
                this._otherfamilydescription = value;
            }
        }
        
        /// <summary>
        /// Represents the property PNPDeviceID
        /// </summary>
        public virtual string PNPDeviceID {
            get {
                return this._pnpdeviceid;
            }
            set {
                this._pnpdeviceid = value;
            }
        }
        
        /// <summary>
        /// Represents the property PowerManagementCapabilities
        /// </summary>
        public virtual ushort[] PowerManagementCapabilities {
            get {
                return this._powermanagementcapabilities;
            }
            set {
                this._powermanagementcapabilities = value;
            }
        }
        
        /// <summary>
        /// Represents the property PowerManagementSupported
        /// </summary>
        public virtual bool PowerManagementSupported {
            get {
                return this._powermanagementsupported;
            }
            set {
                this._powermanagementsupported = value;
            }
        }
        
        /// <summary>
        /// Represents the property ProcessorId
        /// </summary>
        public virtual string ProcessorId {
            get {
                return this._processorid;
            }
            set {
                this._processorid = value;
            }
        }
        
        /// <summary>
        /// Represents the property ProcessorType
        /// </summary>
        public virtual ushort ProcessorType {
            get {
                return this._processortype;
            }
            set {
                this._processortype = value;
            }
        }
        
        /// <summary>
        /// Represents the property Revision
        /// </summary>
        public virtual ushort Revision {
            get {
                return this._revision;
            }
            set {
                this._revision = value;
            }
        }
        
        /// <summary>
        /// Represents the property Role
        /// </summary>
        public virtual string Role {
            get {
                return this._role;
            }
            set {
                this._role = value;
            }
        }
        
        /// <summary>
        /// Represents the property SocketDesignation
        /// </summary>
        public virtual string SocketDesignation {
            get {
                return this._socketdesignation;
            }
            set {
                this._socketdesignation = value;
            }
        }
        
        /// <summary>
        /// Represents the property Status
        /// </summary>
        public virtual string Status {
            get {
                return this._status;
            }
            set {
                this._status = value;
            }
        }
        
        /// <summary>
        /// Represents the property StatusInfo
        /// </summary>
        public virtual ushort StatusInfo {
            get {
                return this._statusinfo;
            }
            set {
                this._statusinfo = value;
            }
        }
        
        /// <summary>
        /// Represents the property Stepping
        /// </summary>
        public virtual string Stepping {
            get {
                return this._stepping;
            }
            set {
                this._stepping = value;
            }
        }
        
        /// <summary>
        /// Represents the property SystemCreationClassName
        /// </summary>
        public virtual string SystemCreationClassName {
            get {
                return this._systemcreationclassname;
            }
            set {
                this._systemcreationclassname = value;
            }
        }
        
        /// <summary>
        /// Represents the property SystemName
        /// </summary>
        public virtual string SystemName {
            get {
                return this._systemname;
            }
            set {
                this._systemname = value;
            }
        }
        
        /// <summary>
        /// Represents the property UniqueId
        /// </summary>
        public virtual string UniqueId {
            get {
                return this._uniqueid;
            }
            set {
                this._uniqueid = value;
            }
        }
        
        /// <summary>
        /// Represents the property UpgradeMethod
        /// </summary>
        public virtual ushort UpgradeMethod {
            get {
                return this._upgrademethod;
            }
            set {
                this._upgrademethod = value;
            }
        }
        
        /// <summary>
        /// Represents the property Version
        /// </summary>
        public virtual string Version {
            get {
                return this._version;
            }
            set {
                this._version = value;
            }
        }
        
        /// <summary>
        /// Represents the property VoltageCaps
        /// </summary>
        public virtual uint VoltageCaps {
            get {
                return this._voltagecaps;
            }
            set {
                this._voltagecaps = value;
            }
        }
    }
}
