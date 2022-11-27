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

function SearchCustomer()
{
    var data = {
        Phone: $("#SearchPhone").val()
    };
    $.ajax({
        url: "/Customer/CustomerSearch",
        type: "post",
        data: data,
        success: function (e) {
            if (e != false) {
                $("#CustomerName").attr("disabled", "disable");
                $("#CustomerAddress").attr("disabled", "disable");
                $("#CustomerPhone").attr("disabled", "disable");
                $("#MarketId").attr("disabled", "disable");
                $("#saveData").attr("disabled", "disable");

                $("#CustomerName").val(e.CustomerName);
                $("#CustomerAddress").html(e.CustomerAddress);
                $("#CustomerPhone").val(e.CustomerPhone);
                $("#MarketId").val(e.MarketID);

                errorMes("Müþteri daha önce eklenmiþ", "Hata!");
                $("statusBar").removeAttr("hidden");
                $("#statusBar").addClass("text-danger");
                $("#statusBar").html("Müþteri daha önce eklenmiþ farklý bir numara ile arama yapýnýz!");
            }
            else {
                $("#CustomerName").removeAttr("disabled", "disable");
                $("#CustomerPhone").removeAttr("disabled", "disable");
                $("#CustomerAddress").removeAttr("disabled", "disable");
                $("#MarketId").removeAttr("disabled", "disable");

                $("#CustomerName").val("");
                $("#CustomerAddress").html("");
                $("#CustomerPhone").val("");
                $("#MarketId").val(1);
                $("#CustomerPhone").val(data.Phone);


                sucMess("Müþteri daha önce eklenmemiþ" , "Müþteri eklenebilir")
                $("statusBar").removeAttr("hidden");
                $("#statusBar").addClass("text-success");
                $("#statusBar").removeClass("text-danger");
                $("#statusBar").html("Yeni müþteri olarak ekleme yapabilirsiniz");

                $("#saveData").removeAttr("disabled" , "disable");
            }
        }
        })


}
