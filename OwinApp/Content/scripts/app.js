(function (context) {

    context.OwinApp = {
        alert: function () {
            window.alert.apply(window, arguments);
        }
    };

}(this));