﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    public sealed partial class Informes : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Informes entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Informes()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Informes(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Informes> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Informes.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Informes_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Informes_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Informes.DetailsClass.GetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Informes.DetailsClass.SetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.Informes.DetailsClass.GetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.Informes.DetailsClass.SetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Informe1
        {
            get
            {
                return global::LightSwitchApplication.Informes.DetailsClass.GetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Informe1);
            }
            set
            {
                global::LightSwitchApplication.Informes.DetailsClass.SetValue(this, global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Informe1, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Informe1_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Informe1_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Informe1_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Informes,
                global::LightSwitchApplication.Informes.DetailsClass,
                global::LightSwitchApplication.Informes.DetailsClass.IImplementation,
                global::LightSwitchApplication.Informes.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>.Entry
                __InformesEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>.Entry(
                    global::LightSwitchApplication.Informes.DetailsClass.__Informes_CreateNew,
                    global::LightSwitchApplication.Informes.DetailsClass.__Informes_Created,
                    global::LightSwitchApplication.Informes.DetailsClass.__Informes_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Informes __Informes_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Informes> es)
            {
                return new global::LightSwitchApplication.Informes(es);
            }
            private static void __Informes_Created(global::LightSwitchApplication.Informes e)
            {
                e.Informes_Created();
            }
            private static bool __Informes_AllowSaveWithErrors(global::LightSwitchApplication.Informes e)
            {
                bool result = false;
                e.Informes_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Informes.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string> Informe1
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties.Informe1) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new string Informe1 { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Informes.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int>.Data> c, global::LightSwitchApplication.Informes.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Informes e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Informes e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Informes e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Informes.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.Informes.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.Informes e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.Informes e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.Informes e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string>.Entry
                    Informe1 = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string>.Entry(
                        "Informe1",
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_Stub,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_ComputeIsReadOnly,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_Validate,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_GetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_SetImplementationValue,
                        global::LightSwitchApplication.Informes.DetailsClass.PropertySetProperties._Informe1_OnValueChanged);
                private static void _Informe1_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Informes.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string>.Data> c, global::LightSwitchApplication.Informes.DetailsClass d, object sf)
                {
                    c(d, ref d._Informe1, sf);
                }
                private static bool _Informe1_ComputeIsReadOnly(global::LightSwitchApplication.Informes e)
                {
                    bool result = false;
                    e.Informe1_IsReadOnly(ref result);
                    return result;
                }
                private static void _Informe1_Validate(global::LightSwitchApplication.Informes e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Informe1_Validate(r);
                }
                private static string _Informe1_GetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d)
                {
                    return d.ImplementationEntity.Informe1;
                }
                private static void _Informe1_SetImplementationValue(global::LightSwitchApplication.Informes.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Informe1 = v;
                }
                private static void _Informe1_OnValueChanged(global::LightSwitchApplication.Informes e)
                {
                    e.Informe1_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Informes, global::LightSwitchApplication.Informes.DetailsClass, string>.Data _Informe1;
            
        }
    
        #endregion
    }
    
    #endregion
}
