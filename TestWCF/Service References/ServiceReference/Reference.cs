﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCF.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    [System.SerializableAttribute()]
    public partial struct Point : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int xField;
        
        private int yField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int x {
            get {
                return this.xField;
            }
            set {
                if ((this.xField.Equals(value) != true)) {
                    this.xField = value;
                    this.RaisePropertyChanged("x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int y {
            get {
                return this.yField;
            }
            set {
                if ((this.yField.Equals(value) != true)) {
                    this.yField = value;
                    this.RaisePropertyChanged("y");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoldTickets", Namespace="http://schemas.datacontract.org/2004/07/CinemaLibrary")]
    [System.SerializableAttribute()]
    public partial class SoldTickets : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestWCF.ServiceReference.Orders OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeatField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Line {
            get {
                return this.LineField;
            }
            set {
                if ((this.LineField.Equals(value) != true)) {
                    this.LineField = value;
                    this.RaisePropertyChanged("Line");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestWCF.ServiceReference.Orders Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Seat {
            get {
                return this.SeatField;
            }
            set {
                if ((this.SeatField.Equals(value) != true)) {
                    this.SeatField = value;
                    this.RaisePropertyChanged("Seat");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Orders", Namespace="http://schemas.datacontract.org/2004/07/CinemaLibrary")]
    [System.SerializableAttribute()]
    public partial class Orders : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestWCF.ServiceReference.Customers Customer1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestWCF.ServiceReference.MovieSessions MovieSessionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SessionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((this.CustomerField.Equals(value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestWCF.ServiceReference.Customers Customer1 {
            get {
                return this.Customer1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Customer1Field, value) != true)) {
                    this.Customer1Field = value;
                    this.RaisePropertyChanged("Customer1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestWCF.ServiceReference.MovieSessions MovieSession {
            get {
                return this.MovieSessionField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieSessionField, value) != true)) {
                    this.MovieSessionField = value;
                    this.RaisePropertyChanged("MovieSession");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((this.SessionIdField.Equals(value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customers", Namespace="http://schemas.datacontract.org/2004/07/CinemaLibrary")]
    [System.SerializableAttribute()]
    public partial class Customers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EMailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMail {
            get {
                return this.EMailField;
            }
            set {
                if ((object.ReferenceEquals(this.EMailField, value) != true)) {
                    this.EMailField = value;
                    this.RaisePropertyChanged("EMail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieSessions", Namespace="http://schemas.datacontract.org/2004/07/CinemaLibrary")]
    [System.SerializableAttribute()]
    public partial class MovieSessions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HallField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> SessionDateTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hall {
            get {
                return this.HallField;
            }
            set {
                if ((this.HallField.Equals(value) != true)) {
                    this.HallField = value;
                    this.RaisePropertyChanged("Hall");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Movie {
            get {
                return this.MovieField;
            }
            set {
                if ((this.MovieField.Equals(value) != true)) {
                    this.MovieField = value;
                    this.RaisePropertyChanged("Movie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SessionDateTime {
            get {
                return this.SessionDateTimeField;
            }
            set {
                if ((this.SessionDateTimeField.Equals(value) != true)) {
                    this.SessionDateTimeField = value;
                    this.RaisePropertyChanged("SessionDateTime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        int Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Login", ReplyAction="http://tempuri.org/IService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string login, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSoldPlaces", ReplyAction="http://tempuri.org/IService/GetSoldPlacesResponse")]
        TestWCF.ServiceReference.Point[] GetSoldPlaces(int idFilm, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSoldPlaces", ReplyAction="http://tempuri.org/IService/GetSoldPlacesResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference.Point[]> GetSoldPlacesAsync(int idFilm, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReserveTickets", ReplyAction="http://tempuri.org/IService/ReserveTicketsResponse")]
        bool ReserveTickets(int idHall, int idFilm, System.DateTime date, TestWCF.ServiceReference.Point lineSeat, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReserveTickets", ReplyAction="http://tempuri.org/IService/ReserveTicketsResponse")]
        System.Threading.Tasks.Task<bool> ReserveTicketsAsync(int idHall, int idFilm, System.DateTime date, TestWCF.ServiceReference.Point lineSeat, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReserveByCode", ReplyAction="http://tempuri.org/IService/getReserveByCodeResponse")]
        TestWCF.ServiceReference.SoldTickets getReserveByCode(int codeReserve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReserveByCode", ReplyAction="http://tempuri.org/IService/getReserveByCodeResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference.SoldTickets> getReserveByCodeAsync(int codeReserve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReserveByNumber", ReplyAction="http://tempuri.org/IService/getReserveByNumberResponse")]
        TestWCF.ServiceReference.SoldTickets getReserveByNumber(string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReserveByNumber", ReplyAction="http://tempuri.org/IService/getReserveByNumberResponse")]
        System.Threading.Tasks.Task<TestWCF.ServiceReference.SoldTickets> getReserveByNumberAsync(string number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TestWCF.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TestWCF.ServiceReference.IService>, TestWCF.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Login(string login1, string pass) {
            return base.Channel.Login(login1, pass);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string login, string pass) {
            return base.Channel.LoginAsync(login, pass);
        }
        
        public TestWCF.ServiceReference.Point[] GetSoldPlaces(int idFilm, System.DateTime dateTime) {
            return base.Channel.GetSoldPlaces(idFilm, dateTime);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference.Point[]> GetSoldPlacesAsync(int idFilm, System.DateTime dateTime) {
            return base.Channel.GetSoldPlacesAsync(idFilm, dateTime);
        }
        
        public bool ReserveTickets(int idHall, int idFilm, System.DateTime date, TestWCF.ServiceReference.Point lineSeat, string mail) {
            return base.Channel.ReserveTickets(idHall, idFilm, date, lineSeat, mail);
        }
        
        public System.Threading.Tasks.Task<bool> ReserveTicketsAsync(int idHall, int idFilm, System.DateTime date, TestWCF.ServiceReference.Point lineSeat, string mail) {
            return base.Channel.ReserveTicketsAsync(idHall, idFilm, date, lineSeat, mail);
        }
        
        public TestWCF.ServiceReference.SoldTickets getReserveByCode(int codeReserve) {
            return base.Channel.getReserveByCode(codeReserve);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference.SoldTickets> getReserveByCodeAsync(int codeReserve) {
            return base.Channel.getReserveByCodeAsync(codeReserve);
        }
        
        public TestWCF.ServiceReference.SoldTickets getReserveByNumber(string number) {
            return base.Channel.getReserveByNumber(number);
        }
        
        public System.Threading.Tasks.Task<TestWCF.ServiceReference.SoldTickets> getReserveByNumberAsync(string number) {
            return base.Channel.getReserveByNumberAsync(number);
        }
    }
}