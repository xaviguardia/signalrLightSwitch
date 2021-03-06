﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
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
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Inserting(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Inserted(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Updating(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Updated(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Deleting(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Deleted(global::LightSwitchApplication.Informes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Validate(global::LightSwitchApplication.Informes entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void InformesSet_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Informes, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Inserting(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Inserted(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Updating(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Updated(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Deleting(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Deleted(global::LightSwitchApplication.Cliente entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Validate(global::LightSwitchApplication.Cliente entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clientes_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Cliente, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Informes>
                __InformesSetEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Informes>(
                    "InformesSet",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__InformesSet_Filter);
            private static bool __InformesSet_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.InformesSet_CanInsert(ref result);
                return result;
            }
            private static bool __InformesSet_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.InformesSet_CanUpdate(ref result);
                return result;
            }
            private static bool __InformesSet_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.InformesSet_CanDelete(ref result);
                return result;
            }
            private static bool __InformesSet_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.InformesSet_CanRead(ref result);
                return result;
            }
            private static void __InformesSet_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Inserting(e);
            }
            private static void __InformesSet_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Inserted(e);
            }
            private static void __InformesSet_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Updating(e);
            }
            private static void __InformesSet_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Updated(e);
            }
            private static void __InformesSet_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Deleting(e);
            }
            private static void __InformesSet_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e)
            {
                d.InformesSet_Deleted(e);
            }
            private static void __InformesSet_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Informes e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.InformesSet_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Informes, bool>> __InformesSet_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Informes, bool>> filter = null;
                d.InformesSet_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Cliente>
                __ClientesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Cliente>(
                    "Clientes",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Clientes_Filter);
            private static bool __Clientes_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Clientes_CanInsert(ref result);
                return result;
            }
            private static bool __Clientes_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Clientes_CanUpdate(ref result);
                return result;
            }
            private static bool __Clientes_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Clientes_CanDelete(ref result);
                return result;
            }
            private static bool __Clientes_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Clientes_CanRead(ref result);
                return result;
            }
            private static void __Clientes_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Inserting(e);
            }
            private static void __Clientes_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Inserted(e);
            }
            private static void __Clientes_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Updating(e);
            }
            private static void __Clientes_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Updated(e);
            }
            private static void __Clientes_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Deleting(e);
            }
            private static void __Clientes_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e)
            {
                d.Clientes_Deleted(e);
            }
            private static void __Clientes_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Cliente e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Clientes_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Cliente, bool>> __Clientes_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Cliente, bool>> filter = null;
                d.Clientes_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
        }
    
        #endregion
    }
    
    #endregion
}
