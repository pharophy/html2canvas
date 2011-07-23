Sys.Application.add_load(function () {
    $('#feedback').click(function () {
        $('body').feedback({ 'submitHandler': HandleFormSubmission });
    });
});

var HandleFormSubmission = function () {

    var AddData = (function (key, value, addComma) {
        return "'" + key + "' : '" + value + ((addComma) ? "', " : "'");
    });

    $.ajax({
        type: "POST",
        url: "FeedbackHandler.asmx/SubmitFeedback",
        data:
        "{ " +
            " data : {" +
            AddData('browser', navigator.appName, true) +
            AddData('version', navigator.appVersion, true) +
            AddData('platform', navigator.platform, true) +
            AddData('userAgent', navigator.userAgent, true) +
            AddData('cookiesEnabled', navigator.cookieEnabled, true) +
            AddData('message', $(".tbxMessage").val(), true) +
            AddData('screenShot', $(".imgScreenShot").attr("src"), false) +
            "}" +
        "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var results = msg.d;
            alert(results.response);
        },
        error: function (xhr, status, error) {
            switch (xhr.status) {
                case 500:
                    alert("500: An error occured while processing your request.");
                    break;
                case 404:
                    alert("404: The webservice has moved to a new location.");
                    break;
                default:
                    alert("?: An unknown error has occurred.");
                    break;
            }
        }
    });
};

