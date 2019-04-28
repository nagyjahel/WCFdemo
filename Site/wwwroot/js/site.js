(function ($) {

    function displayIcons() {
        if ($("#value1").val() != '' && $("#value2").val() != '') {
            $(".icons").removeClass("hidden");
            $(".icons").css("display", "inline");
        }
        else {
            return;
        }
        $(".operatorIcon").click(function () {
            var clickedIcon = $(this);
            doOperation(clickedIcon);
        });
    }

    function doOperation(clickedIcon) {
        var val1 = parseFloat($("#value1").val());
        var val2 = parseFloat($("#value2").val());

        switch (clickedIcon.attr('id')) {
            case 'plus':
                getResult('numbers', 'plus', '+', val1, val2);
                break;
            case 'minus':
                getResult('numbers', 'minus', '-', val1, val2);
                break;
            case 'division':
                getResult('numbers', 'divide', '/', val1, val2);
                break;
            case 'multiplication':
                getResult('numbers', 'multiply', '*',val1, val2);
                break;
        }
    }

    function displayResult(val1, val2, resultOfCalculation, typeOfCalculation, operator) {
        if ($('.results').find('.' + typeOfCalculation).length == 0) {
            $('.results').append($('<div>').addClass(typeOfCalculation).append($('<p>').text(val1 + " " + operator + " " +val2 + "= " + resultOfCalculation)));
        }
    }


    function getResult(typeOfValues, typeOfOperation, operator, value1, value2) {
        var url = "/" + typeOfValues+"/"+typeOfOperation;
        $.ajax({

            type: 'GET',

            contentType: "application/json; charset=utf-8",

            url: url,

            data: { 'value1': value1, 'value2': value2},

            async: true,

            success: function (response) {

               displayResult(value1, value2, response.result,typeOfOperation, operator)

            },

            error: function () {

                console.log("Error");

            }

        });
    }

    $(document).ready(function () {
        $(".value").change(function () {
            displayIcons();
        });

    });
})(jQuery);