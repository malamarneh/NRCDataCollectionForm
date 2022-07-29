function GetTranslation(value) {
    var source = abp.localization.getSource('NRCDataCollectionForm');
    return source(value);

}
function ShowSweetConfirm(messageTitle, messageText, isShowCancel, ConfirmText, CancelText, Type, successCallbackFunction, autoClose = true) {

    swal({
        html: true,
        title: messageTitle,
        text: messageText,
        type: Type,
        showCancelButton: isShowCancel,
        confirmButtonText: ConfirmText,
        cancelButtonText: CancelText,
        closeOnConfirm: autoClose,
        closeOnCancel: isShowCancel
    },
        function (isConfirm) {
            if (isConfirm) {
                /*if (!isEnterKey) {*/
                successCallbackFunction();
                //} else {
                //    isEnterKey = false;
                //}

            }

        });

}

function ShowSweetAlert(title, messageText, Type, timer = 0, isReload = false) {
    if (timer > 0) {
        swal({
            title: title,
            text: messageText,
            html: true,
            type: Type,
            showCancelButton: false,
            confirmButtonText: GetTranslation("OK"),
            closeOnConfirm: true,
            timer: timer
        }, function (isConfirm) {
            if (isReload)
                window.location.reload();
        });
    } else {
        swal({
            title: title,
            text: messageText,
            html: true,
            type: Type,
            showCancelButton: false,
            confirmButtonText: GetTranslation("OK"),
            closeOnConfirm: true
        }, function (isConfirm) {
            if (isReload)
                window.location.reload();
        });
    }
}

function CustomValidation() {

    $(".validation-form").validate({
        errorClass: "is-invalid",
        validClass: "is-valid",
        highlight: function (element, errorClass, validClass) {
            $(element).addClass(errorClass).removeClass(validClass);
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).removeClass(errorClass).addClass(validClass);
        }, invalidHandler: function (event, validator) {
            $('input').focus()
            $("input").focusout()
            $('select').focus()
            $('select').focusout()
            $('textarea').focus()
            $("textarea").focusout()
            if ($('.datepicker').length > 0)
                $('.datepicker').hide();
            ShowSweetAlert(GetTranslation("FillRequiredFields"), GetTranslation("FillAllFieldsInRed"), 'warning');
        }
    });
}

function ReturnURLParameters() {
    var params = window.location.search.replace(/\?/, '').split('&');
    return params;
}

function LoadDataTable() {
    //initiate dataTables plugin
    var myTable =
        $('#dynamic-table')
            //.wrap("<div class='dataTables_borderWrap' />")   //if you are applying horizontal scrolling (sScrollX)
            .DataTable({
                bAutoWidth: false,
                responsive: true


            });



    $.fn.dataTable.Buttons.defaults.dom.container.className = 'dt-buttons btn-overlap btn-group btn-overlap';

    new $.fn.dataTable.Buttons(myTable, {
        buttons: [
            {},
            {
                "extend": "csv",
                "text": "<i class='fa fa-database bigger-110 orange'></i> <span>Export to CSV</span>",
                "className": "btn btn-white btn-primary btn-bold"
            },
            {
                "extend": "excel",
                "text": "<i class='fa fa-file-excel-o bigger-110 green'></i> <span>Export to Excel</span>",
                "className": "btn btn-white btn-primary btn-bold"
            },
            {
                "extend": "pdf",
                "text": "<i class='fa fa-file-pdf-o bigger-110 red'></i> <span>Export to PDF</span>",
                "className": "btn btn-white btn-primary btn-bold"
            }//,
            //{
            //    "extend": "print",
            //    "text": "<i class='fa fa-print bigger-110 grey'></i> <span class='hidden'>Print</span>",
            //    "className": "btn btn-white btn-primary btn-bold",
            //    autoPrint: false,
            //    message: 'This print was produced using the Print button for DataTables'
            //}
        ]
    });
    myTable.buttons().container().appendTo($('.tableTools-container'));

    //style the message box

    var defaultColvisAction = myTable.button(0).action();
    myTable.button(0).action(function (e, dt, button, config) {

        defaultColvisAction(e, dt, button, config);


        if ($('.dt-button-collection > .dropdown-menu').length == 0) {
            $('.dt-button-collection')
                .wrapInner('<ul class="dropdown-menu dropdown-light dropdown-caret dropdown-caret" />')
                .find('a').attr('href', '#').wrap("<li />")
        }
        $('.dt-button-collection').appendTo('.tableTools-container .dt-buttons')
    });

    ////

}

jQuery(document).ready(function () {
    CustomValidation();
});
