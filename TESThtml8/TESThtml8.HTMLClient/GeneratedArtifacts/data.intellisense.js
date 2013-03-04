/// <reference path="data.js" />

(function (lightSwitchApplication) {

    msls._addEntryPoints(lightSwitchApplication.Informes, {
        /// <field>
        /// Called when a new informes is created.
        /// <br/>created(msls.application.Informes entity)
        /// </field>
        created: [lightSwitchApplication.Informes]
    });

    msls._addEntryPoints(lightSwitchApplication.Cliente, {
        /// <field>
        /// Called when a new cliente is created.
        /// <br/>created(msls.application.Cliente entity)
        /// </field>
        created: [lightSwitchApplication.Cliente]
    });

}(msls.application));
