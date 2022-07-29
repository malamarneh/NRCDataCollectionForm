(function () {
    var app = angular.module('app');

    var controllerId = 'app.views.collectionFormCreate';
    app.controller(controllerId, [
        '$scope', '$location', 'abp.services.app.collectionForm',
        function ($scope, $location, collectionFormService) {

            var vm = this;

            vm.collectionForm = {

            };

            vm.save = function (form) {
                if ($scope[form].$valid) {
                    abp.ui.setBusy(
                        null,
                        collectionFormService.create(
                            vm.collectionForm
                        ).then(function () {
                            $scope.data = {};
                            ShowSweetAlert(GetTranslation("CreateCollectionForm"), GetTranslation("CreateSuccess"), "success");
                            $("input, textarea").val("")
                        })
                    );
                }
            };
        }
    ])
})();
