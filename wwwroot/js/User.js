﻿//register js work function
function Register() {
    var myData = $("#registerForm").serialize();

    $.ajax({
        url: "/user/register",
        type: "POST",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: myData,
        success: function(data){
            if (data.success) {
                toastr.success(data.message,"",
                    {
                        timeOut: 1000,
                        fadeOut: 1000,
                        onHidden: function(){
                            window.location = data.url;
                        }
                    }
                );
            }
            else {
                toastr.error(data.message);
            }
        }
    });
}

//this is for login function
function Login() {
    var myData = $("#loginForm").serialize();

    $.ajax({
        url: "/user/login",
        type: "POST",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: myData,
        success: function (data) {
            if (data.success) {
                toastr.success(data.message, "",
                    {
                        timeOut: 1000,
                        fadeOut: 1000,
                        onHidden: function () {
                            window.location = data.url;
                        }
                    }
                );
            }
            else {
                toastr.error(data.message);
            }
        }
    });
}