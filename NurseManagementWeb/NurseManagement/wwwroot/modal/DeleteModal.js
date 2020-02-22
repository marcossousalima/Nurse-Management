function Remove(Id, controller, complemento) {
    swal({
        title: "Deletar",
        text: "Deseja Realmente Deletar " + complemento,
        icon: "warning",
        buttons: {
            confirm: { text: 'Deletar', className: 'btn-danger' },
            cancel: 'Cancelar'
        },
    })
        .then((willDelete) => {
            if (willDelete) {
                $.ajax({
                    type: "POST",
                    data: {
                        Id: Id
                    },
                    url: "/"+controller + "/Delete?Id=" + Id,
                    dataType: "json",
                    success: function (response) {
                        swal("Poof! Registro Deletado Com Sucesso!", {
                            icon: "success",
                        }).then(function () {
                            window.location.href = controller
                        });

                    },
                    failure: function (response) {
                        alert('eee');
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
            }
        });
}
