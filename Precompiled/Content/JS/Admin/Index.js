(function () {
    var app = angular.module('app').directive('myRepeatDirective', function () {
        return function (scope, element, attrs) {
            if (scope.$last) {
                setTimeout(function () {
                    LoadDataTable()
                }, 2000)

            }
        };
    })

    var controllerId = 'app.views.collectionForm';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.collectionForm',
        function ($scope, collectionFormService) {
            var vm = this;

            vm.collectionForms = [];
            try {
                abp.ui.setBusy(null,
                    collectionFormService.getAll().then(function (data) {

                        vm.collectionForms = data.data;
                    })
                );


            } catch (e) {
            }


        }
    ]);

})();



