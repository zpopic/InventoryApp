﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//$(document).ready(function () {

// Write your JavaScript code.
$('a:contains("Edit")').text('Uredi');
$('a:contains("Details")').text('Pogledaj')
$('a:contains("Delete")').text('Obriši')
$('a:contains("Create")').text('Dodavanje')
$('button:contains("Delete")').addClass('badge badge-pill badge-danger')

$('a:contains("Uredi")').addClass("btn btn-primary btn-xs");
$('a:contains("Pogledaj")').addClass("btn btn-warning btn-xs");
$('a:contains("Obriši")').addClass("btn btn-danger btn-xs");
$('a:contains("Dodavanje")').addClass("btn btn-success btn-xs");


$('table').each(function () { $(this).find('tr:even').css('background-color', '#ededed') });
$('dd').css({ 'border-bottom': '1px dotted gray', 'height': '2em' });

function confirmDelete(uniqeUserId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqeUserId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqeUserId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}




// Skripta koja rjesava filtriranje drop down menija za visestruku pripadnost (primjer kategorija->vrst kad se odabire Tip aritkla!!)

    var kat = $('#kat');
    var vrst = $('#vrst');

    kat.change(function () { //Kad mijenjas drop-down box na kategoriji, napravi sve ovo dolje... klasterfak

        if ($(this).val() == -1) {

            vrst.empty();
            vrst.append($('<option/>', { value: -1, text: 'Odaberi kategoriju' }));

            vrst.val('-1')
            vrst.prop('disabled', true);

        } else {

            $.ajax({
                url: '/Tip/GetSub', //GetSub je metoda koja pretvara sadrzaj drop-down liste u json format i salje ovdje!
                method: 'post',
                data: { select: $(this).val() },
                dataType: 'json',
                success: function (data) {

                    vrst.empty();
                    vrst.append($('<option/>', { value: -1, text: 'Odaberi kategoriju' }));

                    kat.prop('disabled', false);

                    $(data).each(function (index, item) {
                        vrst.append($('<option/>', { value: item.id, text: item.naziv }));
                    });

                }

            });

        }

    });

//});
