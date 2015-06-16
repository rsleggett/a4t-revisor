Type.registerNamespace("Alchemy.Revisor.Commands");

/**
 * Command for incrementing the 'modification' attribute in System.config to clear Tridion's cache.
 */
Alchemy.Revisor.Commands.ShowRevisorPage = function () {
    Type.enableInterface(this, "Alchemy.Revisor.Commands.ShowRevisorPage");
    this.addInterface("Tridion.Cme.Command", ["ShowRevisorPage"]);
};

// IncrementModification Prototype
Alchemy.Revisor.Commands.ShowRevisorPage.prototype = {

    /**
     * Whether or not the command is available.
     */
    isAvailable: function (selection) {
        return this.isEnabled(selection);
    },

    /**
     * Whether or not the command is enabled.
     */
    isEnabled: function (selection) {
        var selectedItem = selection.getItems()[0],
            item = $models.getItem(selectedItem),
            itemType = item.getItemType();

        if (itemType === $const.ItemType.PUBLICATION || itemType === $const.ItemType.FOLDER) {
            return false;
        }

        return true;
    },

    /**
     * Executes the command.
     */
    _execute: function (selection) {
        console.log("RC " + selection.getItems()[0]);
        var selectedItem = selection.getItems()[0],
            item = $models.getItem(selectedItem),
            customPageFrame = $("#CustomPagesFrame"),  // TODO: Move selectors into a constants file to easily update if ever changed
            mainView = $("#contentsplitter_container");

        customPageFrame.src = "${ViewsUrl}RevisorPage.aspx?item=" + selectedItem + "&r=" + new Date().getTime();

        $css.undisplay(mainView);
        $css.display(customPageFrame);
    }
}