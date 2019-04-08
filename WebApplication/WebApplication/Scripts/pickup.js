var dt = new Date(); 
$(document).ready(function () {
    var now = new Date();
    var mins = now.getMinutes();
    var quarterHours = Math.round(mins / 15);
    if (quarterHours === 4) {
        now.setHours(now.getHours() + 1);
    }
    var roundedTime = (quarterHours * 15) % 60;
    now.setMinutes(roundedTime);
    $("#ddl_picktime").val(now.getHours() + ':' + minutes_with_leading_zeros( now));
});
function minutes_with_leading_zeros(dt) {
    return (dt.getMinutes() < 10 ? '0' : '') + dt.getMinutes();
}
