
var $ = Alchemy.library("jQuery");
function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

var uri = getParameterByName('item');

var id = uri.replace('tcm:','');
Alchemy.Plugins.${PluginName}.Api.Service.revisor(id, function(error, message) {
    if(error) {
        $messages.registerError("There was an error", error.message);
    }
    $messages.registerGoal(message);
    $("#username").text(message);
});

