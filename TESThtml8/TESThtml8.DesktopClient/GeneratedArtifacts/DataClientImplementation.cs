﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Informes
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Informes :
        global::LightSwitchApplication.Informes.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnInforme1Changed()
        {
            this.___OnPropertyChanged("Informe1");
        }
        
    }
    #endregion
    
    #region Cliente
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Cliente :
        global::LightSwitchApplication.Cliente.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnNombreChanged()
        {
            this.___OnPropertyChanged("Nombre");
        }
        
        partial void OnDireccionChanged()
        {
            this.___OnPropertyChanged("Direccion");
        }
        
        partial void OnTelefonoChanged()
        {
            this.___OnPropertyChanged("Telefono");
        }
        
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Informes))
            {
                return new global::LightSwitchApplication.Implementation.Informes();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Cliente))
            {
                return new global::LightSwitchApplication.Implementation.Cliente();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.ApplicationData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Informes) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Informes);
            }
            if (typeof(global::LightSwitchApplication.Cliente) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Cliente);
            }
            return null;
        }
    }
}
