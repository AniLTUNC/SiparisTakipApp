function errorMes(message, errorTitle) {
    toastr.error(message, errorTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function sucMess(message, sucTitle) {
    toastr.success(message, sucTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function warMess(message, warTitle) {
    toastr.warning(message, warTitle, toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    })
};

function LoginControl() {
    var veri = {
        UserName : $("#UserName").val(),
        Password : $("#Password").val(),
    }
    $.ajax({
        url: "/Login/LoginControl",
        type: "post",
        data: veri,
        success: function (e) {
            if (veri.UserName == "" && veri.Password == "") {
                warMess("Kullanýcý adý ve parola boþ geçilemez", "Hata!");
            }
            else {
                if (e != true) {
                    errorMes("Kullanýcý adý ya da parola hatalý", "Hata!");
                    setInterval(function () {
                        window.location.replace("/");
                    }, 3000);
                }
                else {
                    sucMess(veri.UserName, "Hoþgeldin");
                    setInterval(function () {
                        window.location.replace("/Home/Index");
                    }, 3000);
                }
            }
        }
    });
}
