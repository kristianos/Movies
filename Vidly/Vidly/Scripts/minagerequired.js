$(function () {
    var d = new Date();
    //console.log(d.getFullYear());
    jQuery.validator.addMethod('minagerequired',
        function(value, elem, params) {
            var currentDate = new Date();
            console.log(d.getFullYear());
            console.log(value.toString());
            if (currentDate.getFullYear() - Date.parse(value).getFullYear < 18) {
                return false;
            }
            return true;
        },
        '');

    jQuery.validator.unobtrusive.adapters.add('minagerequired',
        function (options) {
            console.log(options.message);
            options.rules['minagerequired'] = {};
            options.messages["minagerequired"] = options.message;
        });
}(jQuery));