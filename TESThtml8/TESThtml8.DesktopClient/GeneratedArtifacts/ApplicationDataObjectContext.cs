﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 05/03/2013 0:21:17
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for ApplicationData in the schema.
    /// </summary>
    public partial class ApplicationData : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ApplicationData object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ApplicationData(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("LightSwitchApplication", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("LightSwitchApplication.Implementation", typeName.Substring(22)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("LightSwitchApplication.Implementation", global::System.StringComparison.Ordinal))
            {
                return string.Concat("LightSwitchApplication.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for InformesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Informes> InformesSet
        {
            get
            {
                if ((this._InformesSet == null))
                {
                    this._InformesSet = base.CreateQuery<Informes>("InformesSet");
                }
                return this._InformesSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Informes> _InformesSet;
        /// <summary>
        /// There are no comments for InformesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToInformesSet(Informes informes)
        {
            base.AddObject("InformesSet", informes);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = @"<edmx:Edmx Version=""1.0"" xmlns:edmx=""http://schemas.microsoft.com/ado/2007/06/edmx""><edmx:DataServices xmlns:m=""http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"" m:DataServiceVersion=""1.0"" m:MaxDataServiceVersion=""3.0""><Schema xmlns:annotation=""http://schemas.microsoft.com/ado/2009/02/edm/annotation"" Namespace=""LightSwitchApplication"" Alias=""Self"" xmlns=""http://schemas.microsoft.com/ado/2008/09/edm""><EntityType Name=""Informes""><Key><PropertyRef Name=""Id"" /></Key><Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" annotation:StoreGeneratedPattern=""Identity"" /><Property Name=""RowVersion"" Type=""Edm.Binary"" Nullable=""false"" ConcurrencyMode=""Fixed"" annotation:StoreGeneratedPattern=""Computed"" /><Property Name=""Informe1"" Type=""Edm.String"" Nullable=""false"" MaxLength=""255"" /></EntityType><EntityContainer Name=""ApplicationData"" m:IsDefaultEntityContainer=""true""><EntitySet Name=""InformesSet"" EntityType=""LightSwitchApplication.Informes"" /><FunctionImport Name=""Microsoft_LightSwitch_GetCanInformation"" ReturnType=""Edm.String"" m:HttpMethod=""GET""><Parameter Name=""dataServiceMembers"" Type=""Edm.String"" Mode=""In"" /></FunctionImport></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.Informes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("InformesSet")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Informes : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Informes object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="rowVersion">Initial value of RowVersion.</param>
        /// <param name="informe1">Initial value of Informe1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Informes CreateInformes(int ID, byte[] rowVersion, string informe1)
        {
            Informes informes = new Informes();
            informes.Id = ID;
            informes.RowVersion = rowVersion;
            informes.Informe1 = informe1;
            return informes;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                if (object.Equals(this.Id, value))
                {
                    return;
                }
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property RowVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] RowVersion
        {
            get
            {
                if ((this._RowVersion != null))
                {
                    return ((byte[])(this._RowVersion.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnRowVersionChanging(value);
                if (object.Equals(this.RowVersion, value))
                {
                    return;
                }
                this._RowVersion = value;
                this.OnRowVersionChanged();
                this.OnPropertyChanged("RowVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _RowVersion;
        partial void OnRowVersionChanging(byte[] value);
        partial void OnRowVersionChanged();
        /// <summary>
        /// There are no comments for Property Informe1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Informe1
        {
            get
            {
                return this._Informe1;
            }
            set
            {
                this.OnInforme1Changing(value);
                if (object.Equals(this.Informe1, value))
                {
                    return;
                }
                this._Informe1 = value;
                this.OnInforme1Changed();
                this.OnPropertyChanged("Informe1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Informe1;
        partial void OnInforme1Changing(string value);
        partial void OnInforme1Changed();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}