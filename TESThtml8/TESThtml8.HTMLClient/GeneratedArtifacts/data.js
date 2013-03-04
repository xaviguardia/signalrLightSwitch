/// <reference path="../Scripts/msls-1.0.0.js" />

window.myapp = msls.application;

(function (lightSwitchApplication) {

    var $Entity = msls.Entity,
        $DataService = msls.DataService,
        $DataWorkspace = msls.DataWorkspace,
        $defineEntity = msls._defineEntity,
        $defineDataService = msls._defineDataService,
        $defineDataWorkspace = msls._defineDataWorkspace,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString;

    function Informes(entitySet) {
        /// <summary>
        /// Represents the Informes entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this informes.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this informes.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this informes.
        /// </field>
        /// <field name="Informe1" type="String">
        /// Gets or sets the informe1 for this informes.
        /// </field>
        /// <field name="details" type="msls.application.Informes.Details">
        /// Gets the details for this informes.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Cliente(entitySet) {
        /// <summary>
        /// Represents the Cliente entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this cliente.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this cliente.
        /// </field>
        /// <field name="RowVersion" type="Array">
        /// Gets or sets the rowVersion for this cliente.
        /// </field>
        /// <field name="Nombre" type="String">
        /// Gets or sets the nombre for this cliente.
        /// </field>
        /// <field name="Direccion" type="String">
        /// Gets or sets the direccion for this cliente.
        /// </field>
        /// <field name="Telefono" type="String">
        /// Gets or sets the telefono for this cliente.
        /// </field>
        /// <field name="details" type="msls.application.Cliente.Details">
        /// Gets the details for this cliente.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function ApplicationData(dataWorkspace) {
        /// <summary>
        /// Represents the ApplicationData data service.
        /// </summary>
        /// <param name="dataWorkspace" type="msls.DataWorkspace">
        /// The data workspace that created this data service.
        /// </param>
        /// <field name="InformesSet" type="msls.EntitySet">
        /// Gets the InformesSet entity set.
        /// </field>
        /// <field name="Clientes" type="msls.EntitySet">
        /// Gets the Clientes entity set.
        /// </field>
        /// <field name="details" type="msls.application.ApplicationData.Details">
        /// Gets the details for this data service.
        /// </field>
        $DataService.call(this, dataWorkspace);
    };
    function DataWorkspace() {
        /// <summary>
        /// Represents the data workspace.
        /// </summary>
        /// <field name="ApplicationData" type="msls.application.ApplicationData">
        /// Gets the ApplicationData data service.
        /// </field>
        /// <field name="details" type="msls.application.DataWorkspace.Details">
        /// Gets the details for this data workspace.
        /// </field>
        $DataWorkspace.call(this);
    };

    msls._addToNamespace("msls.application", {

        Informes: $defineEntity(Informes, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Informe1", type: String }
        ]),

        Cliente: $defineEntity(Cliente, [
            { name: "Id", type: Number },
            { name: "RowVersion", type: Array },
            { name: "Nombre", type: String },
            { name: "Direccion", type: String },
            { name: "Telefono", type: String }
        ]),

        ApplicationData: $defineDataService(ApplicationData, lightSwitchApplication.rootUri + "/ApplicationData.svc", [
            { name: "InformesSet", elementType: Informes },
            { name: "Clientes", elementType: Cliente }
        ], [
            {
                name: "InformesSet_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.InformesSet },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/InformesSet(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Clientes_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Clientes },
                        lightSwitchApplication.rootUri + "/ApplicationData.svc" + "/Clientes(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            }
        ]),

        DataWorkspace: $defineDataWorkspace(DataWorkspace, [
            { name: "ApplicationData", type: ApplicationData }
        ])

    });

}(msls.application));
