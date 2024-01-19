*************************PRUEBA DE C# para Upgrade Business********************************
CARLHOS EDGARDO FIGUEROA TEJADA

Puntos Importantes:
	*El string de conexion se encuentra en appsetting.json.
	*Para poder agregar el appsettin.json e inyeccion de dependencia se ha modificado lo suficiente la clase program.cs
	*Para las operaciones de la base de datos se ha utilizado EntityFramework con un repositorio generico
	*El Repositorio generico tiene manejadores para las excepciones que recibe un delegado tipo action que recibe un objeto tipo excepcion, para este caso envio un metodo helper.
	*La infrastructura esta basada en Clean arquitecture, donde se divide en capas Domain, Core, Persistences, View e Infractructure (esta ultima no fue utilizada pero seria la Capa #4)

Eso es todo. Saludos!!
