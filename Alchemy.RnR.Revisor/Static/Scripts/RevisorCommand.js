Alchemy.command("${PluginName}", "Revisor", {
    isEnabled: function (item) {
        if (item.getItemType() == $const.ItemType.STRUCTURE_GROUP || item.getItemType() == $const.ItemType.FOLDER || item.getItemType() == $const.ItemType.PUBLICATION) {
            return false;
        }
        return true;
    },
    isAvailable: function (item) {
        if (item.getItemType() == $const.ItemType.STRUCTURE_GROUP || item.getItemType() == $const.ItemType.FOLDER || item.getItemType() == $const.ItemType.PUBLICATION) {
            return false;
        }
        return true;
    },
    execute: function (target) {
        
        console.log(target.getItem(0));

        Alchemy.Plugins.${PluginName}.Api.Service.revisor(target.getItem(0).replace('tcm:',''), function(error, message) {
            if(error) {
                $messages.registerError("There was an error", error.message);
            }
            $messages.registerGoal(message);
        });
    }
});
