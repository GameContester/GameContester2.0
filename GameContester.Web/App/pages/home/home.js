define(["knockout", "jquery", "jquery-ui", "text!./home.html", "require"], function (ko, $, $$, homeTemplate, require) {

    var tokenKey = "tokenInfo";

    var HomeViewModel = function() {


    };

    self.IsAuthorize = ko.computed(function () {
        return (sessionStorage.getItem("role") == "User" || sessionStorage.getItem("role") == "Admin");
    });

    
    return { viewModel: HomeViewModel, template: homeTemplate };
});