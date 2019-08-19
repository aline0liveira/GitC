
	jQuery(document).ready(function(){
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Tipo').val("");
			$('#Devolucao').val("");

		});
		
		jQuery('#bntCancelar').click(function(){
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Tipo').val("");
			$('#Devolucao').val("");
			$('#Ativo select').val("true");
		});
		
		GetMethod(null);
	});
	
	function GetByID(id){
      //  $('#bntSubmit').hide();
	//	$('#bntSalvar').show();
		$('#bntCancelar').show();
		
        var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Locacao/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
				$('#Tipo').val(response.Tipo);
				$('#Devolucao').val(response.Devolucao);

			});
		
	}
	
    
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
							+ 		'<th>Ativo</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Tipo  + '</td>'
						+ '<td>' + value.Devolucao   + '</td>'
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
	
	
  
  