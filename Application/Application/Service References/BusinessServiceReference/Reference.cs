﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.BusinessServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HouseTypeSerializable", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class HouseTypeSerializable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HouseSerializable", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class HouseSerializable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeIdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeIdField, value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class Ticket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HouseIdSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SolvedBySerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> SolvedSerializableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTextSerializableField;
        
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
        public string EmailSerializable {
            get {
                return this.EmailSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailSerializableField, value) != true)) {
                    this.EmailSerializableField = value;
                    this.RaisePropertyChanged("EmailSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HouseIdSerializable {
            get {
                return this.HouseIdSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseIdSerializableField, value) != true)) {
                    this.HouseIdSerializableField = value;
                    this.RaisePropertyChanged("HouseIdSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdSerializable {
            get {
                return this.IdSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.IdSerializableField, value) != true)) {
                    this.IdSerializableField = value;
                    this.RaisePropertyChanged("IdSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameSerializable {
            get {
                return this.NameSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.NameSerializableField, value) != true)) {
                    this.NameSerializableField = value;
                    this.RaisePropertyChanged("NameSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneSerializable {
            get {
                return this.PhoneSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneSerializableField, value) != true)) {
                    this.PhoneSerializableField = value;
                    this.RaisePropertyChanged("PhoneSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SolvedBySerializable {
            get {
                return this.SolvedBySerializableField;
            }
            set {
                if ((this.SolvedBySerializableField.Equals(value) != true)) {
                    this.SolvedBySerializableField = value;
                    this.RaisePropertyChanged("SolvedBySerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> SolvedSerializable {
            get {
                return this.SolvedSerializableField;
            }
            set {
                if ((this.SolvedSerializableField.Equals(value) != true)) {
                    this.SolvedSerializableField = value;
                    this.RaisePropertyChanged("SolvedSerializable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserTextSerializable {
            get {
                return this.UserTextSerializableField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTextSerializableField, value) != true)) {
                    this.UserTextSerializableField = value;
                    this.RaisePropertyChanged("UserTextSerializable");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserSerializable", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class UserSerializable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="House", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class House : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Application.BusinessServiceReference.HouseType HouseTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Application.BusinessServiceReference.Ticket[] TicketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeIDField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Application.BusinessServiceReference.HouseType HouseType {
            get {
                return this.HouseTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseTypeField, value) != true)) {
                    this.HouseTypeField = value;
                    this.RaisePropertyChanged("HouseType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Application.BusinessServiceReference.Ticket[] Ticket {
            get {
                return this.TicketField;
            }
            set {
                if ((object.ReferenceEquals(this.TicketField, value) != true)) {
                    this.TicketField = value;
                    this.RaisePropertyChanged("Ticket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeID {
            get {
                return this.TypeIDField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeIDField, value) != true)) {
                    this.TypeIDField = value;
                    this.RaisePropertyChanged("TypeID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="HouseType", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class HouseType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Application.BusinessServiceReference.House[] HouseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public Application.BusinessServiceReference.House[] House {
            get {
                return this.HouseField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseField, value) != true)) {
                    this.HouseField = value;
                    this.RaisePropertyChanged("House");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusinessServiceReference.IBusinessService")]
    public interface IBusinessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouseTypes", ReplyAction="http://tempuri.org/IBusinessService/GetHouseTypesResponse")]
        Application.BusinessServiceReference.HouseTypeSerializable[] GetHouseTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouseTypes", ReplyAction="http://tempuri.org/IBusinessService/GetHouseTypesResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.HouseTypeSerializable[]> GetHouseTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouses", ReplyAction="http://tempuri.org/IBusinessService/GetHousesResponse")]
        Application.BusinessServiceReference.HouseSerializable[] GetHouses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouses", ReplyAction="http://tempuri.org/IBusinessService/GetHousesResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.HouseSerializable[]> GetHousesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouseById", ReplyAction="http://tempuri.org/IBusinessService/GetHouseByIdResponse")]
        Application.BusinessServiceReference.HouseSerializable GetHouseById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetHouseById", ReplyAction="http://tempuri.org/IBusinessService/GetHouseByIdResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.HouseSerializable> GetHouseByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetTickets", ReplyAction="http://tempuri.org/IBusinessService/GetTicketsResponse")]
        Application.BusinessServiceReference.Ticket[] GetTickets(string idSerializable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetTickets", ReplyAction="http://tempuri.org/IBusinessService/GetTicketsResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetTicketsAsync(string idSerializable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetSolvedTickets", ReplyAction="http://tempuri.org/IBusinessService/GetSolvedTicketsResponse")]
        Application.BusinessServiceReference.Ticket[] GetSolvedTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetSolvedTickets", ReplyAction="http://tempuri.org/IBusinessService/GetSolvedTicketsResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetSolvedTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetUnsolvedTickets", ReplyAction="http://tempuri.org/IBusinessService/GetUnsolvedTicketsResponse")]
        Application.BusinessServiceReference.Ticket[] GetUnsolvedTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetUnsolvedTickets", ReplyAction="http://tempuri.org/IBusinessService/GetUnsolvedTicketsResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetUnsolvedTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetUsers", ReplyAction="http://tempuri.org/IBusinessService/GetUsersResponse")]
        Application.BusinessServiceReference.UserSerializable[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/GetUsers", ReplyAction="http://tempuri.org/IBusinessService/GetUsersResponse")]
        System.Threading.Tasks.Task<Application.BusinessServiceReference.UserSerializable[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/CheckLogin", ReplyAction="http://tempuri.org/IBusinessService/CheckLoginResponse")]
        string CheckLogin(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/CheckLogin", ReplyAction="http://tempuri.org/IBusinessService/CheckLoginResponse")]
        System.Threading.Tasks.Task<string> CheckLoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/NewTicket", ReplyAction="http://tempuri.org/IBusinessService/NewTicketResponse")]
        void NewTicket(Application.BusinessServiceReference.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/NewTicket", ReplyAction="http://tempuri.org/IBusinessService/NewTicketResponse")]
        System.Threading.Tasks.Task NewTicketAsync(Application.BusinessServiceReference.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/UpdateHouse", ReplyAction="http://tempuri.org/IBusinessService/UpdateHouseResponse")]
        void UpdateHouse(Application.BusinessServiceReference.House house);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessService/UpdateHouse", ReplyAction="http://tempuri.org/IBusinessService/UpdateHouseResponse")]
        System.Threading.Tasks.Task UpdateHouseAsync(Application.BusinessServiceReference.House house);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBusinessServiceChannel : Application.BusinessServiceReference.IBusinessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BusinessServiceClient : System.ServiceModel.ClientBase<Application.BusinessServiceReference.IBusinessService>, Application.BusinessServiceReference.IBusinessService {
        
        public BusinessServiceClient() {
        }
        
        public BusinessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BusinessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Application.BusinessServiceReference.HouseTypeSerializable[] GetHouseTypes() {
            return base.Channel.GetHouseTypes();
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.HouseTypeSerializable[]> GetHouseTypesAsync() {
            return base.Channel.GetHouseTypesAsync();
        }
        
        public Application.BusinessServiceReference.HouseSerializable[] GetHouses() {
            return base.Channel.GetHouses();
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.HouseSerializable[]> GetHousesAsync() {
            return base.Channel.GetHousesAsync();
        }
        
        public Application.BusinessServiceReference.Ticket[] GetTickets(string idSerializable) {
            return base.Channel.GetTickets(idSerializable);
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetTicketsAsync(string idSerializable) {
            return base.Channel.GetTicketsAsync(idSerializable);
        }
        
        public Application.BusinessServiceReference.Ticket[] GetSolvedTickets() {
            return base.Channel.GetSolvedTickets();
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetSolvedTicketsAsync() {
            return base.Channel.GetSolvedTicketsAsync();
        }
        
        public Application.BusinessServiceReference.Ticket[] GetUnsolvedTickets() {
            return base.Channel.GetUnsolvedTickets();
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.Ticket[]> GetUnsolvedTicketsAsync() {
            return base.Channel.GetUnsolvedTicketsAsync();
        }
        
        public Application.BusinessServiceReference.UserSerializable[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<Application.BusinessServiceReference.UserSerializable[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public string CheckLogin(string email, string password) {
            return base.Channel.CheckLogin(email, password);
        }
        
        public System.Threading.Tasks.Task<string> CheckLoginAsync(string email, string password) {
            return base.Channel.CheckLoginAsync(email, password);
        }
        
        public void NewTicket(Application.BusinessServiceReference.Ticket ticket) {
            base.Channel.NewTicket(ticket);
        }
        
        public System.Threading.Tasks.Task NewTicketAsync(Application.BusinessServiceReference.Ticket ticket) {
            return base.Channel.NewTicketAsync(ticket);
        }
        
        public void UpdateHouse(Application.BusinessServiceReference.House house) {
            base.Channel.UpdateHouse(house);
        }
        
        public System.Threading.Tasks.Task UpdateHouseAsync(Application.BusinessServiceReference.House house) {
            return base.Channel.UpdateHouseAsync(house);
        }
    }
}
