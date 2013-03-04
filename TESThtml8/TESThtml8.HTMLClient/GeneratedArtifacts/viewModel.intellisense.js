/// <reference path="viewModel.js" />

(function (lightSwitchApplication) {

    var $parameters = [document.createElement("div"), msls.ContentItem];

    msls._addEntryPoints(lightSwitchApplication.BrowseInformesSet, {
        /// <field>
        /// Called when a new BrowseInformesSet screen is created.
        /// <br/>created(msls.application.BrowseInformesSet screen)
        /// </field>
        created: [lightSwitchApplication.BrowseInformesSet],
        /// <field>
        /// Called before changes on an active BrowseInformesSet screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseInformesSet screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseInformesSet],
        /// <field>
        /// Called after the InformesList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        InformesList_postRender: $parameters,
        /// <field>
        /// Called after the Informes content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Informes_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.AddEditInformes, {
        /// <field>
        /// Called when a new AddEditInformes screen is created.
        /// <br/>created(msls.application.AddEditInformes screen)
        /// </field>
        created: [lightSwitchApplication.AddEditInformes],
        /// <field>
        /// Called before changes on an active AddEditInformes screen are applied.
        /// <br/>beforeApplyChanges(msls.application.AddEditInformes screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.AddEditInformes],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the Informe1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Informe1_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.ViewInformes, {
        /// <field>
        /// Called when a new ViewInformes screen is created.
        /// <br/>created(msls.application.ViewInformes screen)
        /// </field>
        created: [lightSwitchApplication.ViewInformes],
        /// <field>
        /// Called before changes on an active ViewInformes screen are applied.
        /// <br/>beforeApplyChanges(msls.application.ViewInformes screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.ViewInformes],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the columns content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        columns_postRender: $parameters,
        /// <field>
        /// Called after the left content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        left_postRender: $parameters,
        /// <field>
        /// Called after the Informe1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Informe1_postRender: $parameters,
        /// <field>
        /// Called after the right content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        right_postRender: $parameters,
        /// <field>
        /// Called after the ShowViewInformes content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowViewInformes_postRender: $parameters,
        /// <field>
        /// Called after the Group content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Group_postRender: $parameters,
        /// <field>
        /// Called after the ShowAddEditInformes1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ShowAddEditInformes1_postRender: $parameters
    });

}(msls.application));
