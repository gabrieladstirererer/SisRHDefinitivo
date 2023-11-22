
function updateTime() {
    const timeElement = document.getElementById('time');
    const now = new Date();
    const hours = now.getHours().toString().padStart(2, '0');
    const minutes = now.getMinutes().toString().padStart(2, '0');
    const seconds = now.getSeconds().toString().padStart(2, '0');
    const timeString = `${hours}:${minutes}:${seconds}`;
    timeElement.textContent = timeString;
};

setInterval(updateTime, 1000);
updateTime();

//mascaras nos inputs
$(function ($) {
    $("#DT_Nascimento").mask("00/00/0000");
});

$(document).ready(function () {
    $(".datepicker").datepicker({
        dateformat: "dd-mm-yy",
        changemonth: true,
        changeyear: true
    });
});

$(function () {
    var str = '#len'; //increment by 1 up to 1-nelemnts
    $(document).ready(function () {
        var i, stop;
        i = 1;
        stop = 4; //num elements
        setInterval(function () {
            if (i > stop) {
                return;
            }
            $('#len' + (i++)).toggleClass('bounce');
        }, 500)
    });
});

