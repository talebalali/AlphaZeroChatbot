
$(function () {

    $("#Enviar").click(
        function () {

            var message = $("#message").val();

            var stringUrl = "api/Chat";

            $.ajax({
                type: "POST",
                url: stringUrl,
                async: false,
                data: { message: message },

                success: function (data) {

                    $("#displaymessage").append(" >> EU : " + message + "\n");
                    $("#displaymessage").append(data.resposta + "\n");

                    $("#message").val("")
                }
            });


        }
    );

});
