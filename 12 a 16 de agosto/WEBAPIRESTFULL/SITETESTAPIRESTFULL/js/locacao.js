
	jQuery(document).ready(function(){

		jQuery('#btnCancelar').click(function(){
			
			$('#Id').val("");
			$('#Tipo').val("");
			$('#Devolucao').val("");
			$('#Livro').val("");
			$('#Usuarios').val("");
			$('#Ativo select').val("true");
		});
		
		GetMethod(null);
	});
	
	
    
    function GetMethod(object){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Locacao",
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
							+ 		'<th>Tipo</th>'
							+ 		'<th>Devolucao</th>'
							+ 		'<th>Livros</th>'
							+ 		'<th>Usuarios</th>'
							+ 		'<th>Ativo</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Tipo  + '</td>'
						+ '<td>' + value.Devolucao   + '</td>'
						+ '<td>' + value.Livros   + '</td>'
						+ '<td>' + value.Usuarios   + '</td>'
						+ '<td>' + value.Ativo    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 		'<button class=\'btn btn-block btn-danger col-md-3 btn-delet-event\' type=\'button\' send-post=\'Locacao\'  value=\''+ value.Id +'\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3  btn-editing-event\' send-post=\'Locacao\' value=\''+ value.Id +'\' type=\'button\'\>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});
		SetGridClickEvents();
    }
	
	
  
  