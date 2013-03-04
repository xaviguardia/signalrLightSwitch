/// <reference path="data.js" />

(function (lightSwitchApplication) {

    var $Screen = msls.Screen,
        $defineScreen = msls._defineScreen,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString,
        $defineShowScreen = msls._defineShowScreen;

    function BrowseInformesSet(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the BrowseInformesSet screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="InformesSet" type="msls.VisualCollection" elementType="msls.application.Informes">
        /// Gets the informesSet for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseInformesSet.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseInformesSet", parameters);
    }

    function AddEditInformes(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the AddEditInformes screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Informes" type="msls.application.Informes">
        /// Gets or sets the informes for this screen.
        /// </field>
        /// <field name="details" type="msls.application.AddEditInformes.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "AddEditInformes", parameters);
    }

    function ViewInformes(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the ViewInformes screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Informes" type="msls.application.Informes">
        /// Gets or sets the informes for this screen.
        /// </field>
        /// <field name="details" type="msls.application.ViewInformes.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "ViewInformes", parameters);
    }

    msls._addToNamespace("msls.application", {

        BrowseInformesSet: $defineScreen(BrowseInformesSet, [
            {
                name: "InformesSet", kind: "collection", elementType: lightSwitchApplication.Informes,
                createQuery: function () {
                    return this.dataWorkspace.ApplicationData.InformesSet;
                }
            }
        ], [
        ]),

        AddEditInformes: $defineScreen(AddEditInformes, [
            { name: "Informes", kind: "local", type: lightSwitchApplication.Informes }
        ], [
        ]),

        ViewInformes: $defineScreen(ViewInformes, [
            { name: "Informes", kind: "local", type: lightSwitchApplication.Informes }
        ], [
        ]),

        showBrowseInformesSet: $defineShowScreen(function showBrowseInformesSet(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseInformesSet screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseInformesSet", parameters, options);
        }),

        showAddEditInformes: $defineShowScreen(function showAddEditInformes(Informes, options) {
            /// <summary>
            /// Asynchronously navigates forward to the AddEditInformes screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("AddEditInformes", parameters, options);
        }),

        showViewInformes: $defineShowScreen(function showViewInformes(Informes, options) {
            /// <summary>
            /// Asynchronously navigates forward to the ViewInformes screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 1);
            return lightSwitchApplication.showScreen("ViewInformes", parameters, options);
        })

    });

}(msls.application));
