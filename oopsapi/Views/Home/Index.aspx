<!DOCTYPE html>
<html>
<head>
    <title>Index</title>
    <script src="../oopsapi/Scripts/jquery-1.8.2.min.js"></script>
    <link rel="stylesheet" type="text/css" href="../oopsapi/Content/Site.css">

    <script type="text/javascript">
        $(document).ready(function () {

            $("#btnShow").click(function () {
                var options = {};
                options.url = "http://lwaldtech.com/oopsapi/api/oopsapi/getalloops";
                options.type = "GET";
                options.dataType = "json";
                options.contentType = "application/json";
                options.success = function (results) {
                    $("#imgContainer").empty();
                    $("#imgContainer").append("<table><tr><th>ID</th><th>Event Type</th><th>Action</th><th>Time Stamp</th></tr>")
                    for (var i = 0; i < results.length; i++) {
                        $("#imgContainer").append("<tr><td><img src='" + "/image/api/images/" + results[i] + "'/> <td/><td>2td</td><td>3td</td></tr>");
                    }
                    
                };
                options.error = function (err) { alert(err.statusText); };
                $.ajax(options);
            });

        });
    </script>
</head>
<body>
    <form id="form1">
        <br />
        <br />
        <input type="button" id="btnShow" value="Show" />
        <br />
        <br />
        
        <div id="imgContainer"></div>
        
    </form>
</body>
</html>
