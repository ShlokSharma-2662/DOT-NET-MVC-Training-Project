    $(document).ready(function () {
    //Global Variable Declaration. var $FNameLNameRegEx = /^([a-zA-Z]{2,20})$/;
    var $FNameLNameRegEx = /^([a-zA-Z]{2,20})$/;
    var $FullNameRegEx = /^([a-zA-Z ]{2,40})$/;
    var $BankAccountNameRegEx = /^([a-zA-Z ]{2,60})$/;
    var $PasswordRegEx = /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{8,12}$/;
    var $EmailIdRegEx = /^\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,8}\b$/i;
    var $ConNoRegEx = /^([0-9]{10})$/;
    var $AgeRegEx = /^([0-9]{1,2})$/;
    var $AadhaarNoRegEx = /^([0-9]{12})$/;
    var $GSTNoRegEx = /^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$/;
    var $IndianDrivingLicenseNoRegEx = /^([A-Z]{2,3}[-/0-9]{8,13})$/;
    var $IndianVehicleRegNoRegEx = /^([A-Z]{2}[0-9]{1,2}[A-Z]{1,3}[0-9]{1,4})$/;
    var $PincodeRegEx = /^[1-9][0-9]{5,6}$/;
    var $PANNoRegEx = /^[A-Z]{3}[ABCFGHLJPT][A-Z][0-9]{4}[A-Z]$/;
    var $IFSCCodeRegEx = /^[A-Za-z]{4}0[A-Z0-9a-z]{6}$/;
    var $BankAccountNoRegEx = /^([0-9]{9,18})$/;
    var $PostTitleRegex = /^(.{30,300})$/;
    var $PostDescRegex = /^(.{100,3000})$/;
    var $LatitudeLongitude = /^(-?(?:1[0-7]|[1-9])?\d(?:\.\d{1,8})?|180(?:\.0{1,8})?)$/;

   
        $("#TxtFName").bind("keypress", function (e)
        {
        var keyCode = e.which;
        var ret = ((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122));
        $("#TxtFNameValidate").html(ret ? "" : "(*) Invalid Input..!!");
        return ret;
    });
    $("#TxtFName").bind("blur", function (e) {
        if ($("#TxtFName").val() == "") {
            TxtFNameFlag = false;
            $("#TxtFNameValidate").empty();
            $("#TxtFNameValidate").html('(*) First Name Required..!!');
        }
        else {
            $("#TxtFNameValidate").empty();
            if (!$("#TxtFName").val().match($FNameLNameRegEx)) {
                $("#TxtFNameValidate").html('Invalid First Name..!!');
                TxtFNameFlag = false;
            }
            else {
                $("#TxtFNameValidate").empty();
                TxtFNameFlag = true;
            }
        }
    });
    $("#TxtLName").bind("keypress", function (e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || specialKeys.indexOf(keyCode) != -1);
        $("#TxtLNameValidate").html(ret ? "" : "(*) Invalid Input..!!");
        return ret;
    }); $("#TxtLName").bind("blur", function (e) {
        if ($("#TxtLName").val() == "") {
            TxtLNameFlag = false;
            $("#TxtLNameValidate").empty();
            $("#TxtLNameValidate").html('(*) Last Name Required..!!');
        }
        else {
            $("#TxtLNameValidate").empty();
            if (!$("#TxtLName").val().match($FNameLNameRegEx)) {
                $("#TxtLNameValidate").html('Invalid Last Name..!!');
                TxtLNameFlag = false;
            }
            else {
                $("#TxtLNameValidate").empty();
                TxtLNameFlag = true;
            }
        }
    });
    $("#TxtContactNo").bind("keypress", function (e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
        $("#TxtContactNoValidate").html(ret ? "" : "(*) Invalid Input..!!");
        return ret;
    }); $("#TxtContactNo").bind("blur", function (e) {
        $("#TxtContactNoValidate").empty();
        if ($("#TxtContactNo").val() == '') {
            TxtContactNoFlag = false;
            $("#TxtContactNoValidate").html('(*) Contact No Required..!!');
        }
        else {
            if (!$("#TxtContactNo").val().match($ConNoRegEx)) {
                TxtContactNoFlag = false;
                $("#TxtContactNoValidate").html('Invalid Contact No..!!');
            }
            else {
                $("#TxtContactNoValidate").empty();
                TxtContactNoFlag = true;
            }
        }
        return TxtContactNoFlag;
    }); $("#Email").bind("blur", function (e) {
        $("#TxtEmailIdValidate").empty();
        if ($("#Email").val() == "") {
            $("#TxtEmailIdValidate").empty();
            TxtEmailIdFlag = false;
            $("#TxtEmailIdValidate").html('(*) Email Id Required..!!');
        }
        else {
            if (!$("#Email").val().match($EmailIdRegEx)) {
                TxtEmailIdFlag = false;
                $("#TxtEmailIdValidate").html('Invalid Email Id..!!');
            }
            else {
                $("#TxtEmailIdValidate").empty();
                TxtEmailIdFlag = true;
            }
        }
        return TxtEmailIdFlag;
    }); $("#TxtPassword").bind("blur", function (e) {
        $("#TxtPasswordValidate").empty();
        if ($("#TxtPassword").val() == "") {
            $("#TxtPasswordValidate").html("(*) Password Required..!!");
            TxtPasswordFlag = false;
        }
        else {
            if (!$("#TxtPassword").val().match($PasswordRegEx)) {
                TxtPasswordFlag = false;
                $("#TxtPasswordValidate").html('-- Invalid Password..!!');
            }
            else {
                $("#TxtPasswordValidate").empty();
                TxtPasswordFlag = true;
            }
        }
        return TxtPasswordFlag;
    });
    $("#BtnSignUp").click(function () {
        if ($("#TxtFName").val() == "")
        {
            $("#TxtFNameValidate").empty();
            $("#TxtFNameValidate").html('(*) First Name Required..!!');
        }
        else {
            $("#TxtFNameValidate").empty();
            if (!$("#TxtFName").val().match($FNameLNameRegEx)) {
                $("#TxtFNameValidate").html('Invalid First Name..!!');
                TxtFNameFlag = false;
            }
            else {
                $("#TxtFNameValidate").empty();
                TxtFNameFlag = true;
            }
        }
        if ($("#TxtLName").val() == "") {
            $("#TxtLNameValidate").empty();
            $("#TxtLNameValidate").html('(*) Last Name Required..!!');
        }
        else {
            $("#TxtLNameValidate").empty();
            if (!$("#TxtLName").val().match($FNameLNameRegEx)) {
                $("#TxtLNameValidate").html('Invalid Last Name..!!');
                TxtLNameFlag = false;
            }
            else {
                $("#TxtLNameValidate").empty();
                TxtLNameFlag = true;
            }
        }
        if ($("#TxtContactNo").val() == "") {
            $("#TxtContactNoValidate").empty();
            $("#TxtContactNoValidate").html('(*) Contact No. Required..!!');
        }
        else {
            $("#TxtContactNoValidate").empty();
            if (!$("#TxtContactNo").val().match($ConNoRegEx)) {
                $("#TxtContactNoValidate").html('Invalid Contact No..!!');
                TxtContactNoFlag = false;
            }
            else {
                $("#TxtContactNoValidate").empty();
                TxtContactNoFlag = true;
            }
        }
        if ($("#Email").val() == "") {
            $("#TxtEmailIdValidate").empty();
            $("#TxtEmailIdValidate").html('(*) Email Id Required..!!');
        }
        else {
            $("#TxtEmailIdValidate").empty();
            if (!$("#Email").val().match($EmailIdRegEx)) {
                TxtEmailIdFlag = false;
                $("#TxtEmailIdValidate").html('Invalid Email Id..!!');
            }
            else {
                $("#TxtEmailIdValidate").empty();
                TxtEmailIdFlag = true;
            }
        } $("#TxtPasswordValidate").empty();
        if ($("#TxtPassword").val() == "") {
            $("#TxtPasswordValidate").html("(*) Password Required..!!");
            TxtPasswordFlag = false;
        }
        else {
            if (!$("#TxtPassword").val().match($PasswordRegEx)) {
                TxtPasswordFlag = false;
                $("#TxtPasswordValidate").html('-- Invalid Password..!!<br/><ul style="padding:20px;"><li> Minimum 8 Maximum 12 Character Required.</li><li> Atleast One Uppercase Required.</li><li> Atleast One Lowercase Required.</li><li> Atleast One Numeric Required.</li><li> NO SPECIAL CHARACTERS ALLOWED.</li></ul>');
            }
            else {
                $("#TxtPasswordValidate").empty();
                TxtPasswordFlag = true;
            }
        }
        if (TxtFNameFlag == true && TxtLNameFlag == true && TxtEmailIdFlag == true && TxtContactNoFlag == true && TxtPasswordFlag == true) {
            SignUp();
        }
        else {
            alert("Invalid Inputs..!!")
        }
    });
});

function SignUp() {
    $.ajax({
        type: "POST",
        url: "/Index/CreateNewAccount",
        data: '{Id: "0",FirstName: "' + $("#TxtFName").val().trim() + '",LastName: "' + $("#TxtLName").val().trim() + '",ContactNo: "' + $("#TxtContactNo").val().trim() + '",Email: "' + $("#Email").val().trim() + '",Password: "' + $("#TxtPassword").val().trim() + '",Gender: "' + $("#DDL_Gender").val() + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.Success == "Success") {
                alert("Data Inserted Successfully..!!");
                $("input").val('');
                $("#DDL_Gender").val('M');
            }
        },
        error: function () {
            alert("Unexpected Error Sorry For The Inconvinience..!!");
        }
    });
}
