
$(function () {
    $("#modal-edit-user").modal();
    Materialize.updateTextFields();
});

function abrirModal(idUsr)
{
    $("#modal-edit-user").modal('open');

    $.post("GetById", { idUsr: idUsr },
        function (data) {
            console.log(data);

            $("#cpfM").val(data.cpf);
            $("#cpfM").addClass("active");

            $("#nomeM").val(data.nome);
            $("#nomeM").addClass("active");

            $("#emailM").val(data.email);
            $("#emailM").addClass("active");

        });
}

function DeletarUsr(idUsr) {
    $.post("DeleteUsr", { idUsr: idUsr },
        function () {

        });
}