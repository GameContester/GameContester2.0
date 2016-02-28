define(['jquery', 'knockout', './router', 'knockout-projections', 'auth'], function ($, ko, router) {

    ko.components.register('home', { require: 'App/pages/home/home' });

    ko.applyBindings({ route: router.currentRoute });
});
