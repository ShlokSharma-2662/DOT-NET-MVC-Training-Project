$(document).ready(function () {
    $(document).on('click', '#ManagePager li', function (e) {
        if (parseInt($(this).attr("data-indexid")) != -1 && parseInt($(this).attr("data-indexid")) != 0) {
            $("#ManagePager li").removeClass("active");
            $(this).addClass("active");
            $("#UserTableBody tr").css("display", "none");
            $("[data-row-id='" + parseInt($(this).attr("data-indexid")) + "']").css("display", "table-row");
        }
        else if (parseInt($(this).attr("data-indexid")) == 0) {
            var IndexCurrentLI = parseInt($("#ManagePager li.active").index()) + 1;
            if ($("#ManagePager li:eq(" + IndexCurrentLI + ")").attr("data-indexid") != 0) {
                $("#ManagePager li").removeClass("active");
                $("#ManagePager li:eq(" + IndexCurrentLI + ")").addClass("active");
                $("#UserTableBody tr").css("display", "none");
                $("[data-row-id='" + parseInt($("#ManagePager li:eq(" + IndexCurrentLI + ")").attr("data-indexid")) + "']").css("display", "table-row");
            }
            else {
                alert("-- No More Records Available --");
            }
        }
        else {
            var IndexCurrentLI = parseInt($("#ManagePager li.active").index()) - 1;
            if ($("#ManagePager li:eq(" + IndexCurrentLI + ")").attr("data-indexid") != -1) {
                $("#ManagePager li").removeClass("active");
                $("#ManagePager li:eq(" + IndexCurrentLI + ")").addClass("active");
                $("#UserTableBody tr").css("display", "none");
                $("[data-row-id='" + parseInt($("#ManagePager li:eq(" + IndexCurrentLI + ")").attr("data-indexid")) + "']").css("display", "table-row");
            }
            else {
                alert("-- No More Records Available --");
            }
        }
    });
});