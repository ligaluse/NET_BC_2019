// JavaScript source code
/*
document.getElementById('ok').onclick = function () {
    var name = document.getElementById('name').value;
    var age = document.getElementById('age').value;
    // ðis vçl neko neattçlo lietotâjam
    var text = "your name is " + name;
    text += " and you are " + age + "years old";
    // lai attçlotu lietotâjam: 
    document.getElementById('result').innerHTML = text;
    //paslçpt ðo vçrtîbu: un pieðíirt îpaðîbu no css
    // javascriptâ var izmantot gan dubultâs,gan vienas pçdiòas
    document.getElementById('ok').style.display = 'none';
};
*/
//izmanto jquery, zemâk attiecîgs pieraksts: 
$(function(){   //izpildîs tad, kad visa html daïa jau bûtu attçlota
    $("#ok").click(function () {
        var name = $("#name").val(); //var name = document.getElementById('name').value;
        var age = parseInt($("#age").val())   // var age = document.getElementById('age').value;

        age += 5;

        var text = "your name is " + name;
        text += " and you are " + age + "years old";

        $("#result").html(text);  //tas pats kas inner html
        $("#ok").hide(); //document.getElementById('ok').style.display = 'none';
    });
});
$(function () {
    $("#sum").click(function () {
        var num1 = parseInt($("#num1").val()); //var name = document.getElementById('name').value;
        var num2 = parseInt($("#num2").val());  // var age = document.getElementById('age').value;

        var SumNumb = num1 + num2;

        var Sum = "sum is " + SumNumb;
       

        $("#result").html(Sum);  //tas pats kas inner html
        $("#sum").hide(); //document.getElementById('ok').style.display = 'none';
    });
});
$(function () {
    $("#dif").click(function () {
        var num1 = parseInt($("#num1").val()); //var name = document.getElementById('name').value;
        var num2 = parseInt($("#num2").val());  // var age = document.getElementById('age').value;

        var DifNum = num1 - num2;
        var Difference = "Difference is " + DifNum;


        $("#result").html(Difference);  //tas pats kas inner html
        $("#Difference").hide(); //document.getElementById('ok').style.display = 'none';
    });
});

