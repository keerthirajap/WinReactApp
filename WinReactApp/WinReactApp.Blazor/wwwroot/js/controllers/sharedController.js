﻿(
    function (publicMethod, $) {
        publicMethod.clearValidationSummary = function () {
            $(".validation-message").remove();
        }
    }(window.sharedController = window.sharedController || {}, jQuery)
);