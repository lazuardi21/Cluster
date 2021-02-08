$(document).ready(function () {
    var apiBaseUrl = "https://localhost:44375/";
    $('#btnGetData').click(function () {
        debugger
        $.ajax({
            url: apiBaseUrl + 'api/PL_CUSTOMER_CLUSTER',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                var $table = $('<table/>').addClass('dataTable table table-bordered table-striped');
                var $header = $('<thead/>').html('<tr><th>ID</th><th>DATE_TIME</th><th>IDREFPELANGGAN</th><th>HOUR_NUM</th><th>CLUSTER_NUM</th><th>FDVC_NORMALIZED</th></tr>');
                $table.append($header);
                $.each(data, function (i, val) {
                    var $row = $('<tr/>');
                    $row.append($('<td/>').html(val.ID));
                    $row.append($('<td/>').html(val.DATE_STAMP));
                    $row.append($('<td/>').html(val.IDREFPELANGGAN));
                    $row.append($('<td/>').html(val.HOUR_NUM));
                    $row.append($('<td/>').html(val.CLUSTER_NUM));
                    $row.append($('<td/>').html(val.FDVC_NORMALIZED));
                    $table.append($row);
                });
                $('#updatePanel').html($table);
            },
            error: function () {
                alert('Error!');
            }
        });
    });
});  