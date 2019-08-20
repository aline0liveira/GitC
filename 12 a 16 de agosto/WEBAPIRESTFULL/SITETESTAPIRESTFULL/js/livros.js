
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		/* Indica que o evento submit do form irá realizar esta ação agora*/
	
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Registro').val("");
            $('#Titulo').val("");
            $('#Isbn').val("");
            $('#Sinopse').val("");
            $('#Observacoes').val("");
            $('#Ativo select').val("true");

		});
		
		jQuery('#bntCancelar').click(function(){
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Registro').val("");
            $('#Titulo').val("");
            $('#Isbn').val("");
            $('#Sinopse').val("");
            $('#Observacoes').val("");
			$('#Ativo select').val("true");
		});
		
		GetMethod(null);
	});
	
	function GetByID(id){
       // $('#bntSubmit').hide();
		//$('#bntSalvar').show();
		$('#bntCancelar').show();
		
        var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Livros/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
				$('#Registro').val(response.Regitro);
                $('#Titulo').val(response.Titulo);
                $('#Isbn').val(response.Isbn);
                $('#Sinopse').val(response.Sinopse);
                $('#Observacoes').val(response.Observacoes);
                $('#Ativo select').val(response.Ativo);

			});
		
	}

	
    
    function GetMethod(object){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Livros",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
				}

				$.ajax(settings).done(function (response) {
				  RefreshGrid(response);
				});
			
			return false;
    }
   
    function RefreshGrid(contentValue){
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Registro</th>'
                            + 		'<th>Titulo</th>'
                            +       '<th>Isbn</th>'
                            +       '<th>Sinopse</th>'
                            +        '<th>Observacoes</th>'
							+ 		'<th>Ativo</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Regitro    + '</td>'
                        + '<td>' + value.Titulo  + '</td>'
                        + '<td>' + value.Isbn  + '</td>'
                        + '<td>' + value.Sinopse + '</td>'
                        + '<td>' + value.Observacoes + '</td>'
						+ '<td>' + value.Ativo    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax\' type=\'button\'  onclick=\'Deleting('+ value.Id +')\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3\'    type=\'button\'  onclick=\'GetByID('+ value.Id +')\'\>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});
    }
	
	
  
  